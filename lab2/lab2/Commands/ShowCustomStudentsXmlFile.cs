using lab2.Interfaces;

namespace lab2.Commands
{
    public class ShowCustomStudentsXmlFile : ICommand
    {
        private readonly IDataRepository dataRepository;
        private readonly IConsoleViewer consoleViewer;
        private const int number = 4;

        public ShowCustomStudentsXmlFile(IDataRepository dataRepository, IConsoleViewer consoleViewer)
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
            var studetnsXElements = dataRepository.GetAllCustStudentsXElements();
            consoleViewer.ShowCustomXmlFileContent(studetnsXElements);
        }
    }
}
