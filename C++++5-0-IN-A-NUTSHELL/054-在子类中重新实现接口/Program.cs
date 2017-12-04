using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_在子类中重新实现接口
{
    //忘记了86页看接口重新实现的替代方法
    public interface IUndoable
    {
        void Undo();
    }

    public class TextBox : IUndoable
    {
         public void Undo()
        {
            Console.WriteLine("TextBox.Undo");
        }
    }

    public class RichTextBox : TextBox, IUndoable
    {
        public new void Undo()
        {
            Console.WriteLine("RichTextBox.Undo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RichTextBox r=new RichTextBox();
            r.Undo();   //RichTextBox.Undo
            ((IUndoable)r).Undo();      //RichTextBox.Undo
            ((TextBox)r).Undo();       //TextBox.Undo
        }
    }
}
