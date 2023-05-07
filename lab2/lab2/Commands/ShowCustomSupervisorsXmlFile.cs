using lab2.Interfaces;

namespace lab2.Commands
{
    public class ShowCustomSupervisorsXmlFile : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public ShowCustomSupervisorsXmlFile(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute()
        {
            var supervisorsXElements = dataRepository.GetAllGraduateSupervisors();
            consoleViewer.ShowCustomXmlFileContent(supervisorsXElements);
        }
    }
}
