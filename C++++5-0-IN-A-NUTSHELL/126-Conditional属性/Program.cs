using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;       //

namespace _126_Conditional属性
{
    //使用Conditional修饰的属性只有在出现指定的预处理符号时才编译.例如:
    class Info
    {
        //[Conditional("DEBUG")]
        public static void Trace(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        [Conditional("DEBUG")]
        public static void TraceX(string strFormat, params object[] list)
        {
            Console.WriteLine(strFormat, list);
        }
    }


    class Program
    {      
        static void Main(string[] args)
        {
            Info.Trace("Cool!");
            Info.TraceX("{0}{1}{2}","C","U",2001);
        }
    }
}
