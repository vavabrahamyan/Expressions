using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Expressions
{
    class Student
    {
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        private string Name { get; set; }
        private string Surname { get; set; }
        public int Age { get; }
        public string Fullname => Name + " " + Surname;
    }
}
