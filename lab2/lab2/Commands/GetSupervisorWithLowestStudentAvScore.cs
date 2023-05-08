using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetSupervisorWithLowestStudentAvScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 15;

        public GetSupervisorWithLowestStudentAvScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var supervisor = dataRepository.GetSupervisorWithLowestStudentAvScore();
            consoleViewer.ShowSupervisorData(supervisor);
        }
    }
}
