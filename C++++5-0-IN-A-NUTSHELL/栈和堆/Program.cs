using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈和堆
{
    class Program
    {
        //栈 //存储局部变量和参数的内存块.
        static int Factorial(int x)     //这个方法就是递归的,每次进入这个方法时,就在栈上分配一个新的int,每次离开这个方法时,就会释放一个int.
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }
        //栈  
        static void Main(string[] args)
        {
            //堆 //堆是指对象残留的内存块.
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);
            //后面没有用到了,所以现在ref1现在被垃圾回收器选中
            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;
            //引用对象StringBuilder对面的ref2现在没有被垃圾回收器选中
            Console.WriteLine(ref3);    //object2
            //堆
        }        
    }
}
