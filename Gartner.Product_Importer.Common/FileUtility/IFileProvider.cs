using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.Common.FileUtility
{
    public interface IFileProvider
    {
        string ReadFileContent(string sourcePath);
    }
}
