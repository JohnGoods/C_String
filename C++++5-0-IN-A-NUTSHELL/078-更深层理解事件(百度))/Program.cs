using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_更深层理解事件_百度__
{
    public class Control
    {
        public delegate void MyEventHandler(object sender, MyEventArgs e);
        public event MyEventHandler MyEvent;    //声明事件

        public class MyEventArgs : System.EventArgs     //所有事件参数类都必须从System.EventArgs类派生
        {
            public string ParamName;
            public MyEventArgs(string _name)
            {
                ParamName = _name;
            }
        }

        public void RiseSomeEvent()
        {
            //System.EventArgs e = new System.EventArgs();

            Console.Write("Please input 'Name':");
            string _param = Console.ReadLine(); //按下回车以后才读取,然后触发MyEvent事件

            //if(_param.Equals("jon"))    //在用户输入jon的情况下触发事件,否则不触发
            MyEvent(this, new MyEventArgs(_param));
        }

        public Control()        //RiseSomeEvent()后面调用
        {
            this.MyEvent += new MyEventHandler(RaiseSomeEvent);
        }

        //一个事件
        public void RaiseSomeEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("Hello" + e.ParamName);
            Console.ReadLine();
        }
    }  
    
    class Program
    {
        public static void demo4()
        {
            Control ctr = new Control();         
            ctr.MyEvent += new Control.MyEventHandler(ResponseSomeEvent);
            ctr.RiseSomeEvent();
        }
        public static void ResponseSomeEvent(object sender,EventArgs e)
        {
            Console.WriteLine("Some event occur!");
        }

        static void Main(string[] args)
        {
            demo4();
        }
    }
}
