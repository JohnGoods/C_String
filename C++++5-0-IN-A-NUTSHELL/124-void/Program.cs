using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_void
{
    class Program
    {
        //空指针(void*) 不给出假定底层数据的具体类型,它对于处理原始内存的函数是非常有用的.任意指针类型都可以隐式转换为void*.void*不可以被解除引用,算数运算符不能通过void指针执行.例如:
        unsafe static void Main()
        {
            short[] a = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            fixed (short* p = a)
            {
                //sizeof返回值-类型的大小,单位为字节
                Zap(p, a.Length*sizeof (short));
            }
            foreach (short x in a)
            {
                System.Console.WriteLine(x);    //打印所有零
            }
        }

        unsafe static void Zap(void* memory, int byteCount)
        {
            byte* b = (byte*) memory;
            for (int i = 0; i < byteCount; i++)
            {
                *b++ = 0;
            }
        }
    }
}
