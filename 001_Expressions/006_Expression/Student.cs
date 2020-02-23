using System;
using System.Collections.Generic;
using System.Text;

namespace _006_Expression
{
    class Student
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void Show()
        {
            Console.WriteLine(this.Name + "  " + this.Surname);
        }
    }
}
