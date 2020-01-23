using System;

class Animal
{
    public virtual void Show()
    {
        Console.WriteLine("Animal Show");
    }

}
class Cat : Animal
{
    public override void Show()
    {
        Console.WriteLine("Cat Show");
    }
}
class KaFei : Cat
{
    public override void Show()
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        //cat.Show();

        Animal a = new Cat();
        a.Show();
    }
}

