using System;
using System.Linq.Expressions;

namespace _007_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            var mi = typeof(MyConvert).GetMethod("ToInt32", new[] { typeof(string) });

            var par = Expression.Parameter(typeof(string), "p");
            var convertEx = Expression.Convert(par, typeof(int), mi);
            Expression<Func<string, int>> ToInt32Exp = Expression.Lambda<Func<string, int>>(convertEx, par);

            Func<string, int> toInt32 = ToInt32Exp.Compile();
            int a = toInt32("25");
        }
    }
    static class MyConvert
    {
        public static int ToInt32(string value)
        {
            return Convert.ToInt32(value);
        }
    }
}
