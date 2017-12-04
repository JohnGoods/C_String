using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_隐式调用无参数的构造方法
{
    class Program
    {
        public class BaseClass
        {
            public int X;
            public BaseClass() { X = 1; }
        }

        public class Subclass:BaseClass
        {
            public Subclass()
            {
                Console.WriteLine(X);       //1
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
