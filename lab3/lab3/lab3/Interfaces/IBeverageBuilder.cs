using lab3.Enums;
using lab3.Interfaces;

namespace lab3
{
    public interface IBeverageBuilder
    {
        void Reset();
        void ChooseCup(CupType cupType);
        void AddLiquid(LiquidType liquidType);
        void AddMainIngridient(MainIngridient ingridientType);
        void AddTopping(Topping topping);
        IBeverage GetBeverage();
    }
}
