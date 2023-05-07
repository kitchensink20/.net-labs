using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetSupervisorsWOFirst3 : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public GetSupervisorsWOFirst3(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            var supervisorsList = dataRepository.SkipFirstThreeSupervisors();
            consoleViewer.ShowSupervisorsList(supervisorsList);
        }
    }
}
