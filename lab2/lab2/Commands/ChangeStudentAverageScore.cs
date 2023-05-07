using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class ChangeStudentAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public ChangeStudentAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            Console.Write("Введіть ПІБ студента, якому необхідно змінити значення середнього балу:\t");
            string fullName = Console.ReadLine();
            while(dataRepository.GetStudentDataByFullName(fullName) == null)
            {
                Console.Write(ConsoleTexts.StudentSearchByFullNameErrorMessage + "\t");
                fullName = Console.ReadLine();
            }
            Console.Write("Введіть середній бал студента:\t");
            double averageScore;
            while (!double.TryParse(Console.ReadLine(), out averageScore) || averageScore < 60 || averageScore > 100)
            {
                Console.Write(ConsoleTexts.DoubleParseErrorMessage + "\t");
            }
            var changedStudent = dataRepository.ChangeStudentAverageScore(fullName, averageScore);
            consoleViewer.ShowStudentData(changedStudent);
        }
    }
}
