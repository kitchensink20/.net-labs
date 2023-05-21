using lab2.Interfaces;
using lab2.Models;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace lab2.Commands
{
    public class ShowSupervisorsDataFromXmlWithXmlSerializer : ICommand
    {
        private readonly XmlSerializerModel xmlSerializer;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 21;

        public ShowSupervisorsDataFromXmlWithXmlSerializer(XmlSerializerModel xmlSerializer, IConsoleViewer consoleViewer)
        {
            this.xmlSerializer = xmlSerializer;
            this.consoleViewer = consoleViewer;
        }

        public int GetNumber()
        {
            return number;
        }
        public void Execute()
        {

            List<GraduateSupervisor> graduateSupervisors = xmlSerializer.GetGraduateSupervisors(XmlPathGenerator.GetPathToGraduateSupervisorsXmlFile());
            consoleViewer.ShowDeserializedSupervisorsData(graduateSupervisors);
        }
    }
}
