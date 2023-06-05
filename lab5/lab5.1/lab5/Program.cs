using System;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentChainsCreator paymentChainsCreator = new PaymentChainsCreator();
            MenuManager menuManager = new MenuManager(paymentChainsCreator);

            menuManager.DisplayMenu();
            menuManager.ExecuteOptions();

            Console.ReadLine();
        }
    }
}
