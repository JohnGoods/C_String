using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_Func和Action委托
{
    //实例
    delegate TResult Func<out TResult>  ();
    delegate TResult Func<in T, out TResult>(T arg);
    delegate TResult Func<in T1, in T2, out TResult>(T1 arg1,T2 arg2);
    //以此类推,对多到T16
    //
    delegate void Action();
    delegate void Action<in T> (T arg);
    delegate void Action<in T1,in T2>  (T1 arg1,T2 arg2);
    //以此类推,对多到T16



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
