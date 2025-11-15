using Archive.Services.Enums.Common;

namespace Archive.Services.Abstractions.Factories.Common
{
    public interface IFilePathFactory
    {
        string GenerateFilePath(EntitySpace entitySpace, string entityFolderType);
    }
}
