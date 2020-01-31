using System;


namespace PracticeOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IInput keyboard = new Keyboard();
            IInput mouse = new Mouse();
            IInput joystick = new Joystick();

            IDisplay builtInDisplay = new BuiltInDisplay();
            IDisplay externalDisplay = new ExternalDisplay();
            IDisplay projector = new Projector();

            IProcessor armProcessor = new ArmProcessor();
            IProcessor amd64Processor = new Amd64Processor();

            Computer computer1 = new Computer(mouse, externalDisplay, armProcessor);
            Computer computer2 = new Computer(keyboard, projector, armProcessor);
            Computer computer3 = new Computer(joystick, builtInDisplay, amd64Processor);

            computer1.Work();
            computer2.Work();
            computer3.Work();
        }
    }
}
