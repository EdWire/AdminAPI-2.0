// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Text;
using EdFi.Admin.DataAccess.Models;
using EdFi.Ods.AdminApi.AdminConsole.Features.Instances;
using EdFi.Ods.AdminApi.AdminConsole.Features.WorkerInstances;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.DataAccess.Models;
using EdFi.Ods.AdminApi.Features.Actions;
using EdFi.Ods.AdminApi.Features.Applications;
using EdFi.Ods.AdminApi.Features.AuthorizationStrategies;
using EdFi.Ods.AdminApi.Features.ClaimSets;
using EdFi.Ods.AdminApi.Features.OdsInstanceContext;
using EdFi.Ods.AdminApi.Features.OdsInstanceDerivative;
using EdFi.Ods.AdminApi.Features.ODSInstances;
using EdFi.Ods.AdminApi.Features.Profiles;
using EdFi.Ods.AdminApi.Features.ResourceClaimActionAuthStrategies;
using EdFi.Ods.AdminApi.Features.ResourceClaimActions;
using EdFi.Ods.AdminApi.Features.Vendors;
using EdFi.Ods.AdminApi.Infrastructure.AutoMapper;
using EdFi.Ods.AdminApi.Infrastructure.ClaimSetEditor;
using EdFi.Ods.AdminApi.Infrastructure.Database.Commands;
using EdFi.Ods.AdminApi.Infrastructure.Helpers;
using Newtonsoft.Json;
using OverrideAuthStategyOnClaimSetRequest = EdFi.Ods.AdminApi.Features.ClaimSets.ResourceClaims.EditAuthStrategy.OverrideAuthStategyOnClaimSetRequest;
using Profile = AutoMapper.Profile;

namespace EdFi.Ods.AdminApi.Infrastructure;

