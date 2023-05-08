using lab2.Interfaces;
using System;

namespace lab2.Commands
{
    public class GetCountOfStudentsFromGroup : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 7;

        public GetCountOfStudentsFromGroup(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            Console.Write("Введіть номер групи:\t");
            int amount = dataRepository.GetCountOfStudentsFromSelectedGroup(Console.ReadLine());
            consoleViewer.ShowStudentCountFromGroup(amount);
        }
    }
}
