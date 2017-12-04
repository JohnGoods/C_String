using System;
using System.Collections.Generic;   //
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_迭代器
{
    //和foreach语句是枚举对象的使用者相对,迭代器是枚举对象的生产者.本例中:我们用迭代器返回Fibonacci数列表.
    //Fibonacci数列表的每个数字是前两个之和.
    class Program
    {
        
        static void Main(string[] args)
        {
            foreach (int fib in Fibs(6))
                Console.Write(fib + " ");       //  1 1 2 3 5 8
        }

        static IEnumerable<int> Fibs(int fibCount)
        {

            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                //return语句表示该方法返回的值,而yield return语句表示从本枚举器产生的下一个元素.
                yield return prevFib;   //返回prevFib  1 1 2 3 5 8
                int newFib = prevFib + curFib;  
                prevFib = curFib;
                curFib = newFib;
            }   
        }
    }
}
