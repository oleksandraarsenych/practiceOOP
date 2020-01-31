using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP3
{
    public class ElectricStove : IOven, ICooktop
    {
        public string Bake()
        {
            return "Electric Stove is baking. ";
        }

        public string Cook()
        {
            return " Electic Stove is cooking. ";
        }
    }
}
