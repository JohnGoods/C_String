using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_虚方法实现接口成员
{
    class Program
    {
        //默认情况下,接口成员的实现是隐式定义为sealed的.为了能重载,必须在基类中标识为virtual或者abstract,例如:
        public interface IUndoable
        {
            void Undo();
        }

        public class TextBox : IUndoable
        {
            public virtual void Undo()
            {
                Console.WriteLine("TextBox.Undo");
            }
        }

        public class RichTextBox : TextBox
        {
            public override void Undo()
            {
                Console.WriteLine("RichTextBox.Undo");
            }
        }

        static void Main(string[] args)
        {
            //不管从基类还是在接口中调用接口成员,调用的都是子类的实现:
            RichTextBox r=new RichTextBox();
            r.Undo();       //RichTextBox.Undo
            ((IUndoable)r).Undo();      //RichTextBox.Undo
            ((TextBox)r).Undo();        //RichTextBox.Undo
        }
    }
}
