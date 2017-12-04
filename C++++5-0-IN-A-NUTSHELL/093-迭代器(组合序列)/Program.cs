using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _093_迭代器_组合序列_
{
    //迭代器具有高度可组合型,可以扩展实例.
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int fib in EvenNumbersOnly(Fibs(6)))
                Console.WriteLine(fib);
        }
        static IEnumerable<int> Fibs(int fibCount)
        {
            for(int i=0,prevFib=1,curFib=1;i<fibCount;i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
        static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
        {
            foreach (int x in sequence)
                if ((x % 2) == 0)
                    yield return x;
        }
    }
}
