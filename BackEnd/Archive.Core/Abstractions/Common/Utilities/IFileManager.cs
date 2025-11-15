using Archive.Core.DTOs.Common;

namespace Archive.Core.Abstractions.Common.Utilities
{
    public interface IFileManager
    {
        public Task SaveFileAsync(UploadFileDto uploadFileDto, string newFileName, string generatedDirectoryPath);
        public Task DeleteFileAsync(string filePath);
    }
}