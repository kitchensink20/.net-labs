using System;
using System.Reflection;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBeverageBuilder teaBuilder = new TeaBuilder();
            IBeverageBuilder coffeeBuilder = new CoffeeBuilder();   
            Barista barista = new Barista();

            MenuManager.DisplayMenu();
            MenuManager.ProcessOptions(barista, coffeeBuilder, teaBuilder);
        }
    }
}
