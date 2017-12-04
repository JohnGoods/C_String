using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_事件实例
{
    class Program
    {
        //Stock类中每当Price值发生变化时.引发PriceChanged事件
        public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);   //委托事件

        public class Stock
        {
            string symbol;
            decimal price;

            public Stock (string symbol)
            {
                this.symbol = symbol;
            }

            public event PriceChangedHandler PriceChanged;

            public decimal Price
            {
                get { return price; }
                set
                {
                    if (price == value) return; //如果没有变化就退出   value代表默认字段
                    decimal oldPrice = price;
                    price = value;
                    if (PriceChanged != null)   //如果调用列表不为空,引发事件
                        PriceChanged(price, value);
                }
            }
        }


        static void Main(string[] args)
        {

        }
    }
}
