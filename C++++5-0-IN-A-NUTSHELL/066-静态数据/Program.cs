using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_静态数据
{
    //对于每个封装的类来说,静态数据是全局唯一的:
    class Bob<T> { public static int Count;}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(++Bob<int>.Count);    //1
            Console.WriteLine(++Bob<int>.Count);    //2
            Console.WriteLine(++Bob<string>.Count); //1
            Console.WriteLine(++Bob<object>.Count); //1
        }
    }
}
