using System;

//泛型在方法中的应用

class Person
{
    //声明一个方法，使用泛型
    public static void Show<T>()
    {
        //1.T只作用在当前方法中，不能作用在其他方法中
        //2.虽然不知道T是什麽类型，但是不影响在方法中的使用
        //  2.1在方法中使用：方法体，参数，返回值
        //3.方法中的泛型在调用方法的时候确定泛型的类型
        Console.WriteLine("   ");
    }
    public static void Show<T>(T t)
    {
        //如果泛型在参数中被使用，那么在调用方法的时候可以不给T赋值类型
        //这个时候，T的类型由实参的类型来决定
        Console.WriteLine("T t");
    }
    //泛型作为返回值
    //T GetComponent<T>();

}


class Program
{
    static void Main(string[] args)
    {
        //调用一个有泛型的，没参数的方法
        Person.Show<string>();
        //调用一个有参数的泛型方法
        Person.Show(10);
    }

}
