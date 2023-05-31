using lab5.Enums;

namespace lab5.Interfaces
{
    public interface IHandler
    {
        void SetNext(IHandler next);
        void Handle(PaymentType paymentType);
    }
}
