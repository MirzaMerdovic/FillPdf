using System;
using System.IO;
using System.Text;

namespace Selma.DataAccess
{
    public static class Helper
    {
        public static string GetOrCreateDataPath()
        {
            var currentDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            var rootPath = currentDirectory.Parent.Parent.FullName;

            var dataPath = Path.Combine(rootPath, @"Data\Candidates");

            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);

            return dataPath;
        }

        public static string GetOrCreateParentPath(string parentFolderName)
        {
            var parentPath = Path.Combine(GetOrCreateDataPath(), parentFolderName);

            if (!Directory.Exists(parentPath))
                Directory.CreateDirectory(parentPath);

            return parentPath;
        }

        public static void SaveCandidate(string path, string candidateJson)
        {
            File.WriteAllText(path, candidateJson, Encoding.GetEncoding("ISO-8859-2"));
        }

        public static string ReadCandidateJson(string candidatePath)
        {
            return File.ReadAllText(candidatePath, Encoding.GetEncoding("ISO-8859-2"));
        }
    }
}