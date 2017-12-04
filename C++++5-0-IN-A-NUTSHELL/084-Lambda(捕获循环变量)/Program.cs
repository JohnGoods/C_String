using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _084_Lambda_捕获循环变量_
{
    class Program
    {
        static void Main(string[] args)
        {
            Action[] actions = new Action[3];
            for(int i=0;i<3;i++)
            {
                actions[i] = () => Console.Write(i);
            }
            foreach (Action a in actions) a();        //333               
            //每个闭包捕获相同的变量i.每个委托在调用时才看到i值.此时,i值为3.
            //把for循环展开更容易理解
            /*Action[] actions = new Action[3];
             * int i=0;           
             * action[0]=()=>Console.Write(i);
             * i=1;
             * action[1]=()=>Console.Write(i);
             * i=2;
             * action[2]=()=>Console.Write(i);
             * i=3;
             * foerach(Action a in actions) a();    //333*/
            //如果你想输出012,把循环变量指定到循环内部的局部变量中
            Action[] actions1 = new Action[3];
            for(int i=0;i<3;i++)
            {
                int loopScopedi = i;
                actions1[i] = () => Console.Write(loopScopedi);               
            }
            foreach (Action a in actions1) a(); //012    
            //下面可以无视,看看就好
            Action[] actiona = new Action[3];
            int ii= 0;
            foreach (char c in "abc")
                actiona[ii++] = () => Console.Write(c);
            foreach (Action a in actiona) a();
        }
    }
}
