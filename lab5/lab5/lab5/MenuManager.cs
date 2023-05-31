using lab5.Commands;
using System;

namespace lab5
{
    public class MenuManager
    {
        private PaymentChainsCreator paymentChainsCreator;
        private Invoker regularPayment;
        private Invoker specialPayment;
        private Invoker statePayment;
        private Invoker intrabankPayment;

        public MenuManager(PaymentChainsCreator paymentChainsCreator, Invoker regularPayment, Invoker specialPayment, Invoker statePayment, Invoker intrabankPayment)
        {
            this.paymentChainsCreator = paymentChainsCreator;
            this.regularPayment = regularPayment;
            this.regularPayment.setCommand(new MakeRegularPayment(paymentChainsCreator));
            this.specialPayment = specialPayment;
            this.specialPayment.setCommand(new MakeSpecialPayment(paymentChainsCreator));    
            this.statePayment = statePayment;
            this.statePayment.setCommand(new MakeStatePayment(paymentChainsCreator));
            this.intrabankPayment = intrabankPayment;
            this.intrabankPayment.setCommand(new MakeIntrabankPayment(paymentChainsCreator));
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1 - Make regular payment\n" +
                "2 - Make special payment\n" +
                "3 - Make state payment\n" +
                "4 - Make intrabank payment");
        }

        public void ExecuteOptions()
        {
            while (true)
            {
                Console.Write("\n Choose option:\t");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        regularPayment.ExecuteCommand();
                        break;
                    case "2":
                        specialPayment.ExecuteCommand();
                        break;
                    case "3":
                        statePayment.ExecuteCommand();
                        break;
                    case "4":
                        intrabankPayment.ExecuteCommand();
                        break;
                    default:
                        Console.WriteLine("Unexcisting option input. Try again.");
                        break;
                }
            }
        }
    }
}
