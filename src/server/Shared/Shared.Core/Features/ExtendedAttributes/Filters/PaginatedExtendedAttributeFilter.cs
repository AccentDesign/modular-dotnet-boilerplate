// --------------------------------------------------------------------------------------------------
// <copyright file="PaginatedExtendedAttributeFilter.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

#nullable enable

using Shared.Core.Contracts;
using Shared.DTOs.ExtendedAttributes;
using Shared.DTOs.Filters;

namespace Shared.Core.Features.ExtendedAttributes.Filters
{
    // ReSharper disable once UnusedTypeParameter
    public class PaginatedExtendedAttributeFilter<TEntityId, TEntity> : PaginatedFilter
        where TEntity : class, IEntity<TEntityId>
    {
        public string? SearchString { get; set; }

        public TEntityId? EntityId { get; set; }

        public ExtendedAttributeType? Type { get; set; }
    }
}