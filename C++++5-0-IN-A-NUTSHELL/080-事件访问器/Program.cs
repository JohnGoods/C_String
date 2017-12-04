using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080_事件访问器
{
    
    class Program
    {
        //事件访问器是对+=和-=功能的实现.默认情况下,访问器由编译器隐式实现.例如下面的事件声明
        //public event EventHandler PriceChanged;

        //编译器把它转为:
        //一个私有的委托字段.
        //一对公有的事件访问器函数,它们实现私有委托字段的+=,-=运算.

        //下面是手动实现前面实例中的PriceChanged事件:
        private EventHandler _priceChanged; //声明一个私有委托

        private event EventHandler PriceChanged
        {
            add { _priceChanged += value; }
            remove { _priceChanged -= value; }
        }

        /*当显示实现声明事件的接口时.
        public interface IFoo { event EventHandler EV;}     
        class Foo:IFoo
        {
            private EventHandler ev;
            event EventHandler IFoo.EV
            {
                add { ev += value; }
                remove { ev -= value; }
            }
        }
        */
        static void Main(string[] args)
        {
        }
    }
}
