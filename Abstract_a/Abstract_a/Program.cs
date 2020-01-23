using System;
//
class Am_ { }
//抽象类
abstract class Animal : Am_   //抽象类可以继承自其他类
{
    //1.不能实例化对象
    //2.可以创建静态类成员，也可以创建非静态类成员
    //3.抽象类可以被继承
    public string name;
    public static void Bark() { }
    public Animal() { }
    //1.抽象方法只有声明没有实现
    //2.抽象方法只能写在抽象类中
    public abstract void Show();
}
class Dog : Animal
{
    //通过重写实现父类中的抽象方法
    public override void Show()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}

abstract class A
{
    public abstract void AA();
}
abstract class B : A
{
    public abstract void BB();
}
abstract class C : B
{
    public override void BB()
    {
    }
    public abstract void CC();
}
//如果一个非抽象类继承自一个抽象类，那么子类必须实现父类中所有的抽象方法
//class D : C
//{

//}
