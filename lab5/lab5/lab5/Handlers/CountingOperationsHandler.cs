using lab5.Enums;
using System;

namespace lab5.Handlers
{
    public class CountingOperationsHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            bool isSuccessful = true;
            Console.WriteLine($"Perfoming counting operations for {paymentType} payment..");

            return isSuccessful;
        }
    }
}
