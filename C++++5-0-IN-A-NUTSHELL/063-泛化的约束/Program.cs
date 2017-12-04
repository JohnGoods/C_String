using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_泛化的约束
{
    class Program
    {

        //96页!!!未完成
        /*可用的约束
        where T:base-class      //基类约束
        where T:interface   //接口约束
        where T:class   //引用类型约束
        where T:struct  //数值类型约束
        where T:new()   //无参数构造方法约束
        where U:T   //裸类型约束
        */

        //下面示例中,要求T派生自SomeClass且实现接口Interface1,要求U提供无参数构造方法
        class SomeClass { }
        interface Interface1 { }

        class GenericClass<T,U> where T:SomeClass,Interface1
                                where U:new()
        { }

        //
        public interface IComparable<T>
        {
            int CompareTo(T other);
        }
        //如果other比this大,CompareTo方法返回值.
        static  T Max<T>(T a,T b)where T:IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;  //c=(a>b)?a:b       //比较大小
        }

        
        

        static void Main(string[] args)
        {
            //int a = Max(5, 10);
            //string last = Max("ant", "zoo");
        }
    }
}
