using System;

//泛型
//可以将类型在类，接口，方法中传递
//类似于传参
//泛型在类中的应用
class Person<T>
{
    //在类中不知道T是什麽类型，但是不会影响使用T
    public T t;

}
//泛型的特点
//1.在一个命名空间中，可以存在相同名字的类，但是类的泛型必须不同
class Person
{

}
//2.泛型只可以用在当前类中，不能被继承
class Taidi : Dog<int, double, string>
{

}


//在类中，可以有多个泛型
class Dog<T, M, D>
{
    public static M m;
    public D d;
}
public class Program
{
    public static void Main(string[] args)
    {
        Person<string> xiaoming = new Person<string>();
        xiaoming.t = "xiaoming";

        Person<int> xaioli = new Person<int>();
        xaioli.t = 1;

        Dog<int, double, string>.m = 3.14;

        //泛型在继承中的应用
        Taidi taidi = new Taidi();
        taidi.d = "TD";
    }
}

