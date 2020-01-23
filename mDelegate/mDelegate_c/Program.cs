using System;

public delegate int CalculateMethod(int a, int b);

public class Program
{
    public static void Main(string[] args)
    {
        //实例化一个委托并为其赋值
        CalculateMethod method = Plus;
        //让用户从控制台输入两个数,赋值给x，y
        //需求：
        //若 x > y,x - y,否则 x + y
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
        {
            method = Minus;
        }
        else
        {
            method = Plus;
        }
        int result = method(x, y);
        Console.WriteLine(result);
    }

    public static int Plus(int a,int b)
    {
        return a + b;
    }
    public static int Minus(int a,int b)
    {
        return a - b;
    }
}
