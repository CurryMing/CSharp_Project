using System;


//英雄类
class Hero
{
    public string name;
    public string kind;
    public int hp;
    public int mp;
}

class HeroManager
{
    //单例模式，确保获取同一个对象

    public static readonly HeroManager manager = new HeroManager();

    private HeroManager() { }

    //所有要管理的英雄
    public Hero[] allHeros = new Hero[5];

    //用来记录当前存储了多少个英雄
    private int count = 0;

    public bool AddHero(Hero hero)
    {
        //判断是否已经存满了
        if (count >= 5) return false;
        //
        allHeros[count++] = hero;
        return true;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("请输入英雄的名字:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入英雄的种类:");
            string kind = Console.ReadLine();
            Console.WriteLine("请输入英雄的hp:");
            int hp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入英雄的mp:");
            int mp = Convert.ToInt32(Console.ReadLine());
            Hero hero = new Hero();

            hero.name = name;
            hero.kind = kind;
            hero.hp = hp;
            hero.mp = mp;

            //获取英雄管理器
            HeroManager manager = HeroManager.manager;
            bool result = manager.AddHero(hero);
            if (result)
            {
                Console.WriteLine("添加成功");
            }
            else
            {
                Console.WriteLine("添加失败,容量已满");
            }
        } while (true);
    }
}