using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //StreamReader

namespace _087_finally程序块
{
    class Program
    {
        //无论是否抛出异常,也不管try程序块是否完全执行,finally程序块总是被执行.通常用finally程序块来清除代码
        static void Main(string[] args)
        {
            StreamReader reader = null; //System.IO命名空间
            try
            {
                reader = File.OpenText("file.txt");
                //因为是空文件,所以提前返回EndOfStream
                if (reader.EndOfStream) return; //EndOfStream是EndOfStream的一个属性,表示获取一个值,该值表示当前的流位置是否在流的末尾.       
                Console.WriteLine(reader.ReadToEnd());  //一次读一行
            }
            finally
            {
                if (reader != null) reader.Dispose();   //释放
            }
        }
    }
}
