// --------------------------------------------------------------------------------------------------
// <copyright file="ISmsService.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Shared.DTOs.Sms;

namespace Shared.Core.Interfaces.Services
{
    public interface ISmsService
    {
        Task SendAsync(SmsRequest request);
    }
}