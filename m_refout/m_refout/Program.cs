using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int x = 5;
        int y = 8;
        Console.WriteLine("before");
        Console.WriteLine("a: " + a);
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);

        SwapNumber(ref x, ref y);
        ChangeNumber(out a);
        Console.WriteLine("after");
        Console.WriteLine("a: " + a);
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
    }

    static void ChangeNumber(out int a)
    {
        //Console.WriteLine(a);
        a = 20;
    }
    static void SwapNumber(ref int a,ref int b)
    {
        //Console.WriteLine(a + b);
        //a = a ^ b;
        //b = a ^ b;
        //a = a ^ b;
    }

}

