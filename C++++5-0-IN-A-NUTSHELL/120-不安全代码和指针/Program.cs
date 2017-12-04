using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace _120_不安全代码和指针
{
    //154页
    //指针基础
    /*运算符    作用
     * &        取址运算符返回指针地址所指的值
     * *        引用运算符返回指针地址所指的值
     * ->       指向成员的指针运算符是一个快捷语法,其中x->y等同于(*x).y
     */
    
    class Program
    {//不安全代码        (要在属性那开启不安全代码)
        unsafe void BlueFilter(int[,] bitmap)
        {
            int length = bitmap.Length;
            fixed (int* b=bitmap)  //fixed,锁定测试
            {
                int* p = b;
                for (int i = 0; i < length; i++)
                    *p++ &= 0xFF;
            }
        }
        
        //fixed语句是用来锁定托管对象的
         int x;
        static void Main(string[] args)
        {
            Program program=new Program();
            unsafe
            {
                fixed (int* pp = &program.x)    //锁定测试
                {
                    *pp = 9;
                }
                System.Console.WriteLine(program.x);
            }         
        }
    }
}
