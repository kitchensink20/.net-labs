using lab5.Enums;
using System;

namespace lab5
{
    public class FixingOperationHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            bool isSuccessful = true;
            Console.WriteLine($"Performing fixing operations for {paymentType} payment..");

            return isSuccessful;
        }
    }
}
