// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.Admin.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EdFi.Ods.AdminApi.Common.Infrastructure.Database;

public static class OdsInstanceModelBuilderExtensions
{
    /// <summary>
    /// Maps <see cref="OdsInstance.ConnectionString"/> as optional so rows with a NULL
    /// ConnectionString can be materialized.
    ///
    /// dbo.OdsInstances.ConnectionString is nullable in both the SQL Server and PostgreSQL
    /// schemas, but the EdFi.Admin.DataAccess entity declares it as a non-nullable string.
    /// EF Core therefore compiles a materializer that reads the column via
    /// SqlDataReader.GetString, which throws SqlNullValueException ("Data is Null.") on a
    /// NULL value. A single such row makes every read of the table fail, so
    /// GET /v2/odsInstances returns 500 and any feature that reads ODS instances
    /// (for example listing applications) fails with it.
    ///
    /// Deployments that source ODS connection strings externally - for example from Azure
    /// App Configuration rather than from the Admin database - legitimately leave this
    /// column NULL. Relaxing the mapping to match the schema lets those rows be read;
    /// consumers already treat the value as optional.
    /// </summary>
    public static ModelBuilder RelaxOdsInstanceConnectionString(this ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);

        modelBuilder.Entity<OdsInstance>().Property(odsInstance => odsInstance.ConnectionString).IsRequired(false);

        return modelBuilder;
    }
}
