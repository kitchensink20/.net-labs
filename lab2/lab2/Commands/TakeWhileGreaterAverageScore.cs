using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class TakeWhileGreaterAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 12;

        public TakeWhileGreaterAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            Console.Write("Введіть значення середнього балу:\t");
            double averageScore;
            while (!double.TryParse(Console.ReadLine(), out averageScore) || averageScore < 60 || averageScore > 100)
            {
                Console.Write(ConsoleTexts.DoubleParseErrorMessage + "\t");
            }
            var studentsList = dataRepository.TakeWhileGreaterAverageScore(averageScore);
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
