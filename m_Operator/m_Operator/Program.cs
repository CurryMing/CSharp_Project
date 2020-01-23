using System;

public struct Vector2
{
    public double x;
    public double y;

    public Vector2(double a, double b)
    {
        this.x = a;
        this.y = b;
    }

    //运算符重载，使+号具有新的功能
    //可以实现两个Point对象直接相加，得到一个新的点
    //+
    public static Vector2 operator +(Vector2 p1, Vector2 p2)
    {
        return new Vector2(p1.x + p2.x, p1.y + p2.y);
    }
    public static Vector2 operator +(Vector2 p1, int a)
    {
        return new Vector2(p1.x + a, p1.y + a);
    }
    //*
    public static Vector2 operator *(Vector2 p1, Vector2 p2)
    {
        return new Vector2(p1.x + p2.x, p1.y * p2.y);
    }
    //-
    public static Vector2 operator -(Vector2 p1, Vector2 p2)
    {
        return new Vector2(p1.x + p2.x, p1.y - p2.y);
    }
    public static Vector2 operator -(Vector2 p1)
    {
        return new Vector2(-p1.x,-p1.y);
    }
    //&(返回值不一定是 bool)
    public static double operator &(Vector2 v1,int a)
    {
        return v1.x + a; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector2 p1 = new Vector2(1, 2);
        Vector2 p2 = new Vector2(3, 4);
        Vector2 p3 = p1 - p2;
        Vector2 p4 = -p1;
        //Console.WriteLine(p3);
        //Console.WriteLine(p3.x);
        //Console.WriteLine(p3.y);
        Console.WriteLine(p4.x);
        Console.WriteLine(p4.y);
    }
}

