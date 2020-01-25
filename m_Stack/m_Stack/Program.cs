using System;
using System.Collections;
//Stack,Queue
// 栈     队列
//区别：
//栈：先进后出
//队列：先进先出
class Program
{
    public static void Main(string[] args)
    {
        //栈操作
        //StackOperation();

        //队列操作
        QueueOperation();

    }

    static void StackOperation()
    {
        //实例化一个栈
        Stack s = new Stack();

        //将元素压栈
        s.Push("Hello World");
        s.Push("A");
        s.Push("B");
        s.Push("C");

        //获取栈顶的元素
        object ele = s.Peek();
        //Console.WriteLine(ele);

        //将栈顶元素出栈,返回刚刚出栈的元素
        object e = s.Pop();

        //遍历集合
        foreach (object obj in s)
        {
            Console.WriteLine(obj);
        }
    }

    static void QueueOperation()
    {
        //实例化一个队列
        Queue q = new Queue();
        q.Enqueue("Hello World");
        q.Enqueue("A");
        q.Enqueue("B");
        q.Enqueue("C");

        //获取排在队列 首位的元素
        object ele = q.Peek();
        //Console.WriteLine(ele);
        
        //将队首元素移除，返回值为刚刚移除的元素
        object e = q.Dequeue();

        foreach (object obj in q)
        {
            Console.WriteLine(obj);
        }
    }

}
