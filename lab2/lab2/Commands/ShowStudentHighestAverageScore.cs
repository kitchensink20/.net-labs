﻿using lab2.Interfaces;
using lab2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Commands
{
    public class ShowStudentHighestAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public ShowStudentHighestAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            var highestScore = dataRepository.GetStudentHighestAverageScore();
            consoleViewer.ShowStudentHighestAverageScore(highestScore);
        }
        
    }
}
