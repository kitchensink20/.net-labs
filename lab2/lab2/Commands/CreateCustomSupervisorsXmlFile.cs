using lab2.Interfaces;
using lab2.Properties;

namespace lab2.Commands
{
    public class CreateCustomSupervisorsXmlFile : ICommand
    {
        private readonly XmlWriterModel xmlWriterModel;
        private readonly string filePath;
        private const int number = 1;

        public CreateCustomSupervisorsXmlFile(XmlWriterModel xmlWriterModel, string filePath)
        {
            this.xmlWriterModel = xmlWriterModel;
            this.filePath = filePath;
        }

        public int GetNumber()
        {
            return number;
        }
        public void Execute()
        {
            xmlWriterModel.CreateGraduateSupervisorsXmlFile(filePath);
        }
    }
}
