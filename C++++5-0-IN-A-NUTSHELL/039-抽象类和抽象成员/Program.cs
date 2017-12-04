using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_抽象类和抽象成员
{
    class Program
    {
        //被声明为abstract的抽象类不能被实例化.只有抽象类的具体实现子类才能被实例化.
        public abstract class Asset
        {
            //实现为空
            public abstract decimal NetValue { get; }
        }

        //private Asset ass = new Asset();




       public class Stock:Asset
       {
           public long ShareOwned;
           public decimal CurrentPrice;

           //像虚方法一样重载
           public override decimal NetValue
           {
               get { return ShareOwned*CurrentPrice; }
           }
       }

        static void Main(string[] args)
        {
        }
    }
}
