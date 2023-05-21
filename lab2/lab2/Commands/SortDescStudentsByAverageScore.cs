using lab2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Commands
{
    public class SortDescStudentsByAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 10;


        public SortDescStudentsByAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var studentsList = dataRepository.DescSortStudentsByAverageScore();
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
