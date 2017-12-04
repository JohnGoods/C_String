using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;   //引入命名空间

namespace _106_自定义绑定
{
    public class Duck : DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + " Method was called");
            result = null;
            return true;
        }
    }


    class Program
    {
        //20章将会对自定义绑定器进行深入讨论,现在编写一个简单的绑定器来演示这个特性
        static void Main(string[] args)
        {
            dynamic d = new Duck();
            d.Quack();  //调用Quack方法
            d.Waddle(); //调用Waddle方法
        }
    }
}
