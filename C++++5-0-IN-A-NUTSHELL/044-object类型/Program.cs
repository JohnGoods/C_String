using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_object类型
{
    class Program
    {
        public class Stack
        {
            //push表示一个元素进栈和pop表示一个元素出栈.
            int position;
            object[] data = new object[10];
            public void Push(object obj)
            {
                data[position++] = obj;
            }
            public object Pop()
            {
                return data[--position];
            }
        }


        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("sausage");
            string s = (string)stack.Pop(); //向下类型转换.需要显式转换

            Console.WriteLine(s);
        }
    }
}
