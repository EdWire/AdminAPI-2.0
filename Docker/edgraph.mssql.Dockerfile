# SPDX-License-Identifier: Apache-2.0
# Licensed to the Ed-Fi Alliance under one or more agreements.
# The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
# See the LICENSE and NOTICES files in the project root for more information.

# First two layers use a dotnet/sdk image to build the Admin API from source
# code. The next two layers use the dotnet/aspnet image to run the built code.
# The extra layers in the middle support caching of base layers.

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
RUN apk update && \
    apk upgrade --no-cache && \
    apk add --no-cache musl && \
    rm -rf /var/cache/apk/*

ARG ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT

WORKDIR /source
COPY --from=assets ./Application/NuGet.Config EdFi.Ods.AdminApi/
COPY --from=assets ./Application/EdFi.Ods.AdminApi EdFi.Ods.AdminApi/
RUN rm -f EdFi.Ods.AdminApi/appsettings.Development.json

COPY --from=assets ./Application/NuGet.Config EdFi.Ods.AdminApi.AdminConsole/
COPY --from=assets ./Application/EdFi.Ods.AdminApi.AdminConsole EdFi.Ods.AdminApi.AdminConsole/

COPY --from=assets ./Application/NuGet.Config EdFi.Ods.AdminApi.Common/
COPY --from=assets ./Application/EdFi.Ods.AdminApi.Common EdFi.Ods.AdminApi.Common/

WORKDIR /source/EdFi.Ods.AdminApi
RUN export ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT
RUN dotnet restore && dotnet build -c Release
RUN dotnet publish -c Release /p:EnvironmentName=$ASPNETCORE_ENVIRONMENT --no-build -o /app/EdFi.Ods.AdminApi

WORKDIR /source/EdFi.Ods.AdminApi.AdminConsole
RUN export ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT
RUN dotnet restore && dotnet build -c Release
RUN dotnet publish -c Release /p:EnvironmentName=$ASPNETCORE_ENVIRONMENT --no-build -o /app/EdFi.Ods.AdminApi.AdminConsole

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS runtimebase
RUN apk upgrade --no-cache && \
    apk add --no-cache dos2unix bash gettext icu curl musl && \
    addgroup -S edfi && adduser -S edfi -G edfi

FROM runtimebase AS setup
LABEL maintainer="Ed-Fi Alliance, LLC and Contributors <techsupport@ed-fi.org>"

# Alpine image does not contain Globalization Cultures library so we need to install ICU library to get for LINQ expression to work
# Disable the globaliztion invariant mode (set in base image)
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV ASPNETCORE_HTTP_PORTS=80
ENV DB_FOLDER=mssql

WORKDIR /app
COPY --from=build /app/EdFi.Ods.AdminApi .

COPY --chmod=500 Settings/dev/${DB_FOLDER}/run.sh /app/run.sh
COPY Settings/dev/log4net.config /app/log4net.txt

RUN cp /app/log4net.txt /app/log4net.config && \
    dos2unix /app/*.json && \
    dos2unix /app/*.sh && \
    dos2unix /app/log4net.config && \
    chmod 500 /app/*.sh -- ** && \
    chown -R edfi /app && \
    wget -nv -O /tmp/msodbcsql18_18.4.1.1-1_amd64.apk https://download.microsoft.com/download/7/6/d/76de322a-d860-4894-9945-f0cc5d6a45f8/msodbcsql18_18.4.1.1-1_amd64.apk && \
    wget -nv -O /tmp/mssql-tools18_18.4.1.1-1_amd64.apk https://download.microsoft.com/download/7/6/d/76de322a-d860-4894-9945-f0cc5d6a45f8/mssql-tools18_18.4.1.1-1_amd64.apk && \
    apk --no-cache add --allow-untrusted /tmp/msodbcsql18_18.4.1.1-1_amd64.apk  && \
    apk --no-cache add --allow-untrusted /tmp/mssql-tools18_18.4.1.1-1_amd64.apk && \
    apk del dos2unix

EXPOSE ${ASPNETCORE_HTTP_PORTS}
USER edfi

ENTRYPOINT ["dotnet", "EdFi.Ods.AdminApi.dll"]
