// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.Ods.AdminApi.Features.Applications;
using EdFi.Ods.AdminApi.Infrastructure.ClaimSetEditor;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace EdFi.Ods.AdminApi.Features.ClaimSets;

[SwaggerSchema(Title = "ClaimSet")]
public class ClaimSetModel
{
    public int Id { get; set; }
    public string? Name { get; set; }

    [JsonPropertyName("_isSystemReserved")]
    [SwaggerSchema(ReadOnly = true)]
    public bool IsSystemReserved { get; set; }

    [JsonPropertyName("_applications")]
    [SwaggerSchema(ReadOnly = true)]
    public List<SimpleApplicationModel> Applications { get; set; } = new();
}

[SwaggerSchema(Title = "ClaimSetWithResources")]
public class ClaimSetDetailsModel : ClaimSetModel
{
    public List<ClaimSetResourceClaimModel> ResourceClaims { get; set; } = new();
}

[SwaggerSchema(Title = "ClaimSetResourceClaim")]
public class ClaimSetResourceClaimModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Create { get; set; }
    public bool Read { get; set; }
    public bool Update { get; set; }
    public bool Delete { get; set; }

    [JsonPropertyName("_defaultAuthorizationStrategiesForCRUD")]
    [SwaggerSchema(ReadOnly = true)]
    public List<ClaimSetResourceClaimActionAuthStrategies?> DefaultAuthorizationStrategiesForCRUD { get; set; }

    public List<ClaimSetResourceClaimActionAuthStrategies?> AuthorizationStrategyOverridesForCRUD { get; set; }

    [SwaggerSchema(Description = "Children are collection of ResourceClaim")]
    public List<ClaimSetResourceClaimModel> Children { get; set; }
    public ClaimSetResourceClaimModel()
    {
        Children = new List<ClaimSetResourceClaimModel>();
        DefaultAuthorizationStrategiesForCRUD = new List<ClaimSetResourceClaimActionAuthStrategies?>();
        AuthorizationStrategyOverridesForCRUD = new List<ClaimSetResourceClaimActionAuthStrategies?>();
    }
}

[SwaggerSchema(Title = "ResourceClaimActionModel")]
public class ResourceClaimActionModel
{
    public bool Create { get; set; }
    public bool Read { get; set; }
    public bool Update { get; set; }
    public bool Delete { get; set; }
}

[SwaggerSchema(Title = "ResourceClaimModel")]
public class ResourceClaimModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public string? ParentName { get; set; }

    [SwaggerSchema(Description = "Children are collection of SimpleResourceClaimModel")]
    public List<ResourceClaimModel> Children { get; set; }
    public ResourceClaimModel()
    {
        Children = new List<ResourceClaimModel>();
    }
}

public class EditClaimSetModel : IEditClaimSetModel
{
    public string? ClaimSetName { get; set; }

    public int ClaimSetId { get; set; }
}

public class UpdateResourcesOnClaimSetModel : IUpdateResourcesOnClaimSetModel
{
    public int ClaimSetId { get; set; }

    public List<ResourceClaim>? ResourceClaims { get; set; } = new List<ResourceClaim>();
}

public class DeleteClaimSetModel : IDeleteClaimSetModel
{
    public string? Name { get; set; }

    public int Id { get; set; }
}

public interface IResourceClaimOnClaimSetRequest
{
    int ClaimSetId { get; }
    int ResourceClaimId { get; }
    public ResourceClaimActionModel ResourceClaimActions { get; }
}
