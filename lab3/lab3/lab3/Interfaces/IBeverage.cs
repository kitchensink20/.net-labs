using lab3.Enums;
using System.Collections.Generic;

namespace lab3.Interfaces
{
    public interface IBeverage
    {
        CupType CupType { get; set; }
        MainIngridient MainIngridient { get; set; }
        List<LiquidType> Liquids { get; set; }
        List<Topping> Toppings { get; set; }
    }
}
