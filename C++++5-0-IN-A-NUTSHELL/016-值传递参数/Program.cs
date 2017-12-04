using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_值传递参数
{
    class Program
    {
        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");   //Append现有文本中追加新值"test"
            fooSB = null;
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine(sb.ToString());   //test
        }
    }
}
