using lab2.Interfaces;
using lab2.Properties;
using System;

namespace lab2.Commands
{
    public class GetStudentsBornInSpecifiedYears : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public GetStudentsBornInSpecifiedYears(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            Console.Write("Введіть початковий рік:\t");
            int startYear;
            while (!Int32.TryParse(Console.ReadLine(), out startYear) || startYear < 1950 || startYear > 2010)
            {
                Console.Write(ConsoleTexts.BirthYearInputErrorMessage + "\t");
            }
            Console.Write("Введіть кінцевий рік:\t");
            int endYear;
            while (!Int32.TryParse(Console.ReadLine(), out endYear) || endYear < 1950 || endYear > 2010)
            {
                Console.Write(ConsoleTexts.BirthYearInputErrorMessage + "\t");
            }

            var studentsList = dataRepository.GetStudentsBornInSpecifiedYear(startYear, endYear);
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
