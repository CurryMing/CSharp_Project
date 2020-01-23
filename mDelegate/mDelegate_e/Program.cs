using System;

//无返回值，无参数
public delegate void TextDelegate01();
//有返回值，有参数
public delegate int TextDelegate02(int a, int b);


public class Program
{
    public static void Main(string[] args)
    {
        //匿名方法
        //可以用delegate来代替方法名
        TextDelegate01 method01 = delegate ()
        {
            Console.WriteLine("HelloWorld");
        };
        method01();

        TextDelegate02 method02 = delegate (int x,int y)
        {
            return x + y;
        };
        int result = method02(5, 4);
    }
}
