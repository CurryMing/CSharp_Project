using System;
using System.Collections.Generic;//嵌套
using Space0;
using Space1;
using Space1.Space1;
using Space1.Space1.Space1;

namespace Space0
{
    class A { }
    class B { }
}
namespace Space0 
{
    
}


//命名空间可以嵌套
namespace Space1
{
    class S { }
    class A { }
    //名字：Space1.Space1
    namespace Space1
    {
        namespace Space1 
        {
            class SSS { }
        }
        class A { }
        class SS { }
    }
}

namespace Space1.Space1
{
    //class A { }
}

namespace Space2
{
    class A { }
    class Program
    {
        public static void Main(string[] args)
        {
            //实例化一个类
            //默认会使用当前命名空间中的类
            A a = new A();
            //使用Space0中的A
            Space0.A a0 = new Space0.A();
            //可以简化
            Space0.B b = new Space0.B();

            S s = new S();
            SS ss = new SS();
            SSS sss = new SSS();
            

        }
    }
}

