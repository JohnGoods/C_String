using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_
{
    class Program
    {
        static void Main(string[] args)
        {
            //brea语句
            int x = 0;
            while (true)
            {
                Console.WriteLine(x);
                if (x++ >= 5)              
                    break;  //结束本次循环
            }

            Console.WriteLine("---分割线---");

            //continue语句
            for(int i=0;i<10;i++)
            {
                if((i%2)==0)
                {
                    continue;   //结束后面语句,继续下一轮循环
                }
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("---分割线---");

            //goto语句
            int gotoi=1;
            goto1:
            if(gotoi<=5)
            {
                Console.WriteLine(gotoi);
                gotoi++;
                goto goto1;
            }

            Console.WriteLine("---分割线---");
            //return语句
            Console.WriteLine(AsPercentage(1));
        }
        //return语句
        static decimal AsPercentage(decimal d)  //decimal十进制浮点数
        {
            decimal p = d * 100m;
            return p;
        }
    }
}
