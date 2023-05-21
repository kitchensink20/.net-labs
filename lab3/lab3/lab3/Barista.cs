using lab3.Enums;
using lab3.Interfaces;
using System;

namespace lab3
{
    public class Barista
    {
        public IBeverage CreateEnglishTea(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Small);
            beverageBuilder.AddMainIngridient(MainIngridient.Green_Tea);
            beverageBuilder.AddLiquid(LiquidType.Water);
            beverageBuilder.AddLiquid(LiquidType.Milk);
            TeaBeverage tea = (TeaBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("English tea is ready!");
            return tea;
        }
        public IBeverage CreateSeaBuckthornTeaWithHoney(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Small);
            beverageBuilder.AddMainIngridient(MainIngridient.Black_Tea);
            beverageBuilder.AddTopping(Topping.Honey);
            beverageBuilder.AddTopping(Topping.Sea_Buckthorn);
            beverageBuilder.AddLiquid(LiquidType.Water);
            TeaBeverage tea = (TeaBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Sea buckthorn tea with honey is ready!");
            return tea;
        }
        public IBeverage CreateRedTeaWithCarnationAndLemon(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Medium);
            beverageBuilder.AddMainIngridient(MainIngridient.Red_Tea);
            beverageBuilder.AddTopping(Topping.Lemon);
            beverageBuilder.AddTopping(Topping.Carnation);
            beverageBuilder.AddLiquid(LiquidType.Water);
            TeaBeverage tea = (TeaBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Red tea with carnation and lemon is ready!");
            return tea;
        }
        public IBeverage CreateExpresso(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Small);
            beverageBuilder.AddMainIngridient(MainIngridient.Robusta_Coffee);
            beverageBuilder.AddLiquid(LiquidType.Water);
            CoffeeBeverage coffee = (CoffeeBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Expresso is ready!");
            return coffee;
        }
        public IBeverage CreateLatte(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Medium);
            beverageBuilder.AddMainIngridient(MainIngridient.Arabica_Coffee);
            beverageBuilder.AddLiquid(LiquidType.Water);
            beverageBuilder.AddLiquid(LiquidType.Milk);
            CoffeeBeverage coffee = (CoffeeBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Latte is ready!");
            return coffee;
        }
        public IBeverage CreateCapuccino(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Medium);
            beverageBuilder.AddMainIngridient(MainIngridient.Arabica_Coffee);
            beverageBuilder.AddLiquid(LiquidType.Water);
            beverageBuilder.AddLiquid(LiquidType.Milk);
            beverageBuilder.AddTopping(Topping.Cinnamon);
            beverageBuilder.AddTopping(Topping.Chocolate_Shavings);
            CoffeeBeverage coffee = (CoffeeBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Capuccino is ready!");
            return coffee;
        }
        public IBeverage CreateCoffeeWithMarshmallowAndCholate(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Medium);
            beverageBuilder.AddMainIngridient(MainIngridient.Arabica_Coffee);
            beverageBuilder.AddLiquid(LiquidType.Water);
            beverageBuilder.AddLiquid(LiquidType.Milk);
            beverageBuilder.AddTopping(Topping.Marchmallows);
            beverageBuilder.AddTopping(Topping.Chocolate_Shavings);
            CoffeeBeverage coffee = (CoffeeBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Coffe woth marshmallows and chocolate shavings is ready!");
            return coffee;
        }
        public IBeverage CreateCoconutCoffeeWithCaramel(IBeverageBuilder beverageBuilder)
        {
            beverageBuilder.Reset();
            beverageBuilder.ChooseCup(CupType.Medium);
            beverageBuilder.AddMainIngridient(MainIngridient.Colombian_Coffee);
            beverageBuilder.AddLiquid(LiquidType.Water);
            beverageBuilder.AddTopping(Topping.Coconut_Flakes);
            beverageBuilder.AddTopping(Topping.Caramel_Sauce);
            CoffeeBeverage coffee = (CoffeeBeverage)beverageBuilder.GetBeverage();
            Console.WriteLine("Coconut coffee with caramel is ready!");
            return coffee;
        }
    }
}
