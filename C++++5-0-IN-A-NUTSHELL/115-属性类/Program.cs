using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115_属性类
{
    class Program
    {
        [ObsoleteAttribute] //将ObsoleteAttribute附加到Foo类上
        public class Foo
        {
            //所有属性类型都以Attribute结尾.C#能够识别这个后缀,也可以在附加一个属性时省略这个后缀.
        }

        [Obsolete]
        public class Foo1
        {
            
        }

        //[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        //private sealed class ObsoleteAttribute : Attribute
        //{
        //    // See the attribute guidelines at 
        //    //  http://go.microsoft.com/fwlink/?LinkId=85236
        //    private readonly string positionalString;

        //    // This is a positional argument
        //    public ObsoleteAttributeAttribute(string positionalString)
        //    {
        //        this.positionalString = positionalString;

        //        // TODO: Implement code here
        //        throw new NotImplementedException();
        //    }

        //    public string PositionalString { get; private set; }

        //    // This is a named argument
        //    public int NamedInt { get; set; }
        //}

        static void Main(string[] args)
        {
        }
    }
}
