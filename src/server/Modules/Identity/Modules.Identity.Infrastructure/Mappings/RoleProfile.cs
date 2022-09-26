// --------------------------------------------------------------------------------------------------
// <copyright file="RoleProfile.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using AutoMapper;
using Modules.Identity.Core.Entities;
using Shared.DTOs.Identity.Roles;

namespace Modules.Identity.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, AccentRole>().ReverseMap();
        }
    }
}