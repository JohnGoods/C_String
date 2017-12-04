using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_默认数组元素初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            Console.Write(a[123]);      //0  a第124个 默认为0
        }
    }
}
