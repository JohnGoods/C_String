using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _135__事件与委托_
{   
    class Program
    {
        // 步骤1，声明delegate对象
        public delegate void MyDelegate(string name);

        // 这是我们欲传递的方法，它与MyDelegate具有相同的参数和返回值类型
        public static void MyDelegateFunc(string name)
        {
            Console.WriteLine("Hello, "+name);
        }

         public static void Main()
        {
            // 步骤2，创建delegate对象(实例？？)
            MyDelegate md =new MyDelegate(Program.MyDelegateFunc);
            // 步骤3，调用delegate
            md("sam");
        }
    }
}
