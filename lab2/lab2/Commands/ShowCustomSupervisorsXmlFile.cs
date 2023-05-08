using lab2.Interfaces;

namespace lab2.Commands
{
    public class ShowCustomSupervisorsXmlFile : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 3;

        public ShowCustomSupervisorsXmlFile(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var supervisorsXElements = dataRepository.GetAllCustSupervisorsXElements();
            consoleViewer.ShowCustomXmlFileContent(supervisorsXElements);
        }
    }
}
