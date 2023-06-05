using lab5.Enums;
using lab5.Handlers;

namespace lab5
{
    public class PaymentChainsCreator
    {
        public void MakeRegularPayment()
        {
            PaymentType paymentType = PaymentType.Regular;

            FixingOperationHandler fixingOperation = new FixingOperationHandler(); 
            ControllingOperationHandler controllingOperation = new ControllingOperationHandler();
            PercantageOperationHandler percantageOperation= new PercantageOperationHandler();
            CountingOperationsHandler countingOperation = new CountingOperationsHandler();
            FinishRegularPaymentHandler finishRegularPayment = new FinishRegularPaymentHandler();

            fixingOperation.SetNext(controllingOperation);
            controllingOperation.SetNext(percantageOperation);
            percantageOperation.SetNext(countingOperation);
            countingOperation.SetNext(finishRegularPayment);

            fixingOperation.Handle(paymentType);
        }

        public void MakeSpecialPayment()
        {
            PaymentType paymentType = PaymentType.Special;

            FixingOperationHandler fixingOperation = new FixingOperationHandler();
            ControllingOperationHandler controllingOperation = new ControllingOperationHandler();
            PercantageOperationHandler percantageOperation = new PercantageOperationHandler();
            CountingOperationsHandler countingOperation = new CountingOperationsHandler();
            FinishSpecialPaymentHandler finishSpecialPayment = new FinishSpecialPaymentHandler();

            fixingOperation.SetNext(controllingOperation);
            controllingOperation.SetNext(percantageOperation);
            percantageOperation.SetNext(countingOperation);
            countingOperation.SetNext(finishSpecialPayment);

            fixingOperation.Handle(paymentType);
        }

        public void MakeStatePayment()
        {
            PaymentType paymentType = PaymentType.State;

            FixingOperationHandler fixingOperation = new FixingOperationHandler();
            ControllingOperationHandler controllingOperation = new ControllingOperationHandler();
            PercantageOperationHandler percantageOperation = new PercantageOperationHandler();
            CountingOperationsHandler countingOperation = new CountingOperationsHandler();
            FinishStatePaymentHandler finishStatePayment = new FinishStatePaymentHandler();

            fixingOperation.SetNext(controllingOperation);
            controllingOperation.SetNext(percantageOperation);
            percantageOperation.SetNext(countingOperation);
            countingOperation.SetNext(finishStatePayment);

            fixingOperation.Handle(paymentType);
        }

        public void MakeIntrabankPayment()
        {
            PaymentType paymentType = PaymentType.Intrabank;

            FixingOperationHandler fixingOperation = new FixingOperationHandler();
            ControllingOperationHandler controllingOperation = new ControllingOperationHandler();
            PercantageOperationHandler percantageOperation = new PercantageOperationHandler();
            CountingOperationsHandler countingOperation = new CountingOperationsHandler();
            FinishIntrabankPaymentHandler finishIntrabankPayment = new FinishIntrabankPaymentHandler();

            fixingOperation.SetNext(controllingOperation);
            controllingOperation.SetNext(percantageOperation);
            percantageOperation.SetNext(countingOperation);
            countingOperation.SetNext(finishIntrabankPayment);

            fixingOperation.Handle(paymentType);
        }
    }
}
