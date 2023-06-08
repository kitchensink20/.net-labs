using System;

namespace lab5
{
    public class MenuManager
    {
        private PaymentChainsCreator paymentChainsCreator;

        public MenuManager(PaymentChainsCreator paymentChainsCreator)
        {
            this.paymentChainsCreator = paymentChainsCreator;
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
                Console.Write("\nChoose option:\t");
               
                switch (Console.ReadLine())
                {
                    case "1":

                        paymentChainsCreator.MakeRegularPayment();
                        break;
                    case "2":
                        paymentChainsCreator.MakeSpecialPayment();
                        break;
                    case "3":
                        paymentChainsCreator.MakeStatePayment();
                        break;
                    case "4":
                        paymentChainsCreator.MakeIntrabankPayment();
                        break;
                    default:
                        Console.WriteLine("Unexcisting option input. Try again.");
                        break;
                }
            }
        }
    }
}
