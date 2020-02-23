using System;
using System.Linq.Expressions;

namespace _002_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Student, bool>> isTeenAgerExp = s => s.Age > 12 && s.Age < 20;

            Func<Student, bool> isTeenAger = isTeenAgerExp.Compile();

            var st = new Student("Bill", "Gates", 18);

            if (isTeenAger(st))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
