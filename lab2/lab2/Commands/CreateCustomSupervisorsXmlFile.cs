using lab2.Interfaces;
using lab2.Properties;

namespace lab2.Commands
{
    public class CreateCustomSupervisorsXmlFile : ICommand
    {
        private readonly XmlWriterModel xmlWriterModel;
        private readonly string filePath;

        public CreateCustomSupervisorsXmlFile(XmlWriterModel xmlWriterModel, string filePath)
        {
            this.xmlWriterModel = xmlWriterModel;
            this.filePath = filePath;
        }

        public void Execute()
        {
            xmlWriterModel.CreateGraduateSupervisorsXmlFile(filePath);
        }
    }
}
