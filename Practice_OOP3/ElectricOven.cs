using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP3
{
    public class ElectricOven : IOven
    {
        public string Bake()
        {
            return "The Electric Oven is baking.";
        }
    }
}
