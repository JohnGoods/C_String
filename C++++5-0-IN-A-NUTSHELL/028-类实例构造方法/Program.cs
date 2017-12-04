using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_类实例构造方法
{
    class Program
    {
        public class Panda
        {
            String name;    //定义字段
            public Panda(String n)      //定义构造方法
            {
                name = n;       //初始化代码(给代码赋值)
            }
        }        
        static void Main(string[] args)
        {
            Panda p = new Panda("Petey");       //调用构造方法
        }
    }
}
