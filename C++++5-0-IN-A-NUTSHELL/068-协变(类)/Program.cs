using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_协变_类_
{
    class Program
    {
        //为了保证静态类的安全性,泛化类不是协变的:
        class Animal { }
        class Bear : Animal { }
        class Camel : Animal { }

        //简单的栈实现
        public class Stack<T>
        {
            int position;
            T[] data = new T[100];
            public void Push(T obj)
            {
                data[position++] = obj;
            }
            public T Pop()
            {
                return data[--position];
            }
        }

        //下面的语句编译通不过
        //Stack<Bear> bears = new Stack<Bear>();
        //Stack<Animal> animals = bears;  //编译时错误

        //协变性的缺失可能妨碍复用性.假定下例中,我们想写一个Wash方法来操作整个Animal栈:
        public class ZooCleaner
        {
            /*
            public static void Wash(Stack<Animal> animals) 
            {

            }
            //如果调用Wash方法操作Bear栈,会导致编译错误.解决方法是,重新定义一个带有约束的Wash
            */
            public static void Wash<T>(Stack<T> animals)where T:Animal
            {

            }
        }
       
        static void Main(string[] args)
        {
            Stack<Bear> bears=new Stack<Bear>();
            ZooCleaner.Wash(bears);
        }
    }
}
