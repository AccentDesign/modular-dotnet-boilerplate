// --------------------------------------------------------------------------------------------------
// <copyright file="IMailService.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Shared.DTOs.Mails;

namespace Shared.Core.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}