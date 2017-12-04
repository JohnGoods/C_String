using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_事件
{
    class Program
    {
        //声明事件最简单的方法是,在委托成员的前面加上event关键字:
        public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
        public class Broadcaster
        {
            //Event
            public event PriceChangedHandler priceChanged;
        }

        static void Main(string[] args)
        {
        }
    }
}
