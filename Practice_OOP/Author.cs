using System;

namespace Practice_OOP
{
    public class Author
    {
        public string Name { get; private set;}
        public string LastName { get; private set; }

        public Author(string Name, string LastName)
        {
            this.Name = Name;
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return  Name + " " + LastName;
        }
    }
}
