using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_委托中的泛型
{
    public delegate T Transformer<T>(T arg);

    public class Util
    {
        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square); //Square函数中的动态钩子
            foreach (int i in values)
                Console.Write(i + " "); //1 4 9
        }
        static int Square(int x)
        {
            return x * x;
        }
    }
}
