using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_实例方法和静态方法的Targer属性
{
    //106页
    //当委托对象指向一个实例方法时,委托对象不仅需维护到方法的引用,而且需维护到方法所属类实例的引用.
    //System.Delegate类的Targer属性表示这个类实例(当委托引用静态方法时为null).例如:
    public delegate void ProgressReporter(int percentComplete);
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X();
            ProgressReporter p = x.InstanceProgress;
            p(99);  //99
            Console.WriteLine(p.Target == x);   //True
            Console.WriteLine(p.Method);    //void InstanceProgress(Int32)
        }

        class X
        {
            public void InstanceProgress(int percentComplete)
            {
                Console.WriteLine(percentComplete);
            }
        }
    }
}
