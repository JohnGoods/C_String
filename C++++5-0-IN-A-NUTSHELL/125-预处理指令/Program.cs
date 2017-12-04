using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125_预处理指令
{
    class Program
    {
        private int x;

        void Foo()
        {
#if DEBUG   //预处理指令
            Console.WriteLine("Testing:x={0}",0);
#endif
        }
        static void Main(string[] args)
        {
#region 大纲开始位置
            //内容
#endregion
        }
    }
}
