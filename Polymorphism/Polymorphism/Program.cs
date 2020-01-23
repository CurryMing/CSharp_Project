using System;

class Animal
{
    public string name;
    public int age;
}
class Dog : Animal
{
    public string gender;
}
class HaShiQi : Dog
{
    public string kind;
}

class Woif : Animal { }
class Tiger : Animal { }
class Lion : Animal { }
class Panda : Animal { }
class Monkey : Animal { }
class Snake : Animal { }

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        //向上转型
        Animal a = d;
        //向下转型
        //Dog dd = (Dog)new Animal();
        Dog dd = new Animal() as Dog;

        Dog e = a as Dog;
        //Console.WriteLine(e);
        RecordAnimal(new HaShiQi());

        //实例化一个Dog对象
        Dog ddd = new Dog();
        d.name = "";
        d.age = 10;

        Animal aa = d;
        aa.name = "ss";
        aa.age = 10;
        //aa.gender = "";不行

        //向下转型h可能为null
        //HaShiQi h = aa as HaShiQi;
        //h.kind = "";
    }
    //Animal a = new Monkey();
    public static void RecordAnimal(Animal a)
    {
        //在做向下转型前，一定要先用is判断下类型
        if(a is HaShiQi)
        {
            Console.WriteLine("本园不收哈士奇！");
        }
    }
}

