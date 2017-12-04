using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_ToString方法
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x = 1;
            string s = x.ToString();
            Console.WriteLine(s);   //s="1"

            //当直接在数值型对象上调用像ToString这样的重载的object成员时,不会发生装箱.只有进行类型转换时,才会执行装箱操作:
            int X = 1;
            String s1 = X.ToString();   //调用没有装箱的值得
            Object box = X;
            String s2 = box.ToString(); //调用装箱后的值
        }
    }
}
