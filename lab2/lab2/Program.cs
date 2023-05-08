using lab2.Commands;
using lab2.Interfaces;
using lab2.Properties;
using System;
using System.Text;
using static lab2.XmlSerializerModel;

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

            Console.WriteLine("\n" + ConsoleTexts.Menu);

            XmlReaderModel xmlReader = new XmlReaderModel();
            XmlSerializerModel xmlSerializer = new XmlSerializerModel();
            XmlWriterModel xmlWriter = new XmlWriterModel();
            IConsoleViewer consoleViewer = new ConsoleViewer();
            IDataRepository dataRepository = new DataRepository(XmlPathGenerator.GetPathToGraduateStudentsXmlFile(),
                                                                XmlPathGenerator.GetPathToGraduateSupervisorsXmlFile(),
                                                                XmlPathGenerator.GetPathToCustomGraduateStudentsXmlFile(),
                                                                XmlPathGenerator.GetPathToCustomGraduateSupervisorsXmlFile());

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
            commandsManager.AddCommand(new CreateCustomSupervisorsXmlFile(xmlWriter,
                                        XmlPathGenerator.GetPathToCustomGraduateSupervisorsXmlFile()));
            commandsManager.AddCommand(new ShowStudentsDataFromXmlWithXmlReader(xmlReader, consoleViewer));
            commandsManager.AddCommand(new ShowSupervisorsDataFromXmlWithXmlSerializer(xmlSerializer, consoleViewer));
            commandsManager.OrderCommands();

            

            string input = default;
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
