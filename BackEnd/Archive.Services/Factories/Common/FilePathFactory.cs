using Archive.Core.Exceptions;
using Archive.Services.Abstractions.Factories.Common;
using Archive.Services.Enums.Common;
using Microsoft.Extensions.Configuration;

namespace Archive.Services.Factories.Common
{
    public class FilePathFactory(IConfiguration configuration) : IFilePathFactory
    {
        public string GenerateFilePath(EntitySpace entitySpace, string entityFolderType)
        {
            string basePath = configuration["FileStorage" + ":" + "BasePath"] ?? throw new PathNotFoundException("Wrong path: " + entitySpace.ToString() + ":" + entityFolderType);

            string entityPath = configuration["FileStorage" + ":" + entitySpace + ":" + entityFolderType] ?? throw new PathNotFoundException("Wrong path: " + entitySpace.ToString() + ":" + entityFolderType);

            return Path.Combine(basePath, entityPath);
        }
    }
}
