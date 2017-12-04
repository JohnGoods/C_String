using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _079_标准事件模式
{
    //EventArgs是用于为时间传递信息的基类.在Stock实例中,我们定义EventArgs的子类,用来在事件PriceChanged被引发时,传递新旧Price值.
    public class PriceChangedEventArgs:System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice,decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
        //考虑到"复用性",EventArgs子类根据它包含的内容命名.
        //定义了EventArgs的子类,下一步是选择或定义事件的委托,需遵循三条原则:
        //1.委托必须以void作为返回值
        //2.委托必须接受两个参数:第一个是object类,一个是EventArgs的子类.第一个参数表明事件的广播者,第二个参数包含需要传递的额外信息
        //3.委托的名称必须以EventHandler结尾
        //框架定义一个名System.EventHandler<>的泛化委托,该委托满足以下条件：
        //public delegate void EventHandler<TEventArgs>(object source, TEventArgs e) where TEventArgs : EventArgs;
    }
    //再下一步是定义选定委托类型的事件,这里使用泛化委托EventHandler:
    //public event EventHandler<PriceChangedEventArgs> PriceChanged;
    public class Stock
    {
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        string symbol;
        decimal price;
        public Stock(string symbol) { this.symbol = symbol; }
        //最后,该模式要求写一个受保护的(protected)虚方法引发事件.方法名必须和事件名一致,以On作为前缀,并接受唯一的EventArgs参数
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged != null) PriceChanged(this, e);
        }


        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return; //如果没有变化就退出   value代表默认字段
                OnPriceChanged(new PriceChangedEventArgs(price, value));
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(value, price));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("THPW");
            stock.Price = 27.10M;
            //注册PriceChanged事件
            stock.PriceChanged += stock_PriceChanged;
            stock.Price = 31.59M;
        }

        static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            //throw new NotImplementedException();
            if((e.NewPrice - e.LastPrice)/e.LastPrice>0.1M)
            { Console.WriteLine("Alert,10% stock price increase!"); }           
        }
    }
}
