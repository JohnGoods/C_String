using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_自定义类型示范
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInChesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInChesConverter.Convert(30));   //360
            Console.WriteLine(feetToInChesConverter.Convert(100));      //1200
            Console.WriteLine(feetToInChesConverter.Convert(milesToFeetConverter.Convert(1)));      //63360
        }

        public class UnitConverter
        {
            int ratio;  //字段
            public UnitConverter(int unitRatio) //构造方法
            {
                ratio = unitRatio;
            }
            public int Convert(int unit)
            {
                return unit * ratio;   //方法
            }
        }
    }
}
