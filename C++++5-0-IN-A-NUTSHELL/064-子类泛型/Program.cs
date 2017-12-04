using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_子类泛型
{
    class Program
    {
        class Stack<T> { }
        class SpecialStack<T> : Stack<T> { }

        //子类也可以用具体类型关闭泛型参数
        class IntStack : Stack<int> { }
        //子类还可以引入新的类型变量
        class List<T> { }
        class KeyedList<T, Tkey> : List<T> { }


        static void Main(string[] args)
        {
        }
    }
}
