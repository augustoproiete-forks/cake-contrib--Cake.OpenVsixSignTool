using Cake.Core;
using Cake.Core.IO;
using System;

namespace Cake.OpenVsixSignTool
{
    /// <summary>
    /// OpenVsixSignTool resolver. OpenVsixSignTool should be located alongside the addin.
    /// </summary>
    internal static class OpenVsixSignToolResolver
    {
        public static FilePath GetOpenVsixSignToolPath(IFileSystem fileSystem, ICakeEnvironment environment)
        {
            if (fileSystem == null)
            {
                throw new ArgumentNullException("fileSystem");
            }

            if (environment == null)
            {
                throw new ArgumentNullException("environment");
            }

            var location = typeof(OpenVsixSignToolResolver).Assembly.Location;
            var dir = new DirectoryPath(System.IO.Path.GetDirectoryName(location));
            var filePath = dir.CombineWithFilePath("OpenVsixSignTool.exe");
            return fileSystem.GetFile(filePath).Exists ? filePath : null;
        }
    }
}
