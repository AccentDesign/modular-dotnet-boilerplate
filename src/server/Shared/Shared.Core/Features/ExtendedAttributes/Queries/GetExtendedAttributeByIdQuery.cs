// --------------------------------------------------------------------------------------------------
// <copyright file="GetExtendedAttributeByIdQuery.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using MediatR;
using Shared.Core.Contracts;
using Shared.Core.Queries;
using Shared.Core.Wrapper;
using Shared.DTOs.ExtendedAttributes;

namespace Shared.Core.Features.ExtendedAttributes.Queries
{
    // ReSharper disable once UnusedTypeParameter
    public class GetExtendedAttributeByIdQuery<TEntityId, TEntity> : IRequest<Result<GetExtendedAttributeByIdResponse<TEntityId>>>, ICacheable
        where TEntity : class, IEntity<TEntityId>
    {
        public Guid Id { get; protected set; }

        public bool BypassCache { get; protected set; }

        public string CacheKey { get; protected set; }

        public TimeSpan? SlidingExpiration { get; protected set; }
    }
}