// --------------------------------------------------------------------------------------------------
// <copyright file="RoleClaimProfile.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using AutoMapper;
using Modules.Identity.Core.Entities;
using Shared.DTOs.Identity.Roles;

namespace Modules.Identity.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, FluentRoleClaim>()
                .ForMember(nameof(FluentRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(FluentRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, FluentRoleClaim>()
                .ForMember(nameof(FluentRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(FluentRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimModel, RoleClaimRequest>();
            CreateMap<RoleClaimModel, FluentRoleClaim>().ReverseMap();
            CreateMap<RoleClaimModel, RoleClaimResponse>().ReverseMap();
        }
    }
}