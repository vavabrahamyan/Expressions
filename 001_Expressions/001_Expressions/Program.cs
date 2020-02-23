using System;

namespace _001_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Student, bool> isTeenAger = s => s.Age > 12 && s.Age < 20;

            Func<Student, int> usersAge = s => s.Age;

            var st = new Student("Tom", "Brown", 17);

            //Console.WriteLine(usersAge(st));
            if (isTeenAger(st))
            {
                Console.WriteLine(st.Fullname + "   is Teenager");
            }
            else
            {
                Console.WriteLine(st.Fullname + "   isn't Teenager");
            }

            Console.ReadLine();
        }
    }
}
