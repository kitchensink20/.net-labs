using lab2.Commands;
using lab2.Interfaces;
using lab2.Properties;
using System;
using System.Text;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string studentsXmlFile = XmlPathGenerator.GetPathToGraduateStudentsXmlFile(),
                supervisorsXmlFile = XmlPathGenerator.GetPathToGraduateSupervisorsXmlFile(),
                customStudentsXmlFile = XmlPathGenerator.GetPathToCustomGraduateStudentsXmlFile(),
                customSupervisorsXmlFile = XmlPathGenerator.GetPathToCustomGraduateSupervisorsXmlFile(),
                studentXsdFile = XmlPathGenerator.GetPathToGraduateStudentsXsdFile(),
                supervisorXsdFile = XmlPathGenerator.GetPathToGraduateSupervisorsXsdFile();

            XmlValidatorModel.AddNewXmlSchema(supervisorXsdFile);
            XmlValidatorModel.AddNewXmlSchema(studentXsdFile);
            XmlValidatorModel.Validate(supervisorsXmlFile);
            XmlValidatorModel.Validate(studentsXmlFile);

            Console.WriteLine("\n" + ConsoleTexts.Menu);

            XmlReaderModel xmlReader = new XmlReaderModel();
            XmlSerializerModel xmlSerializer = new XmlSerializerModel();
            XmlWriterModel xmlWriter = new XmlWriterModel();
            IConsoleViewer consoleViewer = new ConsoleViewer();
            IDataRepository dataRepository = new DataRepository(studentsXmlFile, supervisorsXmlFile,
                                                                customStudentsXmlFile, customSupervisorsXmlFile);

            CommandsManager commandsManager = new CommandsManager();
            commandsManager.AddCommand(new ChangeStudentAverageScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new FilterSupervisorsByStudentsAverageScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetCountOfStudentsFromGroup(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetStudentAverageScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetStudentDataByFullName(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetStudentHighestAverageScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetStudentsBornInSpecifiedYears(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetStudentsSupervisedBySpecificSupervisor(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetStudentsWithHighestScroreInGroup(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetSupervisorsWOFirst3(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetSupervisorWithLowestStudentAvScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new GetTop3Students(dataRepository, consoleViewer));
            commandsManager.AddCommand(new SortDescStudentsByAverageScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new SortSupervisorsByFullName(dataRepository, consoleViewer));
            commandsManager.AddCommand(new TakeWhileGreaterAverageScore(dataRepository, consoleViewer));
            commandsManager.AddCommand(new ShowCustomStudentsXmlFile(dataRepository, consoleViewer));
            commandsManager.AddCommand(new ShowCustomSupervisorsXmlFile(dataRepository, consoleViewer));
            commandsManager.AddCommand(new CreateCustomStudentsXmlFile(xmlWriter, 
                                        XmlPathGenerator.GetPathToCustomGraduateStudentsXmlFile()));
            commandsManager.AddCommand(new CreateCustomSupervisorsXmlFile(xmlWriter, customSupervisorsXmlFile));
            commandsManager.AddCommand(new ShowStudentsDataFromXmlWithXmlReader(xmlReader, consoleViewer));
            commandsManager.AddCommand(new ShowSupervisorsDataFromXmlWithXmlSerializer(xmlSerializer, consoleViewer));
            commandsManager.OrderCommands();

            string input;
            while(true)
            {
                Console.Write("\n" + ConsoleTexts.EnterCommandNumberMessage + "\t");
                input = Console.ReadLine();
                int commandNum;
                if (!Int32.TryParse(input, out commandNum)
                    || commandNum < 0 || commandNum > commandsManager.GetCommandsNum())
                {
                    if (input == "exit")    break;
                    Console.Write(ConsoleTexts.CommandInputErrorMessage + "\t");
                }
                else
                    commandsManager.ExecuteCommand(commandNum);
            }

            Console.WriteLine("\n" + ConsoleTexts.FinalMessage);
            Console.ReadKey();
        }
    }
}
