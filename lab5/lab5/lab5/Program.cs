using System;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentChainsCreator paymentChainsCreator = new PaymentChainsCreator();
            Invoker regularPayment = new Invoker(),
                specialPayment = new Invoker(),
                statePayment = new Invoker(),
                intrabankPayment = new Invoker();
            MenuManager menuManager = new MenuManager(paymentChainsCreator, regularPayment, 
                specialPayment, statePayment, intrabankPayment);

            menuManager.DisplayMenu();
            menuManager.ExecuteOptions();

            Console.ReadLine();
        }
    }
}
