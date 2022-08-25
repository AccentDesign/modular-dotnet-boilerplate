// --------------------------------------------------------------------------------------------------
// <copyright file="ExtendedAttributesProfile.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Reflection;
using AutoMapper;
using Shared.Core.Extensions;

namespace Modules.Identity.Core.Mappings
{
    public class ExtendedAttributesProfile : Profile
    {
        public ExtendedAttributesProfile()
        {
            this.CreateExtendedAttributesMappings(Assembly.GetExecutingAssembly());
        }
    }
}