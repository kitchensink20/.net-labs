using lab5.Enums;
using System;

namespace lab5.Handlers
{
    public class FinishSpecialPaymentHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            bool isSuccessful = true;
            Console.WriteLine($"Finishing {paymentType} payment!\n" +
                $"Special payment may be made in special circumstances or events.");

            return isSuccessful;
        }
    }
}
