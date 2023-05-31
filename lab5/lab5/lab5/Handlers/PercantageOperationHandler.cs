using lab5.Enums;
using System;

namespace lab5
{
    internal class PercantageOperationHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            Console.WriteLine($"Perfoming operation of taking off percantage for {paymentType} payment..");

            return true;
        }
    }
}
