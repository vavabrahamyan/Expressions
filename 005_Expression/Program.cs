using System;
using System.Linq.Expressions;

namespace _005_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterExpression pe = Expression.Parameter(typeof(Student), "st");

            Expression<Func<Student, bool>> isTeenAgerExpr;
            isTeenAgerExpr = Expression.Lambda<Func<Student, bool>>(
                                Expression.AndAlso(
                                Expression.GreaterThan(Expression.Property(pe, "Age"), Expression.Constant(12, typeof(int))),
                                Expression.LessThan(Expression.Property(pe, "Age"), Expression.Constant(20, typeof(int)))), new[] { pe });

            var st1 = new Student("V1", "V1yan", 17);
            var st2 = new Student("V2", "V2yan", 47);

            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

            Show(st1, isTeenAger);
            //Show(st2, isTeenAger);
        }

        private static void Show(Student st, Func<Student, bool> isTeenAger)
        {
            if (isTeenAger(st))
            {
                Console.WriteLine(st.Fullname + "   is teenager");
            }
            else
            {
                Console.WriteLine(st.Fullname + "   isn't teenager");
            }

            Console.ReadLine();
        }
    }
}
