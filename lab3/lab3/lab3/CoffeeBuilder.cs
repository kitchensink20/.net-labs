using lab3.Enums;
using lab3.Interfaces;
using System;

namespace lab3
{
    public class CoffeeBuilder : IBeverageBuilder
    {
        private IBeverage coffee;
        public void Reset()
        {
            Console.WriteLine("Starting preparing coffee beverage..");
            coffee = new CoffeeBeverage();
        }

        public void AddLiquid(LiquidType liquidType)
        {
            Console.WriteLine($"Adding {liquidType} to the coffee..");
            coffee.Liquids.Add(liquidType);
        }

        public void AddMainIngridient(MainIngridient mainIngridient)
        {
            Console.WriteLine($"Adding main ingridient - {mainIngridient}..");
            coffee.MainIngridient = mainIngridient;
        }

        public void AddTopping(Topping topping)
        {
            Console.WriteLine($"Adding topping of {topping} to the coffee..");
            coffee.Toppings.Add(topping);
        }

        public void ChooseCup(CupType cupType)
        {

            Console.WriteLine($"Choosing cup of {cupType} size..");
            coffee.CupType = cupType;
        }

        public IBeverage GetBeverage()
        {
            return coffee;
        }
    }
}
