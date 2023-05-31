using lab5.Enums;
using lab5.Handlers;
using lab5.Interfaces;

namespace lab5.Commands
{
    public class MakeSpecialPayment : ICommand
    {
        private PaymentChainsCreator paymentChainsCreator;

        public MakeSpecialPayment(PaymentChainsCreator paymentChainsCreator)
        {
            this.paymentChainsCreator = paymentChainsCreator;
        }

        public void Execute()
        {
            paymentChainsCreator.MakeSpecialPayment();
        }
    }
}
