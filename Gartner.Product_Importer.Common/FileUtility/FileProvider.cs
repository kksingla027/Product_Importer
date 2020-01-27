namespace Gartner.Product_Importer.Common.FileUtility
{
    using Microsoft.Extensions.Options;
    using System;
    using System.IO;
    using System.Text;

    public class FileProvider : IFileProvider
    {
        private readonly IFileSettingManager _fileSettingManager;

        public FileProvider(IOptions<FileSettingManager> settings)
        {
            _fileSettingManager = settings.Value;
        }

        public string ReadFileContent(string sourcePath)
        {
            string result = string.Empty;
            var fullpath = Path.Combine(this._fileSettingManager.RootPath, sourcePath);
            if (File.Exists(fullpath))
            {
                try
                {
                    result = File.ReadAllText(fullpath, Encoding.UTF8);
                }
                catch(Exception ex)
                {
                    // log the exception
                    throw;
                }
            }
            return result;
        }
    }
}
