using System;

delegate void TextDelegate();

public class Program
{
    public static void Main(string[] args)
    {
        //组合委托
        TextDelegate method = methodA;
        method += methodB;
        method();
    }

    public static void methodA()
    {
        Console.WriteLine("methodA was Invoked");
    }
    public static void methodB()
    {
        Console.WriteLine("methodB was Invoked");
    }
}
