namespace Archive.Core.DTOs.Common
{
    public class UploadFileDto
    {
        private string _originalFileName;
        public Stream FileStream { get; }
        public string FileExtension => Path.GetExtension(_originalFileName);

        public UploadFileDto(Stream fileStream, string originalFileName)
        {
            FileStream = fileStream;
            _originalFileName = originalFileName;
        }
    }
}
