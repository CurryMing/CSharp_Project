using System;



//异常处理 
/*
 * try
 * {
 *      //可能会异常的代码
 *      1.一个try可以匹配多个catch来捕获多种异常
 *      2.如果有多个catch
 *          2.1
 * }
 * catch
 * {
 *      //这里捕获try中肯出现的异常
 * }
 * finally
 * {
 *      //无论程序有没有异常，finally中的代码始终会执行
 *      
 * }
 * 
 * 
*/
class Program
{
    static void Main(string[] args)
    {
        #region
        ////在C#中，所有的异常都是Exception的子类
        //try
        //{
        //    int[] arr = new int[3];
        //    arr[4] = 01;
        //}
        ////来捕获IndexOutOfRangeException这个异常
        //catch (IndexOutOfRangeException e)
        //{
        //    Console.WriteLine("发生数组越界的异常"); ;
        //}
        ////
        //catch(DivideByZeroException d)
        //{
        //    Console.WriteLine("发生了除0异常");
        //}
        //Console.WriteLine("程序结束了！");
        #endregion

        try
        {
            Person.ScoreExceptionDemo();
        }
        catch(ScoreException exc)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exc.Message);
        }
        
        //double a = 10.0 / 0;
        //Console.WriteLine(a);
    }
}

//自定义异常
class ScoreException : Exception
{
    //如果希望自定义的异常有描述的信息，只需要有一个有参构造即可
    public ScoreException(string message) : base(message)
    {

    }


}
class Person
{
    public static void ScoreExceptionDemo()
    {
        //
        ScoreException exception = new ScoreException("异常");
        //抛出异常
        throw exception;
    
    }
}

