using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_对象初始化器
{
    class Program
    {
        public class Bunny
        {
            public string Name;
            public bool LikesCarrots;
            public bool LikesHumans;

            public Bunny() { }
            public Bunny(string n) { Name = n; }        //Name=n
        }
        static void Main(string[] args)
        {
            //用初始化器初始化Bunny对象的方法如下:
            //无参数构造方法可以省略空括号
            Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
            Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };    //上下等同
        }


        /*public class Bunny(string name,bool likesCarrots,bool likesHumans)
        {
            Name=name;
            LikesCarrots=likesCarrots;
            LikesHumans=likesHumans;
        }*/ //据说避免在公有方法使用可选参数,详见62页
    }
}
