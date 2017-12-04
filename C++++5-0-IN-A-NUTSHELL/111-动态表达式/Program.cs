using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_动态表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = 2;
            var y = x*3;    //y的静态类型是动态的

            dynamic x1 = 2;
            var y1 = (int) 2;   //y的静态类型是int
        }
    }
}
