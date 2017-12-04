using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref修饰符
{
    class Program
    {
        static void Foo(ref int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
        static void Swap(ref string a,ref string b) //互换了这个函数的值
        {
            string temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 8;
            Foo(ref x); //让Foo直接对x进行操作
            Console.WriteLine(x);   //9

            string x1 = "Penn";
            string y1 = "Teller";
            Swap(ref x1, ref y1);
            Console.WriteLine(x1);  //Teller
            Console.WriteLine(y1);  //Penn
        }
    }
}
