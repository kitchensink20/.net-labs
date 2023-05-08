﻿using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetTop3Students : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 13;

        public GetTop3Students(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var studentsList = dataRepository.Get3TopStudents();
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
