using lab2.Interfaces;

namespace lab2.Commands
{
    public class GetSupervisorsWOFirst3 : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 17;

        public GetSupervisorsWOFirst3(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var supervisorsList = dataRepository.SkipFirstThreeSupervisors();
            consoleViewer.ShowSupervisorsList(supervisorsList);
        }
    }
}
