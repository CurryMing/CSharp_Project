using System;
//用户类
class User
{
    //1.私有化构造方法，目的：防止用户通过new的方法来多次实例化对象
    private User()
    {

    }
    //2.提供一个私有的静态的当前对象
    private static User instance;
    //3.提供一个public权限的方法，用来返回一个类的对象
    public static User CurrentUser()
    {
        //什么时候需要什么时候进行实例化
        if (instance == null) instance = new User();

        return instance; 
    }
    //
    public static User Current
    {
        get { return instance; }
    }
    //public：希望在外界也能访问到这个字段
    //static：因为没有User对象，外界只能通过类来直接获取
    //readonly：不希望外界再修改instance的值
    public readonly static User Instance = new User();

}


class Program
{
    static void Main(string[] args)
    {
        //实例化一个User对象
        User xiaoming = User.Instance;
        User laowang = User.Instance;
        
        
        Console.WriteLine(xiaoming == laowang);











    }
}

