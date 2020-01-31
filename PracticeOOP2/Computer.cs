using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP2
{
    class Computer
    {
        private IInput input;
        private IDisplay display;
        private IProcessor processor;

        public Computer(IInput input, IDisplay display, IProcessor processor)
        {
            this.input = input;
            this.display = display;
            this.processor = processor;
        }

        public void Work()
        {
            Console.WriteLine("This computer has " + input.GetInput() + ", " + display.Display() + ", " + processor.Process());
        }
    }
}
