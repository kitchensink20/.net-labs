using System;
using System.Text;

namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            IDictionary proxyDictionary = new ProxyDictionary("Dictionary.json");
            MenuManager menuManager = new MenuManager(proxyDictionary);

            menuManager.DisplayMenu();
            menuManager.ProcessOptions();

            Console.ReadLine();
        }
    }
}
