using lab2.Interfaces;

namespace lab2.Commands
{
    public class SortSupervisorsByFullName : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 8;

        public SortSupervisorsByFullName(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var supervisorsList = dataRepository.SortSupervisorsByFullName();
            consoleViewer.ShowSupervisorsList(supervisorsList);
        }
    }
}
