using lab2.Interfaces;
using lab2.Models;
using System.Collections.Generic;
using System.Xml;

namespace lab2.Commands
{
    public class ShowStudentsDataFromXmlWithXmlReader : ICommand
    {
        private readonly XmlReaderModel xmlReader;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 20;

        public ShowStudentsDataFromXmlWithXmlReader(XmlReaderModel xmlReader, IConsoleViewer consoleViewer)
        {
            this.xmlReader = xmlReader;
            this.consoleViewer = consoleViewer;
        }

        public int GetNumber()
        {
            return number;
        }
        public void Execute()
        {
            XmlDocument studentsDoc = XmlLoaderModel.LoadXMLFile(XmlPathGenerator.GetPathToGraduateStudentsXmlFile());
            List<GraduateStudent> graduateStudents = xmlReader.GetGraduateStudents(studentsDoc);
            consoleViewer.ShowDeserializedStudentsData(graduateStudents);
        }
    }
}
