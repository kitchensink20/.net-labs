using lab2.Interfaces;

namespace lab2.Commands
{
    public class ShowCustomStudentsXmlFile : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        public ShowCustomStudentsXmlFile(IDataRepository dataRepository, IConsoleViewer consoleViewer)
        {
            this.dataRepository = dataRepository;
            this.consoleViewer = consoleViewer;
        }
        public void Execute() 
        {
            var studetnsXElements = dataRepository.GetAllCustStudentsXElements();
            consoleViewer.ShowCustomXmlFileContent(studetnsXElements);
        }
    }
}
