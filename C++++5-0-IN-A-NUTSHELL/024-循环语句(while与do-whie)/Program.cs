using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_循环语句_while与do_whie_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<3)
            {
                Console.WriteLine(i);
                i++;
            }   //输入0 1 2

            //跟上面差不多
            int ii = 0;
            do
            {
                Console.WriteLine(ii);
                ii++;
            }
            while (ii < 3);
            //输入0 1 2
        }
    }
}
