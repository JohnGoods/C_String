using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082_Lambda表达式
{
    class Program
    {
        delegate int Transformer(int i);
        static void Main(string[] args)
        {
            //Lambda表达式有以下形式:
            //(参数)=>表达式或语句块
            Transformer sqr = x => x * x;
            //Func<int, int> sqr= (int x) => x * x;//也可以显式指定x的类型
            Console.WriteLine(sqr(3));  //9
            //通常和Func和Action委托一起使用
            Func<int, int> sqr1 = x => x + x;
            Console.WriteLine(sqr1(3)); //6
            Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
            int total = totalLength("hello", "World");  //10
            Console.WriteLine(total);
        }
    }
}
