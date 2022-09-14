// --------------------------------------------------------------------------------------------------
// <copyright file="IIdentityDbContext.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Modules.Identity.Core.Entities;
using Shared.Core.Interfaces;

namespace Modules.Identity.Core.Abstractions
{
    public interface IIdentityDbContext : IDbContext
    {
        public DbSet<AccentUser> Users { get; set; }

        public DbSet<AccentRole> Roles { get; set; }

        public DbSet<AccentRoleClaim> RoleClaims { get; set; }
    }
}