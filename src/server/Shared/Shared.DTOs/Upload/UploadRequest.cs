// --------------------------------------------------------------------------------------------------
// <copyright file="UploadRequest.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace Shared.DTOs.Upload
{
    public class UploadRequest
    {
        public string FileName { get; set; }

        public string Extension { get; set; }

        public UploadType UploadType { get; set; }

        public string Data { get; set; }
    }
}