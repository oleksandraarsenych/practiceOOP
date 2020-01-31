using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP3
{
    public class GasStove : IOven, ICooktop
    {
        public string Bake()
        {
            return " Gas Stove is baking. ";
        }

        public string Cook()
        {
            return " Gas Stove is cooking. ";
        }
    }
}
