using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _098_重载true和false2
{
    //下面代码重新实现了SqlBoolean中可以验证true和false运算符的一部分代码:
    public struct SqlBoolean
    {
        public static bool operator true(SqlBoolean x)
        {
            return x.m_value == True.m_value;
        }

        public static bool operator false(SqlBoolean x)
        {
            return x.m_value == False.m_value;
        }

        public static SqlBoolean operator !(SqlBoolean x)
        {
            if (x.m_value == Null.m_value) return Null;
            if (x.m_value == False.m_value) return True;
            return False;
        }

        public static readonly SqlBoolean Null = new SqlBoolean(0);   //readonly允许把一个字段设置成常量，但可以执行一些运算，可以确定它的初始值
        public static readonly SqlBoolean False = new SqlBoolean(1);
        public static readonly SqlBoolean True = new SqlBoolean(2);

        private SqlBoolean(byte value)
        {
            m_value = value;
        }

        private byte m_value;
        

        
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
