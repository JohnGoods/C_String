using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_匿名类型
{
    //近似
    internal class AnonymousGeneratedTypeName
    {
        private string name;
        private int age;

        public AnonymousGeneratedTypeName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get { return name; } }
        public int Age { get { return age; } }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var dude = new { Name = "Bob", Age = 1 };
            //接近似
            var dude1=new AnonymousGeneratedTypeName("Bob",23);
            //如果两个匿名类型实例的元素是相同类型的,并且它们在相同的程序集中声明,那么它们在内部是相同的类型.
            var a1 = new {x = 2, y = 4};
            var a2 = new {x = 2, y = 4};
            Console.WriteLine(a1.GetType()==a2.GetType());  //True
            Console.WriteLine(a1==a2);  //False
            //匿名类型的Equals方法也被重载了,从而能够执行正确的等于比较运算:
            Console.WriteLine(a1.Equals(a2));   //True

            //可以创建多个匿名类型数组:
            var dudes=new[]
            {
                new{Name="Bob",Age=30},
                new{Name="Tom",Age=40}
            };
        }
    }
}
