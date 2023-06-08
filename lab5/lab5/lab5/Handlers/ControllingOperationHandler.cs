using lab5.Enums;
using System;

namespace lab5
{
    public class ControllingOperationHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            bool isSuccessful = true;
            Console.WriteLine($"Perfoming controlling operations for {paymentType} payment..");

            return isSuccessful;
        }
    }
}
