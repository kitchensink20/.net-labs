using lab5.Enums;
using lab5.Interfaces;
using System;

namespace lab5
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler nextHandler;

        public void SetNext(IHandler handler)
        {
            this.nextHandler = handler;
        }

        public void Handle(PaymentType paymentType)
        {
            bool toContinue = this.PerfomOperation(paymentType);
            if(!toContinue)
            {
                Console.WriteLine("Error occured. Payment process was stopped.");
            } else if (this.nextHandler != null)
            {
                this.nextHandler.Handle(paymentType);
            }
        }

        public abstract bool PerfomOperation(PaymentType paymentType);
    }
}
