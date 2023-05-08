using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetStudentsWithHighestScroreInGroup : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 14;

        public GetStudentsWithHighestScroreInGroup(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var studentsList = dataRepository.GetStudentsWithHighestScroreInGroup();
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
