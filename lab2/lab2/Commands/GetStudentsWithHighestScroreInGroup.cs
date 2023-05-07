using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetStudentsWithHighestScroreInGroup : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public GetStudentsWithHighestScroreInGroup(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            var studentsList = dataRepository.GetStudentsWithHighestScroreInGroup();
            consoleViewer.ShowStudentsList(studentsList);
        }
    }
}
