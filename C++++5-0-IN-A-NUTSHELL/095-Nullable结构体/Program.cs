using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _095_Nullable结构体
{
    //T?转换成System.Nullable<T>.而Nullable<T>是一个轻量的不变结构,它只有两个域,分别是Value和HasValue.System.Nullable<T>实质上是很简单的:
    class Program
    {
        public struct Nullable<T>where T:struct
        {
            //public T Value { get;  }
            //public bool HasValue { get; }         //????
           // public T GetValueOrDefault();
            //public T GetValueOrDefault(T defaultValue);
        }

        static void Main(string[] args)
        {
            Nullable<int> i = new Nullable<int>();
            //Console.WriteLine(!i.HasValue);     //True
            int? a = 1, b = 2;
            Console.WriteLine(a ?? b??i);      //??是空值合并运算符
        }
    }
}
