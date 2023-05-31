using lab5.Interfaces;

namespace lab5.Commands
{
    public class MakeIntrabankPayment : ICommand
    {
        private PaymentChainsCreator paymentChainsCreator;

        public MakeIntrabankPayment(PaymentChainsCreator paymentChainsCreator)
        {
            this.paymentChainsCreator = paymentChainsCreator;
        }

        public void Execute()
        {
            paymentChainsCreator.MakeIntrabankPayment();
        }
    }
}
