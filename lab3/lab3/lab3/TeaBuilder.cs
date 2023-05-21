using lab3.Enums;
using lab3.Interfaces;
using System;

namespace lab3
{
    public class TeaBuilder : IBeverageBuilder
    {
        private IBeverage tea;
        public void Reset()
        {
            Console.WriteLine("Starting preparing tea beverage..");
            tea = new TeaBeverage();
        }

        public void AddLiquid(LiquidType liquidType)
        {
            Console.WriteLine($"Adding {liquidType} to the tea..");
            tea.Liquids.Add(liquidType);
        }

        public void AddMainIngridient(MainIngridient mainIngridient)
        {
            Console.WriteLine($"Adding main ingridient - {mainIngridient}..");
            tea.MainIngridient = mainIngridient;
        }

        public void AddTopping(Topping topping)
        {
            Console.WriteLine($"Adding topping of {topping} to the tea..");
            tea.Toppings.Add(topping);
        }

        public void ChooseCup(CupType cupType)
        {
            
            Console.WriteLine($"Choosing cup of {cupType} size..");
            tea.CupType = cupType;
        }

        public IBeverage GetBeverage()
        {
            return tea;
        }
    }
}
