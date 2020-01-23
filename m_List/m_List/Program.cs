using System;
using System.Collections.Generic;

//List中只能指定同一个类型的
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        //增
        AddOperation(list);
        //删
        RemoveOperation(list);
        //改
        UpdateOperation(list);
        //
        OtherOperation(list);
    }

    public static void AddOperation(List<int> list)
    {
        list.Add(1);
        list.Add(2);
        list.AddRange(new int[] { 3, 4, 5 });
        list.Insert(3, 5);

        list.InsertRange(4, new int[] { 5, 5, 5 });
    }
    public static void RemoveOperation(List<int> list)
    {
        //1.
        bool result = list.Remove(1);
        //2.
        list.RemoveAt(2);
        //3.
        //list.RemoveRange(3, 3);
        //4.删除所有满足条件的项
        list.RemoveAll(num => num == 5); 
    }
    /*public static bool Method(int obj)
    {
        return obj == 5;
    }*/
    public static void UpdateOperation(List<int> list)
    {
        //1.通过下标
        list[0] = 18;
    }
    public static void OtherOperation(List<int> list)
    {
        //1.获取一个集合中的子集
        List<int> sub = list.GetRange(1, 2);
        
        //2.Exists:判断集合中是否存在满足指定条件的元素（以xx结尾的元素）
        //  Contains:判断集合中是否包含指定的元素
        bool result = list.Exists(num => num == 1);
        //Console.WriteLine(result);
        
        //查找集合中的第一个奇数
        int n = list.Find(num => num % 2 != 0);
        //Console.WriteLine(n);
        
        //查找最后一个满足条件的元素
        list.FindLast(num => num % 2 != 0);
        
        //
        List<int> lt = list.FindAll(num => num % 2 != 0);
        
        //查询第一个满足条件的元素的下标
        int index = list.FindIndex(num => num % 2 != 0);
        //Console.WriteLine(index);
        
        //查找集合中最后一个满足条件的元素的下标
        list.FindLastIndex(num => num % 2 != 0);

        //移除所有满足条件的元素
        list.RemoveAll(num => num % 2 != 0);

        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }
}

