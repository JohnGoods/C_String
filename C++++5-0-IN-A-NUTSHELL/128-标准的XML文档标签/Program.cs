using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128_标准的XML文档标签
{
    //VS和文档生成器支持的标准XML标签:

    ///<summary></summary>
    //指定IntelliSense为类型或成员的工具提示信息;

    /// <remarks></remarks>>   
    //标签间的文本可用于描述类型或成员.文档生成器会获取这些信息,然后将它合并到类型或成员的描述信息中.

    // <param name="name"></param>>
    //解析方法的参数:

    /// <returns></returns>>  
    //解释方法的返回值：

    /// <exception cref="type"></exception>>  
    //列出方法可能抛出的异常(cref指的是异常类型).

    /// <permission cref="type"></permission>>
    //指定文档记录的类型成员所要求的IPermission类型

    /// <example></example>>      
    //给出一个实例供文档生成器使用,通常包含描述信息和源代码(源代码一般位于<C>或者<code>标签内)
    
    /// <c></c>>   
    // 指定一个内联代码片段.这个标签通常用在<example>代码块内

    ///<code></code>    
    //指定一个多行代码实例.这个标签通常用在<example>代码块内

    /// <see cref="member"/>></see>>   
    //将一个内联交叉引用插入到另一个类型或成员中.HTML文档生成器一般会将它转换为一个超链接.如果该类型或成员名是无效的,那么编译器会产生一条警告信息.如果要引用泛型类型,那么要使用花括号,例如
    //cref="Foo{T,U}"

    /// <seealso cref="member"></seealso>
    //交叉引用另一个类型或成员.文档生成器一般会将它写入页面底部一个单独的"See Also" 小节中

    /// <paramref name=""/>>
    //引用<sunmmary>或<remarks>标签内的一个参数

    //<list>
    /// <list type="[bullet|number|table]">
    /// <listheader>
    /// <term></term>
    /// </listheader>>
    /// <item>
    /// <term></term>
    /// <description></description>
    /// </item>
    /// </list>
    //指示文档生成器生成一个航母符号,编号或表格式的列表

    /// <para></para>>
    //指示文档生成器将制定内容单独作为一个段落

    /// <include file='' path='[@name=""]'/>
    //合并包含文档的一个外部XML文件.path属性表示一个用于查询该文件中某个特定元素的XPath查询.

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
