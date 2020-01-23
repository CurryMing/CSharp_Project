using System;

//泛型在接口中的应用
interface IUSB<T>
{
    //泛型不能被子接口继承
    void Show(T t);
}
//实现类实现接口
class Mouse : IUSB<string>
{
    //实现接口方法
    public void Show(string str)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}
