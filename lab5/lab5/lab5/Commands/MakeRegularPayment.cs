using lab5.Interfaces;

namespace lab5.Commands
{
    public class MakeRegularPayment : ICommand
    {
        private PaymentChainsCreator paymentChainsCreator;

        public MakeRegularPayment(PaymentChainsCreator paymentChainsCreator)
        {
            this.paymentChainsCreator = paymentChainsCreator;
        }

        public void Execute()
        {
            paymentChainsCreator.MakeRegularPayment();
        }
    }
}
