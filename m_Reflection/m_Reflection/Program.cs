using System;
using System.Reflection;
//反射，可以通过类名、成员的名字来进行对象的实例化、操作类成员

class Person
{
    #region
    public int a;
    private int b;
    public static int c;
    private static int d;

    
    private Person()
    {
        Console.WriteLine("Person类无参的构造方法被调用");
    }
    private Person(int a, double b, string c)
    {
        Console.WriteLine("有参构造方法被调用");
    }
    #endregion

    public void ShowA() { }
    private void ShowB() { }
    public static void ShowC() { }
    private static void ShowD() { }
    public int Show(int a,double b)
    {
        this.a = a;
        return this.a;
    }
    private double Show(double a,int b)
    {
        this.b = b;
        return this.b;
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region
        //实例化一个Person对象
        Type t = Type.GetType("Person");

        //默认会使用public权限的无参构造方法来实例化
        //如果为true，表示可以匹配任何权限的无参构造方法
        //object obj = Activator.CreateInstance(t,true);

        //实例化一个对象，通过public权限的有参构造方法来实现的
        //object obj = Activator.CreateInstance(t, 1, 3.1, "Unity");

        //实例化一个对象，通过非public权限的有参构造方法来实现的
        //BindingFlags:要访问的方法或字段的权限描述，必须要同时具备两个描述
        //1.要有要访问的成员的访问权限描述
        //2.要有访问的成员的归属                                                          非静态
        object obj = Activator.CreateInstance(t, BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { 1, 3.1, "Untiy" }, null);
        #endregion

        #region
        //通过反射访问字段
        //1.访问a(public，非静态)
        FieldInfo a = t.GetField("a");
        a.SetValue(obj, 1);//给obj对象的a字段进行赋值
        object aa = a.GetValue(obj);//获取obj对象a的值
        Console.WriteLine(aa);
        
        //2.访问b（private，非静态（对象访问））
        FieldInfo b = t.GetField("b", BindingFlags.NonPublic | BindingFlags.Instance);
        b.SetValue(obj, 2);
        object bb = b.GetValue(obj);

        //3.访问c（public，静态）
        FieldInfo c = t.GetField("c", BindingFlags.Public | BindingFlags.Static);
        c.SetValue(null, 3);//如果要访问的是一个静态(类中)的成员，访问的主体是null
        object cc = c.GetValue(null);

        //4.访问d（private，静态）
        FieldInfo d = t.GetField("d", BindingFlags.NonPublic | BindingFlags.Static);
        d.SetValue(null, 4);//如果要访问的是一个静态(类中)的成员，访问的主体是null
        object dd = d.GetValue(null);
        #endregion
        
        //通过反射访问方法
        //1.获取没有参数的方法
        MethodInfo methodd = t.GetMethod("ShowD", BindingFlags.NonPublic | BindingFlags.Static);
        //调用方法(1参数.谁在调用方法 2参数调用的方法的实参列表)
        methodd.Invoke(null, null);

        //2.获取有参数有重载的方法
        MethodInfo method1 = t.GetMethod("Show", BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(int), typeof(double) }, null);

        //第二个参数是实参列表
        //Invoke方法的返回值，就是method1方法的返回值
        object result = method1.Invoke(obj, new object[] { 1, 3.13 });
        Console.WriteLine(result);  
                
    }
}

