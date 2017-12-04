using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; //命名空间必备
//using _027_命名空间.Outer.Middle.Inner;   //导入命名空间指令

namespace _027_命名空间
{

    class Program
    {
        System.Security.Cryptography.RSA rsa=System.Security.Cryptography.RSA.Create(); //调用了RSA类型的Create方法
        static void Main(string[] args)
        {
            //Class1 c;A
        }
    }
        
    namespace Outer
    {
        namespace Middle
        {
            namespace Inter
            {
                class Class1{}
                class Class2{}
            }
        }
    }    
}