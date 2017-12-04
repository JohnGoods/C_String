using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   //!!!

namespace _051_接口
{
    //接口跟类相似,但是接口只为成员提供定义不提供实现
    public interface IEnumerator    //interface=接口
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }

    //接口成员总是隐式地定义成public,并且不能用访问权限修饰符声明.
    internal class Countdown :IEnumerator
    {
        int count = 11;
        public bool MoveNext()
        {
            return count -- > 0;
        }
        public object Current { get { return count; } }
        public void Reset() { throw new NotSupportedException();}        
    }

    


    class Program
    {      
        static void Main(string[] args)
        {
            //可以把对象隐式转换为它实现的任意一个接口  
            IEnumerator e = new Countdown();
            while (e.MoveNext())
            {
                Console.Write(e.Current);
            }
        }
    }
}
