using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_var与dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = "hello";
            var y = "hello";
            //int j = x;      //运行时错误
            //int j = y;      //编译时错误
        }
    }
}
