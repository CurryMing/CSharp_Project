using System;

class Animal 
{
    public void NoShow() 
    {
        Console.WriteLine("Animal NoShow");
    }
}
class Cat : Animal 
{
    //方法的隐藏
    public new void NoShow()
    {
        Console.WriteLine("Cat NoShow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Cat cat = new Cat();
        //cat.NoShow();
        Animal a = new Cat();
        a.NoShow();

    }
}

