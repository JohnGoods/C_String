using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_静态构造方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo.X);
        }

        class Foo
        {
            public static Foo Instance = new Foo();
            public static int X = 3;

            Foo()
            {
                Console.WriteLine(X);   //0
            }
        }
        //0
        //3
    }
}
