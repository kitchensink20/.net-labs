using lab5.Interfaces;

namespace lab5.Commands
{
    public class MakeStatePayment : ICommand
    {
        private PaymentChainsCreator paymentChainsCreator;

        public MakeStatePayment(PaymentChainsCreator paymentChainsCreator)
        {
            this.paymentChainsCreator = paymentChainsCreator;
        }

        public void Execute()
        {
            paymentChainsCreator.MakeStatePayment();
        }
    }
}
