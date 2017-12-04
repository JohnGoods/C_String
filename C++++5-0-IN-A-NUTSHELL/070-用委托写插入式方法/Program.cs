using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070_用委托写插入式方法
{
    public delegate int Transformer(int x);

    class Util
    {
        public static void Transform(int []value,Transformer t)
        {
            for(int i=0;i<value.Length;i++)
            {
                value[i] = t(value[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square); //动态挂在到Square函数
            foreach (int i in values)
                Console.Write(i + " "); // 1 4 9
        }

        static int Square(int x)
        {
            return x * x;
        }
    }
}
