using System;
using System.Text.RegularExpressions;

namespace lab2
{
    public static class XmlPathGenerator
    {
        private const string pattern = @"bin.*";
        private const string xmlDataDir = "XMLData";
        private static readonly string baseDir = AppContext.BaseDirectory;
        private static readonly string basePath = Regex.Replace(baseDir, pattern, "");

        public static string GetPathToGraduateStudentsXmlFile()
        {
            return $"{basePath}{xmlDataDir}\\GraduateStudents.xml";
        }

        public static string GetPathToCustomGraduateStudentsXmlFile()
        {
            return $"{basePath}{xmlDataDir}\\CustomGraduateStudents.xml";
        }

        public static string GetPathToGraduateStudentsXsdFile()
        {
            return $"{basePath}{xmlDataDir}\\GraduateStudent.xsd";
        }

        public static string GetPathToGraduateSupervisorsXmlFile()
        {
            return $"{basePath}{xmlDataDir}\\GraduateSupervisors.xml";
        }

        public static string GetPathToCustomGraduateSupervisorsXmlFile()
        {
            return $"{basePath}{xmlDataDir}\\CustomGraduateSupervisors.xml";
        }

        public static string GetPathToGraduateSupervisorsXsdFile()
        {
            return $"{basePath}{xmlDataDir}\\GraduateSupervisor.xsd";
        }

        public static string GetFilePathToXmlFile(string fileName)
        {
            return $"{basePath}{xmlDataDir}\\{fileName}.xml";
        }
    }
}
