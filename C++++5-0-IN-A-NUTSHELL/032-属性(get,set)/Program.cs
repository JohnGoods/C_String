using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_属性_get_set_
{
    class Program
    {
        private static decimal currentPrice;

        //63页
        public decimal CurrentPrice //公有属性
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }



        //get和set的访问权限
        public class Foo
        {
            private decimal x;
            public decimal X
            {
                get { return x; }
                private set{x=Math.Round(value,2);}
            }
        }




        static void Main(string[] args)
        {
        }
    }
}
