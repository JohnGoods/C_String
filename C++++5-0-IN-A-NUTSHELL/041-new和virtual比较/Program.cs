using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_new和virtual比较
{
    class Program
    {
        public class BaseClass  
        {
            public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }   //virtual是告诉其它想继承于他的类,你可以重写我的这个方法或属性,否则不允许.
        }

        public class Overrider:BaseClass    //override关键字
        {
            public override void Foo()
            {
                Console.WriteLine("Overrider.Foo");
            }
        }

        public class Hider:BaseClass        //new关键字
        {
            public new void Foo()
            {
                Console.WriteLine("Hider.Foo");
            }
        }

        static void Main(string[] args)
        {
            Overrider overrider = new Overrider();
            BaseClass b1 = overrider;
            overrider.Foo();    //Overrider.Foo     //重写会改变我的这个方法或属性
            b1.Foo();   //Overrider.Foo     //重写会改变我的这个方法或属性

            Hider hider = new Hider();
            BaseClass b2 = hider;
            hider.Foo();    //Hider.Foo     //new关键字重写会改变我的这个方法或属性
            b2.Foo();   //BaseClass.Foo     //new关键字但不会改变我原本的这个方法或属性
        }
    }
}
