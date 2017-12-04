using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_访问权限修饰符_public_
{
    //81页
    class Program
    {
            //public  //完全访问权限;枚举类型成员或接口隐含的访问权限
            //internal  //仅可访问程序集和友元程序集;非嵌套类型的默认访问权限
            //private   //仅在包含类型可见;类和结构体成员的默认访问权限
            //protected     //仅在包含类型和子类中可见
            //protected internal    //默认情况下尽可能将所有成员定义为私有,然后每个修饰符都会提高其访问级别.所以用protected internal修饰的成员在两个方面的访问级别都提高了

        //举例
        class Class{}       //class是internal访问权限的(默认)
        public class Class2{}

        class ClassA{int x;}    //x是private访问权限的
        class ClassB{internal int x;}   //ClassB有对本程序集的其他类的字段x;ClassA没有


        //SubClass里的函数可以调用Bar但不能调用Foo:
        class BaseClass
        {
             void Foo (){ }
            protected void Bar() { }
        }

        class SubClass:BaseClass
        {
            //void Test1() { Foo(); } //错误,不能访问Foo.因为仅在包含类型和子类中可见
            void Test2() { Bar(); }
        }


        //访问权限修饰符的限制
        //当重载基类的函数时,重载函数的访问权限必须一致.例如:
        class TestClass { protected virtual void Foo() { } }
        class BaseClass : TestClass { protected override void Foo() { } } //正确
        //class BaseClass1:TestClass{public override void Foo(){}}  //错误


        ///!!!子类可以比基类的访问权限高,但不能比基类访问权限高!!!
        ///!!!子类可以比基类的访问权限高,但不能比基类访问权限高!!!
        ///!!!子类可以比基类的访问权限高,但不能比基类访问权限高!!!
        static void Main(string[] args)
        {           
        }
    }
}
