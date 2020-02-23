using System;
using System.Linq.Expressions;

namespace _011_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Student { Age = 32, Name = "A", Surname = "A" };

            Expression<Func<Student, bool>> q1 = s => s.Age > 12;
            Expression<Func<Student, bool>> q2 = s => s.Age < 20;
            Expression<Func<Student, bool>> q3 = s => s.Age == 32;

            Expression<Func<Student,bool>> isTeenAgerExp = q1.And(q2).Or(q3);

            Func<Student, bool> isTeenAger = isTeenAgerExp.Compile();
            if (isTeenAger(st))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }
}
