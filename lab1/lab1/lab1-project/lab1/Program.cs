using lab1.Properties;
using System;
using System.Text;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            IDataContext dataContext = new DataContext(); 
            IDataInitializer dataInitializer = new DataInitializer(dataContext);
            dataInitializer.InitializeWithData();
            IDataService dataService = new DataService(dataContext); 
            IConsoleViewer consoleViewer = new ConsoleViewer();
            ISwitcherRealizator switcherRealizator = new SwitcherRealizator(consoleViewer, dataService);

            Console.WriteLine(ConsoleTexts.MenuHeader);
            Console.WriteLine(ConsoleTexts.Menu + "\n");

            switcherRealizator.Switch();

            Console.WriteLine("\n" + ConsoleTexts.FinishMessage);
            Console.ReadKey();
        }
    }
}
