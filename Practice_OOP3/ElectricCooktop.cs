using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP3
{
    public class ElectricCooktop : ICooktop
    {
        public string Cook()
        {
            return "Electric Cooktop is cooking. ";
        }
    }
}
