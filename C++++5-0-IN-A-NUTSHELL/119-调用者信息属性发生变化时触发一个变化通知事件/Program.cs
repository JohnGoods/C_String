using System;
using System.Collections.Generic;
using System.ComponentModel;    //
using System.Linq;
using System.Runtime.CompilerServices;  //引入命名空间
using System.Text;
using System.Threading.Tasks;

namespace _119_调用者信息属性发生变化时触发一个变化通知事件
{
    //.NET框架有一个专门实现这个效果的标准接口INotifyPropertyChanged(位于System.ComponentModel):        //153页(表示有错!!!)
        //public interface INotifyPropertyChanged
        //{
        //    event PropertyChangedEventHandler PropertyChanged;
        //}

        //public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);

        //public class PropertyChangedEventArgs : EventArgs
        //{
        //    public  PropertyChangedEventArgs(string propertyName);
        //    public virtual string PropertyName { get; set ; }
        //}

        //public class Foo : INotifyPropertyChanged
        //{
        //    public event PropertyChanged=delegate{}

        //    void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }

        //    private string customerName;

        //    public string CustomerName
        //    {
        //        get { return customerName; }
        //        set
        //        {
        //            if(value==customerName)return;
        //            customerName = value;
        //            RaisePropertyChanged();
        //            //编译器将上面一行代码转换为:
        //            //RaisePropertyChanged("CustomerName");
        //        }
        //    }

        //}


    class Program
    {
        



        static void Main(string[] args)
        {
        }
    }
}
