// --------------------------------------------------------------------------------------------------
// <copyright file="UserProfile.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using AutoMapper;
using Modules.Identity.Core.Entities;
using Shared.DTOs.Identity.Users;

namespace Modules.Identity.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, AccentUser>().ReverseMap();
            CreateMap<UpdateUserRequest, AccentUser>().ReverseMap();
        }
    }
}