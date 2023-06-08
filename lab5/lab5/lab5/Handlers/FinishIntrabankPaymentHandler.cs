using lab5.Enums;
using System;

namespace lab5.Handlers
{
    public class FinishIntrabankPaymentHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            bool isSuccessful = true;
            Console.WriteLine($"Finishing {paymentType} payment!\n" +
                $"Intrabank payment refers to a financial transaction that occurs between accounts held within the same bank. ");

            return isSuccessful;
        }
    }
}
