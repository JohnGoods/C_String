using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061_泛型
{
    class Program
    {
        public class Stack<T>
        {
            private int position;
            T[]data=new T[100];
                
            public void Push(T obj)     //position++ 我的理解就是数组添加一个
            {
                data[position++] = obj;
                Console.WriteLine(position);
            }

            public T pop()
            {
                return data[--position];               
            }
        }
        static void Main(string[] args)
        {
            //使用Stack<T>的方法如下:
            Stack<int> stack=new Stack<int>();
            stack.Push(5);      //data[1]=5
            stack.Push(10);     //data[2]=10
            int x = stack.pop();        //data[2]=10
            int y = stack.pop();        //data[1]=5
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
