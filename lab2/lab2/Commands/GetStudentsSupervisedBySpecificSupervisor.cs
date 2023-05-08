using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class GetStudentsSupervisedBySpecificSupervisor : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 16;

        public GetStudentsSupervisedBySpecificSupervisor(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            Console.Write("Введіть айді наукового керівника:\t");
            int supervisorId;
            while (!Int32.TryParse(Console.ReadLine(), out supervisorId) || supervisorId <= 0)
            {
                Console.Write(ConsoleTexts.IntParseErrorMessage + "\t");
            }
            var studentsList = dataRepository.GetStudentsSupervisedBySpecificSupervisor(supervisorId);
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
