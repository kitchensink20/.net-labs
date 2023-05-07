using lab2.Commands;
using lab2.Interfaces;
using lab2.Models;
using lab2.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            XmlValidatorModel.AddNewXmlSchema(XmlPathGenerator.GetPathToGraduateSupervisorsXsdFile());
            XmlValidatorModel.AddNewXmlSchema(XmlPathGenerator.GetPathToGraduateStudentsXsdFile());
            XmlValidatorModel.Validate(XmlPathGenerator.GetPathToGraduateSupervisorsXmlFile());
            XmlValidatorModel.Validate(XmlPathGenerator.GetPathToGraduateStudentsXmlFile());

            XmlWriterModel xmlWriter = new XmlWriterModel();
            xmlWriter.CreateGraduateSupervisorsXmlFile(XmlPathGenerator.GetPathToCustomGraduateSupervisorsXmlFile());
         
            IConsoleViewer consoleViewer = new ConsoleViewer();
            IDataRepository dataRepository = new DataRepository(XmlPathGenerator.GetPathToCustomGraduateStudentsXmlFile(), 
                                                                XmlPathGenerator.GetPathToCustomGraduateSupervisorsXmlFile(),
                                                                XmlPathGenerator.GetPathToCustomGraduateStudentsXmlFile(),
                                                                XmlPathGenerator.GetPathToCustomGraduateSupervisorsXmlFile());

      
            
            Console.ReadKey();
        }
    }
}
