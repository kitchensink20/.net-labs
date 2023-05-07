using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class FindStudentByFullName : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public FindStudentByFullName(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            Console.Write("Введіть ПІБ студента, про якого бажаєте вивести інформацію:\t");
            string fullName = Console.ReadLine();
            while (dataRepository.GetStudentDataByFullName(fullName) == null)
            {
                Console.Write(ConsoleTexts.StudentSearchByFullNameErrorMessage + "\t");
                fullName = Console.ReadLine();
            }
            var student = dataRepository.GetStudentDataByFullName(fullName);
            consoleViewer.ShowStudentData(student);
        }
    }
}
