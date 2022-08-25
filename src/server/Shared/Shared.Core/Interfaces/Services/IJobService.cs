// --------------------------------------------------------------------------------------------------
// <copyright file="IJobService.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Shared.Core.Interfaces.Services
{
    public interface IJobService
    {
        string Enqueue(Expression<Func<Task>> methodCall);
    }
}