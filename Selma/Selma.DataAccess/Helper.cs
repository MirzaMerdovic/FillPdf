using System;
using System.Configuration;
using System.IO;
using System.Text;
using NLog;

namespace Selma.DataAccess
{
    public static class Helper
    {
        public static readonly ILogger Logger = LogManager.GetLogger("selma");

        public static string GetPdfTemplateLocation()
        {
            var templateLocation = Path.Combine(GetRootPath(), @"Data\Prazna.pdf");

            return templateLocation;
        }

        public static string GetExamApplicationsFolder()
        {
            var tempPath = Path.Combine(GetRootPath(), @"Data\Prijave");

            if (!Directory.Exists(tempPath))
                Directory.CreateDirectory(tempPath);

            return tempPath;
        }

        public static string GetLogsLocation()
        {
            var logPath = Path.Combine(GetRootPath(), DateTime.Now.Date.ToString("ddmmYYYY"));

            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            return logPath;
        }

        public static string GetOrCreateDataPath()
        {
            var rootPath = GetRootPath();
            var dataPath = Path.Combine(rootPath, @"Data\Kandidati");

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

        public static void SaveCandidateJson(string path, string candidateJson)
        {
            File.WriteAllText(path, candidateJson, Encoding.GetEncoding("ISO-8859-2"));
        }

        public static string ReadCandidateJson(string candidatePath)
        {
            return File.ReadAllText(candidatePath, Encoding.GetEncoding("ISO-8859-2"));
        }

        public static string GetSchoolName()
        {
            return ConfigurationManager.AppSettings["SchoolName"] ?? "Selma";
        }

        private static string GetRootPath()
        {
            var currentDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            var rootPath = currentDirectory.Parent.Parent.FullName;

            return rootPath;
        }
    }
}