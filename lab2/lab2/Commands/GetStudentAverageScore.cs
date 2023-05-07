using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetStudentAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public GetStudentAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            double averageScore = dataRepository.GetAverageStudentScore();
            consoleViewer.ShowStudentAverageScore(averageScore);
        }
    }
}