public class AdminApiMappingProfile : Profile
{
    public AdminApiMappingProfile()
    {
        CreateMap<Vendor, EditVendor.EditVendorRequest>()
            .ForMember(dst => dst.Company, opt => opt.MapFrom(src => src.VendorName))
            .ForMember(dst => dst.ContactName, opt => opt.MapFrom(src => src.ContactName()))
            .ForMember(dst => dst.ContactEmailAddress, opt => opt.MapFrom(src => src.ContactEmail()))
            .ForMember(dst => dst.NamespacePrefixes, opt => opt.MapFrom(src => src.VendorNamespacePrefixes.ToCommaSeparated()));

        CreateMap<Vendor, VendorModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.VendorId))
            .ForMember(dst => dst.Company, opt => opt.MapFrom(src => src.VendorName))
            .ForMember(dst => dst.ContactName, opt => opt.MapFrom(src => src.ContactName()))
            .ForMember(dst => dst.ContactEmailAddress, opt => opt.MapFrom(src => src.ContactEmail()))
            .ForMember(dst => dst.NamespacePrefixes, opt => opt.MapFrom(src => src.VendorNamespacePrefixes.ToCommaSeparated()));

        CreateMap<Admin.DataAccess.Models.Application, ApplicationModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ApplicationId))
            .ForMember(dst => dst.EducationOrganizationIds, opt => opt.MapFrom(src => src.EducationOrganizationIds()))
            .ForMember(dst => dst.VendorId, opt => opt.MapFrom(src => src.VendorId()))
            .ForMember(dst => dst.ProfileIds, opt => opt.MapFrom(src => src.Profiles()))
            .ForMember(dst => dst.Enabled, opt => opt.MapFrom(src => src.ApiClients.All(a => a.IsApproved)))
            .ForMember(dst => dst.OdsInstanceIds, opt =>
            {
                opt.ConvertUsing<OdsInstanceIdsForApplicationConverter, int>("ApplicationId");
            });

        CreateMap<Infrastructure.ClaimSetEditor.Application, SimpleApplicationModel>()
            .ForMember(dst => dst.ApplicationName, opt => opt.MapFrom(src => src.Name));

        CreateMap<AddApplicationResult, ApplicationResult>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ApplicationId))
            .ForMember(dst => dst.Key, opt => opt.MapFrom(src => src.Key))
            .ForMember(dst => dst.Secret, opt => opt.MapFrom(src => src.Secret));

        CreateMap<RegenerateApiClientSecretResult, ApplicationResult>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Application.ApplicationId))
            .ForMember(dst => dst.Key, opt => opt.MapFrom(src => src.Key))
            .ForMember(dst => dst.Secret, opt => opt.MapFrom(src => src.Secret));

        CreateMap<ClaimSetEditor.ClaimSet, ClaimSetDetailsModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.IsSystemReserved, opt => opt.MapFrom(src => !src.IsEditable));

        CreateMap<ClaimSetEditor.ClaimSet, ClaimSetModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.IsSystemReserved, opt => opt.MapFrom(src => !src.IsEditable));

        CreateMap<ClaimSetEditor.ResourceClaim, ClaimSetResourceClaimModel>()
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.Actions, opt => opt.MapFrom(src => src.Actions))
            .ForMember(dst => dst.AuthorizationStrategyOverridesForCRUD, opt => opt.MapFrom(src => src.AuthorizationStrategyOverridesForCRUD))
            .ForMember(dst => dst.DefaultAuthorizationStrategiesForCRUD, opt => opt.MapFrom(src => src.DefaultAuthorizationStrategiesForCRUD))
            .ForMember(dst => dst.Children, opt => opt.MapFrom(src => src.Children));

        CreateMap<ClaimSetResourceClaimModel, ChildrenClaimSetResource>()
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.Actions, opt => opt.MapFrom(src => src.Actions))
            .ForMember(dst => dst.AuthorizationStrategyOverridesForCRUD, opt => opt.MapFrom(src => src.AuthorizationStrategyOverridesForCRUD))
            .ForMember(dst => dst.DefaultAuthorizationStrategiesForCRUD, opt => opt.MapFrom(src => src.DefaultAuthorizationStrategiesForCRUD))
            .ForMember(dst => dst.Children, opt => opt.MapFrom(src => src.Children));

        CreateMap<IResourceClaimOnClaimSetRequest, EditResourceOnClaimSetModel>()
            .ForMember(dst => dst.ClaimSetId, opt => opt.MapFrom(src => src.ClaimSetId))
            .ForMember(dst => dst.ResourceClaim, opt => opt.MapFrom<ResourceClaimResolver>());

        CreateMap<OverrideAuthStategyOnClaimSetRequest, OverrideAuthStrategyOnClaimSetModel>()
            .ForMember(dst => dst.ClaimSetId, opt => opt.MapFrom(src => src.ClaimSetId))
            .ForMember(dst => dst.ResourceClaimId, opt => opt.MapFrom(src => src.ResourceClaimId))
            .ForMember(dst => dst.ActionName, opt => opt.MapFrom(src => src.ActionName))
            .ForMember(dst => dst.AuthStrategyIds, opt => { opt.ConvertUsing<AuthStrategyIdsConverter, List<string>>("AuthorizationStrategies"); });

        CreateMap<EdFi.Security.DataAccess.Models.AuthorizationStrategy, EdFi.Ods.AdminApi.Infrastructure.ClaimSetEditor.AuthorizationStrategy>()
            .ForMember(dst => dst.AuthStrategyName, opt => opt.MapFrom(src => src.AuthorizationStrategyName))
            .ForMember(dst => dst.AuthStrategyId, opt => opt.MapFrom(src => src.AuthorizationStrategyId))
            .ForMember(dst => dst.IsInheritedFromParent, opt => opt.Ignore());

        CreateMap<EdFi.Security.DataAccess.Models.AuthorizationStrategy, AuthorizationStrategyModel>()
            .ForMember(dst => dst.AuthStrategyName, opt => opt.MapFrom(src => src.AuthorizationStrategyName))
            .ForMember(dst => dst.AuthStrategyId, opt => opt.MapFrom(src => src.AuthorizationStrategyId))

            .ForMember(dst => dst.DisplayName, opt => opt.MapFrom(src => src.DisplayName));

        CreateMap<ClaimSetResourceClaimModel, EdFi.Ods.AdminApi.Infrastructure.ClaimSetEditor.ResourceClaim>()
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.Actions, opt => opt.MapFrom(src => src.Actions))
            .ForMember(dst => dst.AuthorizationStrategyOverridesForCRUD, opt => opt.MapFrom(src => src.AuthorizationStrategyOverridesForCRUD))
            .ForMember(dst => dst.DefaultAuthorizationStrategiesForCRUD, opt => opt.MapFrom(src => src.DefaultAuthorizationStrategiesForCRUD))
            .ForMember(dst => dst.Children, opt => opt.MapFrom(src => src.Children));

        CreateMap<EdFi.Ods.AdminApi.Infrastructure.ClaimSetEditor.ResourceClaim, ResourceClaimModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.ParentId, opt => opt.MapFrom(src => src.ParentId))
            .ForMember(dst => dst.ParentName, opt => opt.MapFrom(src => src.ParentName))
            .ForMember(dst => dst.Children, opt => opt.MapFrom(src => src.Children));

        CreateMap<OdsInstance, OdsInstanceModel>()
            .ForMember(dst => dst.OdsInstanceId, opt => opt.MapFrom(src => src.OdsInstanceId))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name));

        CreateMap<EdFi.Security.DataAccess.Models.Action, ActionModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ActionId))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.ActionName))
            .ForMember(dst => dst.Uri, opt => opt.MapFrom(src => src.ActionUri));

        CreateMap<EdFi.Admin.DataAccess.Models.Profile, ProfileModel>()
          .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ProfileId))
          .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.ProfileName));

        CreateMap<EdFi.Admin.DataAccess.Models.Profile, ProfileDetailsModel>()
          .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ProfileId))
          .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.ProfileName))
          .ForMember(dst => dst.Definition, opt => opt.MapFrom(src => src.ProfileDefinition));

        CreateMap<EdFi.Admin.DataAccess.Models.OdsInstanceDerivative, OdsInstanceDerivativeModel>()
           .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.OdsInstanceDerivativeId))
           .ForMember(dst => dst.OdsInstanceId, opt => opt.MapFrom(src => src.OdsInstance.OdsInstanceId))
           .ForMember(dst => dst.DerivativeType, opt => opt.MapFrom(src => src.DerivativeType));

        CreateMap<EdFi.Admin.DataAccess.Models.OdsInstanceContext, OdsInstanceContextModel>()
           .ForMember(dst => dst.OdsInstanceContextId, opt => opt.MapFrom(src => src.OdsInstanceContextId))
           .ForMember(dst => dst.OdsInstanceId, opt => opt.MapFrom(src => src.OdsInstance.OdsInstanceId))
           .ForMember(dst => dst.ContextKey, opt => opt.MapFrom(src => src.ContextKey))
           .ForMember(dst => dst.ContextValue, opt => opt.MapFrom(src => src.ContextValue));

        CreateMap<OdsInstance, OdsInstanceDetailModel>()
            .ForMember(dst => dst.OdsInstanceId, opt => opt.MapFrom(src => src.OdsInstanceId))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dst => dst.OdsInstanceDerivatives, opt => opt.MapFrom(src => src.OdsInstanceDerivatives))
            .ForMember(dst => dst.OdsInstanceContexts, opt => opt.MapFrom(src => src.OdsInstanceContexts));

        CreateMap<EdFi.Security.DataAccess.Models.ResourceClaimAction, ResourceClaimActionModel>()
            .ForMember(dest => dest.ResourceClaimId, opt => opt.MapFrom(src => src.ResourceClaim.ResourceClaimId))
            .ForMember(dest => dest.ResourceName, opt => opt.MapFrom(src => src.ResourceClaim.ResourceName))
            .ForMember(dest => dest.Actions, opt => opt.Ignore());//Action is ignore as we build it manually

        CreateMap<Instance, InstanceModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.TenantId, opt => opt.MapFrom(src => src.TenantId))
            .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.InstanceName))
            .ForMember(dst => dst.InstanceType, opt => opt.MapFrom(src => src.InstanceType))
            .ForMember(dst => dst.BaseUrl, opt => opt.MapFrom(src => src.BaseUrl))
            .ForMember(dst => dst.OdsInstanceContexts, opt => opt.MapFrom(src => src.OdsInstanceContexts))
            .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dst => dst.OdsInstanceDerivatives, opt => opt.MapFrom(src => src.OdsInstanceDerivatives));

        CreateMap<Instance, InstanceWorkerModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.TenantId, opt => opt.MapFrom(src => src.TenantId))
            .ForMember(dst => dst.TenantName, opt => opt.MapFrom(src => src.TenantName))
            .ForMember(dst => dst.OdsInstanceId, opt => opt.MapFrom(src => src.OdsInstanceId))
            .ForMember(dst => dst.InstanceName, opt => opt.MapFrom(src => src.InstanceName))
            .ForMember(dst => dst.ResourceUrl, opt => opt.MapFrom(src => src.ResourceUrl ?? string.Empty))
            .ForMember(dst => dst.oAuthUrl, opt => opt.MapFrom(src => src.OAuthUrl))
            .ForMember(dst => dst.Status, opt => opt.MapFrom(src => Enum.GetName(src.Status)))
            .AfterMap((src, dst) =>
            {
                if (src.Credentials != null)
                {
                    var credentials = JsonConvert.DeserializeObject<InstanceWorkerModelDto>(Encoding.UTF8.GetString(src.Credentials));
                    dst.ClientId = credentials?.ClientId;
                    dst.ClientSecret = credentials?.Secret;
                }
            });

        CreateMap<AdminConsole.Infrastructure.DataAccess.Models.OdsInstanceContext, OdsInstanceContextForInstanceModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.InstanceId, opt => opt.MapFrom(src => src.InstanceId))
            .ForMember(dst => dst.ContextKey, opt => opt.MapFrom(src => src.ContextKey))
            .ForMember(dst => dst.ContextValue, opt => opt.MapFrom(src => src.ContextValue));

        CreateMap<AdminConsole.Infrastructure.DataAccess.Models.OdsInstanceDerivative, OdsInstanceDerivativeForInstanceModel>()
            .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dst => dst.InstanceId, opt => opt.MapFrom(src => src.InstanceId))
            .ForMember(dst => dst.DerivativeType, opt => opt.MapFrom(src => src.DerivativeType));

        CreateMap<Admin.DataAccess.Models.OdsInstanceContext, AdminConsole.Infrastructure.Services.Instances.Models.OdsInstanceContextModel>()
            .ForMember(dst => dst.ContextKey, opt => opt.MapFrom(src => src.ContextKey))
            .ForMember(dst => dst.ContextValue, opt => opt.MapFrom(src => src.ContextValue));

        CreateMap<Admin.DataAccess.Models.OdsInstanceDerivative, AdminConsole.Infrastructure.Services.Instances.Models.OdsInstanceDerivativeModel>()
            .ForMember(dst => dst.DerivativeType, opt => opt.MapFrom(src => src.DerivativeType));
    }
}
