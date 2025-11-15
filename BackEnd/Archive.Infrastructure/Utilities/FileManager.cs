using Archive.Core.Abstractions.Common.Utilities;
using Archive.Core.DTOs.Common;
using Archive.Core.Exceptions;

namespace Archive.Infrastructure.Utilities
{
    public class FileManager : IFileManager
    {
        public async Task SaveFileAsync(UploadFileDto uploadFileDto, string newFileName, string generatedDirectoryPath)
        {
            Directory.CreateDirectory(generatedDirectoryPath);

            string fileNameWithExtension = newFileName + uploadFileDto.FileExtension;

            await using FileStream fileStream = new(Path.Combine(generatedDirectoryPath, fileNameWithExtension), FileMode.Create, FileAccess.Write);

            await uploadFileDto.FileStream.CopyToAsync(fileStream);
        }

        public async Task DeleteFileAsync(string filePath)
        {
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
            else
            {
                throw new PathNotFoundException($"Wrong file path: {filePath}");
            }
        }
    }
}
