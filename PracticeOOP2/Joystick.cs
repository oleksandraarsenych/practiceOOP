using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP2
{
    public class Joystick : IInput
    {
        public string GetInput()
        {
            return "joystick";
        }
    }
}
