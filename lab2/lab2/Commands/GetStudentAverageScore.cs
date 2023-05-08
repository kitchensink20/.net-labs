using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetStudentAverageScore : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 18;

        public GetStudentAverageScore(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            double averageScore = dataRepository.GetAverageStudentScore();
            consoleViewer.ShowStudentAverageScore(averageScore);
        }
    }
}
