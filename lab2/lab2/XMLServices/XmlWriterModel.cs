using System;
using System.Globalization;
using System.Xml;

namespace lab2.Properties
{
    public class XmlWriterModel
    {
        private readonly XmlWriterSettings settings;

        public XmlWriterModel() 
        {
            settings = new XmlWriterSettings();
            settings.Indent = true;
        }

        public void CreateGraduateSupervisorsXmlFile(string filePath)
        {
            int supervisorAmount;
            Console.Write(ConsoleTexts.CreateSupervisorXmlFileStartMessage + "\t");
            while (!int.TryParse(Console.ReadLine(), out supervisorAmount) || supervisorAmount <= 0)
            {
                Console.Write(ConsoleTexts.IntParseErrorMessage + '\t');
            }

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument(); 

                int i = 0;

                writer.WriteStartElement("GraduateSupervisors");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("xsi", "noNamespaceSchemaLocation", null, "GraduateSupervisor.xsd");

                do
                {
                    Console.WriteLine("\nНауковий керівник з айді " + ++i);

                    writer.WriteStartElement("GraduateSupervisor");

                    Console.Write("Введіть повне ім'я наукового керівника:\t");
                    writer.WriteElementString("FullName", Console.ReadLine());

                    Console.Write("Введіть позицію:\t");
                    writer.WriteElementString("Position", Console.ReadLine());

                    writer.WriteElementString("GraduateSupervisorId", i.ToString());

                    writer.WriteEndElement();
                } while (i < supervisorAmount);

                writer.WriteEndElement();
                writer.WriteEndDocument();

                Console.WriteLine("\n" + ConsoleTexts.CreateSupervisorXmlFileSuccessMessage);
            }
        }

        public void CreateGraduateStudentsXmlFile(string filePath)
        {
            int studentAmount;
            Console.Write(ConsoleTexts.CreateStudentXmlFileStartMessage + "\t");
            while (!int.TryParse(Console.ReadLine(), out studentAmount) || studentAmount <= 0)
            {
                Console.Write(ConsoleTexts.IntParseErrorMessage + '\t');
            }
   
            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();

                int i = 0;

                writer.WriteStartElement("GraduateStudents");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("xsi", "noNamespaceSchemaLocation", null, "GraduateStudent.xsd");

                do
                {
                    Console.WriteLine("\nСтудент " + ++i);

                    writer.WriteStartElement("GraduateStudent");


                    Console.Write("Введіть повне ім'я студента:\t");
                    writer.WriteElementString("FullName", Console.ReadLine());

                    Console.Write("Введіть номер групи студента:\t");
                    writer.WriteElementString("GroupNumber", Console.ReadLine());

                    Console.Write("Введіть дату народження студента(dd-mm-yyyy):\t");
                    DateTime birthDate;
                    while (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                    {
                        Console.Write(ConsoleTexts.DateTimeParseErrorMessage + '\t');
                    }
                    writer.WriteElementString("BirthDate", birthDate.ToString("dd-mm-yyyy"));

                    Console.Write("Введіть середній бал студента:\t");
                    double averageScore;
                    while (!double.TryParse(Console.ReadLine(), out averageScore) || averageScore < 60 || averageScore > 100)
                    {
                        Console.Write(ConsoleTexts.DoubleParseErrorMessage + "\t");
                    }
                    writer.WriteElementString("AverageScore", averageScore.ToString());

                    Console.Write("Введіть айді наукового керівника:\t");
                    int graduateSupervisorId;
                    while (!Int32.TryParse(Console.ReadLine(), out graduateSupervisorId) || averageScore < 0)
                    {
                        Console.Write(ConsoleTexts.IntParseErrorMessage + "\t");
                    }
                    writer.WriteElementString("SupervisorId", graduateSupervisorId.ToString());

                    writer.WriteEndElement();
                } while (i < studentAmount);

                writer.WriteEndElement();
                writer.WriteEndDocument();

                Console.WriteLine("\n" + ConsoleTexts.CreateStudentXmlFileSuccessMessage);
            }
        }
    }
}
