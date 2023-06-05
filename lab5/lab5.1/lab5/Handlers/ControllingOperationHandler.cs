using lab5.Enums;
using System;

namespace lab5
{
    public class ControllingOperationHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            Console.WriteLine($"Perfoming controlling operations for {paymentType} payment..");

            return true;
        }
    }
}
