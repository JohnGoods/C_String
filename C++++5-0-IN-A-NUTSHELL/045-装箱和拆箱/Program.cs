using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_装箱和拆箱
{
    class Program
    {
      static void Main(string[] args)
        {
            //装箱就是将数值类型转换成引用类型实例的行为
            //int x = 9;
            //object obj = x; //把int类型装箱

            //拆箱就是把类型转换成原始数值类型
            //int y = (int)obj;

            //装箱和拆箱的实质是复制
            int i = 3;
            object obj = i;
            i = 5;
            Console.WriteLine(obj);
        }
    }
}
