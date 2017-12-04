using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _085_try语句和异常
{   
    class Program
    {
        //举例
        /*
        try
        {
            ...//在执行本代码语快时,可以抛出异常.
        }
        catch(ExceptionA ex)
        {
            ...//处理ExceptionA类型的异常
        }
        catch(ExceptionB ex)
        {
            ...//处理ExceptionB类型的异常
        }
        finally
        {
            ...//清除代码
        }
        */ 

        static int Calc(int x) { return 10 / x; }
        static void Main(string[] args)
        {
            try
            {
                int y = Calc(0);
                Console.WriteLine(y);
            }
            catch (DivideByZeroException ex) //DivideByZeroException异常,可以通过catch捕获异常防止程序异常终止:
            {
                Console.WriteLine("x cannot be zero");
            }
            Console.WriteLine("program completed");       
        }
    }
}
