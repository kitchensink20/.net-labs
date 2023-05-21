using lab3.Enums;
using lab3.Interfaces;
using System.Collections.Generic;

namespace lab3
{
    public class TeaBeverage : IBeverage
    {
        public TeaBeverage() 
        {
            Liquids = new List<LiquidType>();
            Toppings = new List<Topping>();
        }
        public CupType CupType { get; set; }
        public MainIngridient MainIngridient { get; set; }
        public List<LiquidType> Liquids { get; set; }
        public List<Topping> Toppings { get; set; }
    }
}
