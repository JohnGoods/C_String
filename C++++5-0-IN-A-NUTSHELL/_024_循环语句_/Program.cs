using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_循环语句_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);   //输出0,1,2
            }

            Console.WriteLine("---分割线---");

            for(int i=0,prevFib=1,curFib=1;i<10;i++)
            {
                Console.WriteLine(prevFib);     
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
            /*输出
             *1.1
             *2.1
             *3.2
             *4.3
             *5.5
             *6.8
             *7.13
             *8.21
             *9.34
             *10.55
            */

            Console.WriteLine("---分割线---");

            foreach (char c in "beer")
                Console.WriteLine(c);
        }
    }
}
