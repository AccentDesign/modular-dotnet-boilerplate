// --------------------------------------------------------------------------------------------------
// <copyright file="IUploadService.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Shared.DTOs.Upload;

namespace Shared.Core.Interfaces.Services
{
    public interface IUploadService
    {
        Task<string> UploadAsync(UploadRequest request);
    }
}