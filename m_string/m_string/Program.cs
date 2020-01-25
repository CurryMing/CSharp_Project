using System;

class Program
{
    static void Main(string[] args)
    {
        char[] c = { 'u', 'n', 'i', 't', 'y' };

        //字符串类
        //字符串实例化
        string str = new string(c);//unity

        //和另一个字符串比较
        int result = "unity".CompareTo("Unity");
        //Console.WriteLine(result);

        //判断是否包含
        bool isC = "helloworld".Contains("c");
        //Console.WriteLine(isC);

        string[] re = "unity,google,baidu,alibaba".Split(',');
        foreach (string item in re)
        {
            Console.WriteLine(item);
        }
    }
}

