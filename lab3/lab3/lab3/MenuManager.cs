using lab3.Enums;
using lab3.Properties;
using System;

namespace lab3
{
    public static class MenuManager
    {
        public static void DisplayMenu()
        {
            Console.WriteLine(ConsoleTexts.Menu);
        }

        public static void ProcessOptions(Barista barista, IBeverageBuilder coffeeBuilder, IBeverageBuilder teaBuilder) 
        {
            while (true)
            {
                Console.Write('\n' + ConsoleTexts.EnterNumberMessage + '\t');
                int option;
                if(!int.TryParse(Console.ReadLine(), out option) 
                    || option <= 0 || option > 8) {
                    Console.WriteLine(ConsoleTexts.ErrorInputMessage);
                    continue;
                }

                CupType cupType = MenuManager.ChooseCup();

                switch (option)
                {
                    case 1:
                        barista.CreateEnglishTea(teaBuilder, cupType);
                        break;
                    case 2:
                        barista.CreateSeaBuckthornTeaWithHoney(teaBuilder, cupType);
                        break;
                    case 3:
                        barista.CreateRedTeaWithCarnationAndLemon(teaBuilder, cupType);
                        break;
                    case 4:
                        barista.CreateCinnamonWhippedCreamCoffee(coffeeBuilder, cupType);
                        break;
                    case 5:
                        barista.CreateLatte(coffeeBuilder, cupType);
                        break;
                    case 6:
                        barista.CreateCapuccino(coffeeBuilder, cupType);
                        break;
                    case 7:
                        barista.CreateCoffeeWithMarshmallowAndCholate(coffeeBuilder, cupType);
                        break;
                    case 8:
                        barista.CreateCoconutCoffeeWithCaramel(coffeeBuilder, cupType);
                        break;
                    default:
                        Console.WriteLine(ConsoleTexts.ErrorInputMessage);
                        break;
                }
            }
        }
    
        private static CupType ChooseCup()
        {
            while (true)
            {
                Console.Write(ConsoleTexts.ChooseCupMessage + '\t');
                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine(ConsoleTexts.ErrorInputMessage);
                    continue;
                }
                switch(option)
                {
                    case 1:
                        return CupType.Small;
                    case 2:
                        return CupType.Medium;
                    case 3:
                        return CupType.Big;
                    default:
                        Console.WriteLine(ConsoleTexts.ErrorInputMessage);
                        break;
                }
            }
        }
    }
}
