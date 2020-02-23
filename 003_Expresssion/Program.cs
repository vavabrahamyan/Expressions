using System;
using System.Linq.Expressions;

namespace _003_Expresssion
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Action<Student>> studentsNameExpr = s => Console.WriteLine(s.Fullname);

            var st = new Student("Gag", "Gagyan", 24);

            Action<Student> printFullName = studentsNameExpr.Compile();
            printFullName.Invoke(st);

            Console.ReadLine();
        }
    }
}
