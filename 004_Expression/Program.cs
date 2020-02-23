using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Messaging;

namespace _004_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterExpression pe = Expression.Parameter(typeof(Student), "st");

            // n1 Expression 
            MemberExpression meAge = Expression.Property(pe, "Age");
            // n2 Expression
            ConstantExpression constatn18 = Expression.Constant(18, typeof(int));
            // n3 = n1 and n2 Expression
            BinaryExpression body = Expression.GreaterThanOrEqual(meAge, constatn18);

            var isAdultExprTree = Expression.Lambda<Func<Student, bool>>(body, new[] { pe });

            Console.WriteLine("Expression Tree: {0}", isAdultExprTree);
            Console.WriteLine("Expression Tree Body: {0}", isAdultExprTree.Body);
            Console.WriteLine("Number of Parameters in Expression Tree: {0}", isAdultExprTree.Parameters.Count);
            Console.WriteLine("Parameters in Expression Tree: {0}", isAdultExprTree.Parameters[0]);
        }
    }
}
