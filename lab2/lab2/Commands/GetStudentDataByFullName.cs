using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class GetStudentDataByFullName : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 11;

        public GetStudentDataByFullName(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }

        public int GetNumber()
        {
            return number;
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
