using lab2.Interfaces;

namespace lab2.Commands
{
    public class SortSupervisorsByFullName : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public SortSupervisorsByFullName(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            var supervisorsList = dataRepository.SortSupervisorsByFullName();
            consoleViewer.ShowSupervisorsList(supervisorsList);
        }
    }
}
