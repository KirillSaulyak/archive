using Archive.Core.Abstractions.Common.Utilities;
using Archive.Core.DTOs.Common;

namespace Archive.Infrastructure.Utilities
{
    public class FileManager : IFileManager
    {
        public async Task SaveFileAsync(UploadFileDto uploadFileDto, string newFileName, string generatedFilePath)
        {

            Directory.CreateDirectory(generatedFilePath);

            string fileNameWithExtension = newFileName + uploadFileDto.FileExtension;

            await using FileStream fileStream = new(Path.Combine(generatedFilePath, fileNameWithExtension), FileMode.Create, FileAccess.Write);

            await uploadFileDto.FileStream.CopyToAsync(fileStream);
        }

        public async Task DeleteFileAsync(string filePath)
        {
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
    }
}
