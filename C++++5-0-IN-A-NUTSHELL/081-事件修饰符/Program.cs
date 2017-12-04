using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_事件修饰符
{  
    class Program
    {
        //事件可以是virtual(虚拟的),override(重载的),abstract(抽象的),sealed(密封的),static(静态).
        public class Foo
        {
            public static event EventHandler<EventArgs> StaticEvent;
            public virtual event EventHandler<EventArgs> VirtualEvent;
        }
    }
}
