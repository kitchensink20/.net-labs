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
                if(!int.TryParse(Console.ReadLine(), out option)) {
                    Console.WriteLine(ConsoleTexts.ErrorInputMessage);
                    continue;
                }
                switch (option)
                {
                    case 1:
                        barista.CreateEnglishTea(teaBuilder);
                        break;
                    case 2:
                        barista.CreateSeaBuckthornTeaWithHoney(teaBuilder);
                        break;
                    case 3:
                        barista.CreateRedTeaWithCarnationAndLemon(teaBuilder);
                        break;
                    case 4:
                        barista.CreateExpresso(coffeeBuilder);
                        break;
                    case 5:
                        barista.CreateLatte(coffeeBuilder);
                        break;
                    case 6:
                        barista.CreateCapuccino(coffeeBuilder);
                        break;
                    case 7:
                        barista.CreateCoffeeWithMarshmallowAndCholate(coffeeBuilder);
                        break;
                    case 8:
                        barista.CreateCoconutCoffeeWithCaramel(coffeeBuilder);
                        break;
                    default:
                        Console.WriteLine(ConsoleTexts.ErrorInputMessage);
                        break;
                }
            }
        }
    }
}
