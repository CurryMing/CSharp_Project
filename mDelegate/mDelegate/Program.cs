using System;

//声明一个委托（委托：一个方法的类型（类，数组，string，接口））
delegate void TextDelegate();

class Program
{
    public static void Main(string[] args)
    {
        //实例化一个方法需要用一个方法作为参数来实例化
        //这个方法的返回值类型和参数列表必须要和委托的一样
        TextDelegate textDelegate;
        textDelegate = TextMethod;
        //textDelegate其实指向了方法TextMethod
        textDelegate();

    }

    public static void TextMethod()
    {
        Console.WriteLine("这是一个委托类型方法");
    }

}