using System;

//结构体
//是在栈上开辟空间
//结构体是值类型，不是引用类型
public struct Point
{
    //字段
    public double x;
    public double y;
    public static int a;
    //属性
    public double X
    {
        set{this.x = value;}
        get{return x;}
    }
    //方法
    public void Text()
    {

    }
    //静态构造
    static Point()
    {

    }
    //构造方法
    public Point(double x,double y)
    {
        this.x = x;
        this.y = y;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //实例化一个对象
        Point p = new Point();
        p.x = 10;
        p.y = 20;
        Change(ref p);
        Console.WriteLine(p.x + "  " + p.y);//10  20

        int a = 10;
        Change(a);
        //Console.WriteLine(a);  //10
    }

    public static void Change(int x)
    {
        x = 20;
    }

    public static void Change(ref Point p)
    {
        p.x = 100;
        p.y = 200;
    }
}