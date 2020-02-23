using System;
using System.Linq.Expressions;

namespace _008_Expressions_Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Student() { Name = "A1", Surname = "A1yan", Age = 26 };

            Expression<Func<Student, bool>> q1 = f => f.Age > 12;
            Expression<Func<Student, bool>> q2 = f => f.Age < 20;

            BinaryExpression andExp = Expression.AndAlso(q1.Body, q2.Body);
            var parExp = Expression.Parameter(typeof(Student), "s");

            Expression<Func<Student, bool>> isTeenAgerExp = Expression.Lambda<Func<Student, bool>>(andExp, parExp);
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
