using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _083_Lambda_捕获外部变量_
{
    class Program
    {
        //Lambda可以引用方法内的内部变量和参数(外部变量)：
        static void Main(string[] args)
        {
            int factor = 2;
            int factor1 = 2;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(3));   //6
            //1.Lambda引用的外部变量称为捕获变量.捕获变量表达式称为一个闭包.捕获变量在真正调用委托时被赋值,而不是在捕获时赋值:
            Func<int, int> multiplier1 = n => n * factor1;
            factor1 = 10;
            Console.WriteLine(multiplier1(3));

            //2.Lambda表达式可以自动更新捕获变量
            int seed = 0;
            Func<int> natural = () => seed++;
            Console.WriteLine(natural());   //0
            Console.WriteLine(natural());   //1
            Console.WriteLine(seed);  //2

            //3.1接捕获声明周期可以延伸到和委托的声明周期相同:
            Func<int> natural1 = Natural1();
            Console.WriteLine(natural1());  //0
            Console.WriteLine(natural1());  //1  

            //4.1接在Lambda表达式内部实例化的局部变量,在每次调用委托实例期间是唯一的.
            Func<int> natural2 = Natural2();
            Console.WriteLine(natural2());  //0
            Console.WriteLine(natural2());  //0 
        }

        //3.捕获声明周期可以延伸到和委托的声明周期相同:
        static Func<int> Natural1()
        {
            int seed = 0;
            return () => seed++;    //返回一个闭包
        }

        //4.在Lambda表达式内部实例化的局部变量,在每次调用委托实例期间是唯一的.
        static Func<int> Natural2()
        {
            return () => { int seed = 0; return seed++; };
        }
    }
}
