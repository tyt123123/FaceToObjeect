using  System.Collections.Generic;
using System.IO;
namespace GC
{
    /// <summary>
    /// GC消耗性能
    /// GC只负责堆heap上的垃圾回收，值类型（栈stack）有系统自动释放
    /// C#使用分代算法回收内存
    /// 分为欸0，1，2带内存，新分配的对象分配与0代，每次分配可能会触发GC（0代满时）
    /// 大对象（>83KB）默认 2 带内存
    /// 判断为垃圾（标记为不可达）的额直接删除，可达对象搬迁到 1 代内存，整理空间并修改引用地址
    ///（ 1 带内存满时会连带 0 代内存一起触发GC。1代对象移到2代，同理，2代满后012代全触发） 
    /// </summary>
    class MyClass
    {
        MyClass()
        {
        }

        //构造函数
        ~MyClass()
        {
        }
        //析构函数，引用类型堆内存回收时调用,当垃圾真正被回收时才会调用的
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            System.GC.Collect();
            //手动GC，一般时在加载场景时调用
        }
    }
}