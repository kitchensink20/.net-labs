using lab2.Interfaces;
using lab2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Commands
{
    public class GetStudentHighestAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 5;

        public GetStudentHighestAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var highestScore = dataRepository.GetStudentHighestAverageScore();
            consoleViewer.ShowStudentHighestAverageScore(highestScore);
        }
    }
}
