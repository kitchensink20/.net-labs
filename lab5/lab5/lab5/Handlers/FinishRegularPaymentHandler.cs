using lab5.Enums;
using System;

namespace lab5.Handlers
{
    public class FinishRegularPaymentHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            bool isSuccessful = true;
            Console.WriteLine($"Finishing {paymentType} payment!\n" +
                $"Regular payment refers to a recurring financial transaction that takes place at fixed intervals or on a predetermined schedule.");

            return isSuccessful;
        }
    }
}
