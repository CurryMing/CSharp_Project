using System;

class Person
{
    private uint age;
    //给外界提供来访问这个age字段的方法
    #region
    public void SetAge(uint newAge)
    {
        if (newAge >= 120) return;
        age = newAge;
    }
    public uint GetAge()
    {
        return age;
    }
    #endregion
    //通过属性和属性访问器来实现
    //一个属性中至少要有一个访问器
    public uint Age
    {
        //写操作
        set 
        {
            //在属性访问器中使用value来表示外界传的值
            if (value >= 150) return;
            age = value;
        }
        //读操作
        get { return age; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person xiaoming = new Person();
        //xiaoming.SetAge(10);
        //uint age = xiaoming.GetAge();
        uint age = Convert.ToUInt32(Console.ReadLine());
        
        xiaoming.Age = age;
        Console.WriteLine(xiaoming.Age); 
    }
}

