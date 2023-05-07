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
                    writer.WriteElementString("GraduateSupervisorId", graduateSupervisorId.ToString());

                    writer.WriteEndElement();
                } while (i < studentAmount);

                writer.WriteEndElement();
                writer.WriteEndDocument();

                Console.WriteLine("\n" + ConsoleTexts.CreateStudentXmlFileSuccessMessage);
            }
        }
    }
}

/*
    XmlWriterSettings клас, що використвоється для того, щоб задати параметри для
    XmlWriter. Параметр Indent вказує на те чи треба робити відступи між рядками.

    XmlWriter це клас, що надає можливість записувати XML дані в файл або поток. 
    Він використовується для того, щоб створити XML файл з нуля, або для того, щоб 
    модифікувати вже існуючий XML файл.
    Створення екземляру XmlWriter необхідно помістити в блок using, щоб переконатися,
    що екземпляр буде видалено правильно після його використання. Це важливо, щоб запобігти
    витокам ресурсів і переконатися, що файл XML записано правильно. Також XmlWriter 
    імплементує інтерфейс IDisposable, тож завдяки using блоку метод Dispose буде викликано 
    автоматично після виходу з блоку, навіть у випадку виклику exception.

    XmlWriter методи:
    -WriteStartDocument() - записує XML декларацію
    -WriteStartElement(string elementName) - записує стартовий елемент для корневого вузла
    -WriteElementString(string localName, string value) - записує елемент з заданим ім'ям 
    та його значення
    -WriteEndElement() - записує закриваючий елемент для відкритого вузла
    -WriteEndDocument() - записує кінець XML документу
 */

