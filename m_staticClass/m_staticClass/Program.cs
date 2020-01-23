using System;

public static class Arrays
{
    public static int a;
    public static int A
    {
        set { a = value; }
    }
    static Arrays() { }
    //用途：用来设计工具类
    public static int Plus(int x,int y)
    {
        return x + y;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine(Arrays.Plus(a, b));

    }
}

