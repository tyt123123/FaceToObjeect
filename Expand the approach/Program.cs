using System;

namespace Expand_the_approach
{
    #region 实例

    public  class Tools0
    {
        public void Create()
        {
            int i= 10;
        }
    }

    public class Functions
    {
       int i= 0;

       public void Fun1()
       {
           Console.WriteLine("123");
       }

       public void Fun2()
       {
           Console.WriteLine("456");
       }
    }
    
    public static class Tools
    {
        public static void Speak(this int value)
        {
            //拓展方法的逻辑
            Console.WriteLine("拓展逻辑"+value);
        }

        public static void Fun3(this Functions functions)
        {
            Console.WriteLine(" 为FUN拓展的方法");
        }
    }

    public static class Tools1
    {
        public static void Speak1(this Tools0 value)
        {
            int arg = 20;
            Console.WriteLine(arg+$"{value}");
        }
    }

    #endregion

    internal class Program
    {
        #region 拓展方法概念

        /// <summary>
        /// 运算符重载时，条件运算符要成对出现
        /// 为现有{非静态}的变量类型添加新方法
        /// 特点
        /// 1拓展方法一定写在静态类中，一定是个静态函数
        /// 2拓展方法可以重名，但必须要参数重载，否责还是用原来的
        /// </summary>
        /// <param name="args"></param>

        #endregion

        #region 语法

        //访问符 static 返回值 （this 拓展类名 参数名。。。。。。）

        #endregion

        public static void Main(string[] args)
        {
            #region 使用

            int i = 10;
            i.Speak();
            Tools0 tools0 = new Tools0();
            tools0.Speak1();
            Functions functions = new Functions();
            functions.Fun3();

            #endregion
        }
    }
}