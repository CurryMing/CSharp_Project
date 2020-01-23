using System;

public enum Season : long
{
    spring = 2,//0
    summer,//3 //1
    autumn,//4 //2
    winter //5 //3    //可以修改为其他 整形
}

public class Program
{


    public static void Main(string[] args)
    {
        //如何使用一个枚举
        Season s = Season.autumn;
        //Season s1 = (Season)1;
        //Console.WriteLine((int)s);

        //枚举一般情况下结合 switch-case 使用
        switch (s)
        {
            case Season.spring:
                Console.WriteLine("春");
                break;
            case Season.summer:
                Console.WriteLine("夏");
                break;
            case Season.autumn:
                Console.WriteLine("秋");
                break;
            case Season.winter:
                Console.WriteLine("冬");
                break;
        }
    }

}
