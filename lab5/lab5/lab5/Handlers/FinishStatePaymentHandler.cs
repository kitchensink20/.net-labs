using lab5.Enums;
using System;

namespace lab5.Handlers
{
    public class FinishStatePaymentHandler : BaseHandler
    {
        public override bool PerfomOperation(PaymentType paymentType)
        {
            Console.WriteLine($"Finishing {paymentType} payment!\n" +
                $"State payment refers to a payment made by a state government or a payment related to the affairs of a specific state");

            return true;
        }
    }
}
