using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134_框架基础_字符串_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建字符串
            string s1 = "Hello";
            string s2 = "First Line\r\nSecond Line";
            string s3 = @"\\server\fileshare\helloworld.cs";
            Console.WriteLine(new string('*',10));  //**********
            //也可以从char数组创建字符串.
            char[] ca = "Hello".ToCharArray();  //ToCharArray将此实例字符复制到字符数组
            string s=new string(ca);
            Console.WriteLine(s);
            Console.WriteLine("--------------------");

            //2.Null和空字符串
            string empty = "";
            Console.WriteLine(empty="");    //True
            Console.WriteLine(empty == String.Empty); //True
            Console.WriteLine(empty.Length == 0); //True
            //由于字符串是引用类型,他们也可能是null
            string nullString = null;
            Console.WriteLine(nullString==null);    //True
            Console.WriteLine(nullString=="");  //False
            //Console.WriteLine(nullString.Length==0);    会报错
            Console.WriteLine("--------------------");

            //3.访问字符串中的字符
            string str = "abcde";
            char letter = str[2];   //c
            Console.WriteLine(letter);
            foreach (char a in "abcde")
            {
                Console.Write(a+",");   //a,b,c,d,e
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");

            //4.字符串内搜索  
            //在字符串内搜索最简单的方法是Contains,StartsWith和EndsWith.都会返回true或者false    (-1表示该字符串不存在)
            Console.WriteLine("quick brown fox".Contains("brown")); //brown此对象是否出现在字符串里     true
            Console.WriteLine("quick brown fox".EndsWith("fox"));   //结尾是否与制定字符串匹配  true    
            //IndexOf方法更强大.它会返回制定字符首次出现的位置
            Console.WriteLine("abcde".IndexOf("cd"));   //2
            //LastIndexOf是从后面向前搜索的,跟IndexOf差不多
            Console.WriteLine("abcde".LastIndexOf("de"));   //3
            //IndexOfAny则返回任意一系列字符的首次匹配的位置
            Console.Write("ab,cd ef".IndexOfAny(new char[]{' '}));      //5
            Console.WriteLine("");
            Console.Write("pas5w0rd".IndexOfAny("0123456789".ToCharArray()));   //3
            Console.WriteLine("");
            //LastIndexOfAny则在反方向执行相同的操作
            Console.WriteLine("--------------------");

            //5.字符串处理
            //Substring是取字符串的一部分
            string left3 = "12345".Substring(0, 3); //"123"
            string mid3 = "12345".Substring(1, 3);  //"234"
            //如果省略长度,那么会得到余剩的字符串:
            string end3 = "12345".Substring(2); //"345"
            //Insert和Remove会从一个指定位置插入或删除一些字符
            string ss1 = "helloworld".Insert(5, ",");
            string ss2 = ss1.Remove(5,2);    //后面是在5后面要删除多少字符
            Console.WriteLine(ss2);
            //Padleft和PadRight会用特定字符将字符串(如果未指定,则使用空格)填充成指定的长度:
            Console.WriteLine("12345".PadLeft(9,'*'));  //****12345
            Console.WriteLine("12345".PadLeft(9));  //     12345
            //TrimStart和TrimEnd会从字符串的开始或结尾删除指定的字符;Trim则用两个方法执行删除操作.默认情况下,这些函数会删除空白字符.
            Console.WriteLine("abc \t\r\n".Trim().Length);      //3
            //Replace会替换字符中出现的特定字符或子字符串
            Console.WriteLine("to be done".Replace(" ","|"));   //to|be|done
            Console.WriteLine("to be done".Replace(" ",""));    //tobedone
            Console.WriteLine("--------------------");

            //6.分割和连接字符串
            //Split接受一个句子,返回一个单词数组:
            string[] words = "The quick brown fox".Split();     //默认情况下,Split使用空白字符作为分隔符
            foreach (string a in words)
            {
                Console.Write(a+"|");
            }
            //Split还可以选择接受一个StringSplitOptions枚举值,它支持删除一些空项.
            //静态的Join方法执行与Split相反的操作,它需要一个分隔符和字符串数组
            string[] wordss = "The quick brown fox".Split();
            string together = string.Join(" ", wordss); //The quick brown fox
            //静态的Concat方法与Join类似,但是他知会接受字符串数组参数,并且没有分隔符.(Concat与+操作效果完全相同!!!)
            string sentence = string.Concat("The", "quick", "brown", "fox");
            string sameSentence = "The" + "quick" + "brown" + "fox";
            Console.WriteLine("");
            Console.WriteLine("--------------------");

            //7.String.Format与组合格式字符串
            string composite="It's {0} degrees in {1} on this {2} morning";
            string sss = string.Format(composite, 35, "Perth", DateTime.Now.DayOfWeek);
            Console.WriteLine(sss);
            //花括号里面的每一个数字称为格式项.这些数字对应参数位置.
            //最小宽度用于对齐各个列.如果这个值负数,那么数据就是左对齐的;否则,数据就是右对齐的.
            string composite1 = "Name={0,-20} Credit Limit={1,15:C}";
            Console.WriteLine(String.Format(composite1,"Mary",500));
            Console.WriteLine(String.Format(composite1,"Elizabeth",20000));
        }
    }
}
