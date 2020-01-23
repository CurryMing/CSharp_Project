using System;
public delegate void TextDelegate01();
public delegate int TextDelegate02(int a,int b);
public class Program
{
    public static void Main(string[] args)
    {
        //Lambda表达式
        //=>Lambda运算符，读作gose to
        TextDelegate01 method01 = () =>
        {

        };
        TextDelegate02 method02 = (int x,int y) =>
        {
            return x + y;
        };
        //简化01
        method02 = (int x, int y) => x + y;
        //简化02
        method02 = (x, y) => x + y;
    }
}
