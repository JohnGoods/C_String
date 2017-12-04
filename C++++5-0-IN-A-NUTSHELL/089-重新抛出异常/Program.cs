using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;   //(16章)

namespace _089_重新抛出异常
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            using (WebClient wc = new WebClient())
                try
                {
                    s = wc.DownloadString("http://www.albahari.com/nutshell/");
                }
            catch(WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                        Console.WriteLine("Bad domain name");
                    else
                        throw;  //不能处理其他种类的webException,所以抛出
                }
            //System.Exception的关键属性:

            //StackTrace     //表示从异常到起源到catch块的所有方法的字符串

            //Message   //描述异常的字符串

            //InnerException    //导致外部异常的内部异常.它本身还可能有另外一个InnerException
        }
    }
}
