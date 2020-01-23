using System;

//设计一个技能池（存放所有技能）
public static class Skills
{
    public static void GaiLunQ()
    {
        Console.WriteLine("致命打击");
    }
    public static void GaiLunW()
    {
        Console.WriteLine("勇气");
    }
    public static void GaiLunE()
    {
        Console.WriteLine("审判");
    }
    public static void GaiLunR()
    {
        Console.WriteLine("德玛西亚正义");
    }

    public static void ManWangQ()
    {
        Console.WriteLine("嗜血杀戮");
    }
    public static void ManWangW()
    {
        Console.WriteLine("藐视");
    }
    public static void ManWangE()
    {
        Console.WriteLine("旋风斩");
    }
    public static void ManWangR()
    {
        Console.WriteLine("无尽怒火");
    }
}

public delegate void SkillDelegate();

public class Hero
{
    public SkillDelegate q;
}

public class Program
{
    public static void Main(string[] args)
    {
        //实例化一个Hero对象
        Hero gaiLun = new Hero();
        gaiLun.q = Skills.GaiLunQ;  //q其实指向了方法GaiLunQ

        Hero manWang = new Hero();
        manWang.q = Skills.ManWangQ;

        gaiLun.q();
        manWang.q();
    }
}









