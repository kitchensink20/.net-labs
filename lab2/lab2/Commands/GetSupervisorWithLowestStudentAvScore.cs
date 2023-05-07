using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetSupervisorWithLowestStudentAvScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public GetSupervisorWithLowestStudentAvScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            var supervisor = dataRepository.GetSupervisorWithLowestStudentAvScore();
            consoleViewer.ShowSupervisorData(supervisor);
        }
    }
}
