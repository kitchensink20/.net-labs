using lab2.Interfaces;
using lab2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Commands
{
    public class CreateCustomStudentsXmlFile : ICommand
    {
        private readonly XmlWriterModel xmlWriterModel;
        private readonly string filePath;

        public CreateCustomStudentsXmlFile(XmlWriterModel xmlWriterModel, string filePath)
        {
            this.xmlWriterModel = xmlWriterModel;
            this.filePath = filePath;
        }

        public void Execute()
        {
            xmlWriterModel.CreateGraduateStudentsXmlFile(filePath);
        }
    }
}
