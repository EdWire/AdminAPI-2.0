// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.Ods.AdminApi.AdminConsole;
using EdFi.Ods.AdminApi.AdminConsole.Configurations;
using EdFi.Ods.AdminApi.Common.Constants;
using EdFi.Ods.AdminApi.Common.Infrastructure;
using EdFi.Ods.AdminApi.Common.Infrastructure.MultiTenancy;
using EdFi.Ods.AdminApi.Features;
using EdFi.Ods.AdminApi.Infrastructure;
using log4net;
using log4net.Config;

var builder = WebApplication.CreateBuilder(args);

// Initialize log4net early so we can use it in Program.cs
var log4netConfigFileName = builder.Configuration.GetValue<string>("Log4NetCore:Log4NetConfigFileName");
if (!string.IsNullOrEmpty(log4netConfigFileName))
{
    var log4netConfigPath = Path.Combine(AppContext.BaseDirectory, log4netConfigFileName);
    if (File.Exists(log4netConfigPath))
    {
        var log4netConfig = new FileInfo(log4netConfigPath);
        XmlConfigurator.Configure(LogManager.GetRepository(), log4netConfig);
    }
}

// logging
var _logger = LogManager.GetLogger("Program");
_logger.Info("Starting Admin API");
var adminConsoleIsEnabled = builder.Configuration.GetValue<bool>("AppSettings:EnableAdminConsoleAPI");
var adminApiMode = builder.Configuration.GetValue<AdminApiMode>("AppSettings:AdminApiMode", AdminApiMode.V2);
var databaseEngine = builder.Configuration.GetValue<string>("AppSettings:DatabaseEngine");

// Log configuration values as requested
_logger.InfoFormat("Configuration - ApiMode: {0}, Engine: {1}", adminApiMode, databaseEngine);

//Order is important to enable CORS
if (adminConsoleIsEnabled && adminApiMode == AdminApiMode.V2)
    builder.RegisterAdminConsoleCorsDependencies(_logger);

builder.AddServices();

if (adminConsoleIsEnabled && adminApiMode == AdminApiMode.V2)
    builder.RegisterAdminConsoleDependencies();

IConfigurationSection azureAppConfigurationSection = builder.Configuration.GetSection("AzureAppConfiguration");
bool.TryParse(azureAppConfigurationSection["Enabled"], out bool isAzureAppConfigurationEnabled);

if (isAzureAppConfigurationEnabled)
    builder.AddAzureAppConfiguration(azureAppConfigurationSection);

var app = builder.Build();

if (isAzureAppConfigurationEnabled)
    app.UseAzureAppConfiguration();

//Order is important to enable CORS
if (adminConsoleIsEnabled && adminApiMode == AdminApiMode.V2)
    app.UseCorsForAdminConsole();

var pathBase = app.Configuration.GetValue<string>("AppSettings:PathBase");
if (!string.IsNullOrEmpty(pathBase))
{
    app.UsePathBase($"/{pathBase.Trim('/')}");
    app.UseForwardedHeaders();
}

AdminApiVersions.Initialize(app);

//The ordering here is meaningful: Logging -> Routing -> Auth -> Endpoints
app.UseMiddleware<RequestLoggingMiddleware>();
app.UseMiddleware<AdminApiModeValidationMiddleware>();

if (adminApiMode == AdminApiMode.V2)
    app.UseMiddleware<TenantResolverMiddleware>();

app.UseRouting();
app.UseAuthentication();
app.UseRateLimiter();
app.UseAuthorization();
app.MapFeatureEndpoints();

//Map AdminConsole endpoints if the flag is enable
if (adminConsoleIsEnabled && adminApiMode == AdminApiMode.V2)
{
    app.MapAdminConsoleFeatureEndpoints();
}

app.MapControllers();
app.UseHealthChecks("/health");

if (app.Configuration.GetValue<bool>("SwaggerSettings:EnableSwagger"))
{
    app.UseSwagger();
    app.DefineSwaggerUIWithApiVersions(AdminApiVersions.GetAllVersionStrings());
}

await app.RunAsync();
