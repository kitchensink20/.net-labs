using lab2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class MenuService
    {
        private XmlWriterModel xmlWriterModel;

        public MenuService(XmlWriterModel xmlWriterModel) 
        {
            this.xmlWriterModel = xmlWriterModel;
        }


        public void SwitchMenu()
        {
            Console.Write("\n" + ConsoleTexts.MenuNavigateMessage + "\t");

            int option;
            string input = Console.ReadLine();
            if(!int.TryParse(input, out option))
            {
                if(input == "exit")
                    Environment.Exit(0);
                Console.WriteLine(ConsoleTexts.MenuChoiceErrorMessage);
                return;
            }

            
        }
    }
}
