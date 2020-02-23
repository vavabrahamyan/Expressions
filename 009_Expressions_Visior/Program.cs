using System;
using System.Linq.Expressions;

namespace _009_Expressions_Visior
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Student() { Name = "A1", Surname = "A1yan", Age= 17 };

            Expression<Func<Student, bool>> q1 = s => s.Age > 12;
            Expression<Func<Student, bool>> q2 = s => s.Age < 20;

            BinaryExpression body = Expression.AndAlso(q1.Body, q2.Body);
            var parExp = Expression.Parameter(typeof(Student), "p");

            var visitedBody = new ParameterReplacer(parExp).Visit(body);

            Expression<Func<Student, bool>> isTeenAgerExpr = Expression.Lambda<Func<Student, bool>>(visitedBody, parExp);

            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

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
