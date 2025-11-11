using Archive.Services.Enums.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Services.Abstractions.Factories.Common
{
    public interface IFilePathFactory
    {
        string GenerateFilePath(EntitySpace entitySpace, string entityFolderType);
    }
}
