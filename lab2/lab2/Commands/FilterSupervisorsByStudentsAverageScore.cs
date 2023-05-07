using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class FilterSupervisorsByStudentsAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public FilterSupervisorsByStudentsAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            Console.Write("Введіть значення мінімального середнього балу:\t");
            float minScore;
            while (!float.TryParse(Console.ReadLine(), out minScore) || minScore < 60 || minScore > 100)
            {
                Console.Write(ConsoleTexts.DoubleParseErrorMessage + "\t");
            }
            var supervisorsList = dataRepository.FilterSupervisorsByStudentsAverageScore(minScore);
            consoleViewer.ShowSupervisorsList(supervisorsList);
        }
    }
}
