using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06枚举定义的写法
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果手动为枚举赋值，则枚举的值就是指定的值  未被指定的枚举 其值会按照差值为1来进行计算
            //但是无论是否指定，当前枚举的值和上一个枚举的值  二者之间的差值是不变的，都为1

            //若是都不指定枚举的值，则默认从0开始
            Console.WriteLine((int)Test1.Center);
            Console.WriteLine((int)Test2.cm1);
            Console.WriteLine((int)Test2.cm2);
            Console.WriteLine((int)Test2.cm3);
            Console.WriteLine((int)Test2.cm4);
            Console.ReadKey();
        }
    }

    public enum Test1
    {
        Left,
        Right,
        Center,
    }
    public enum Test2
    {
        cm1, 
      
        cm2 = 0,  
      
        cm3,
      
        cm4 = -1,
      
        cm5
    }
}
