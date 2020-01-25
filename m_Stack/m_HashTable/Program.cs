using System;
using System.Collections;

//HashTable：是一种集合，存储的元素是一个键值对（key-value-Pair）
//HashTable中的元素是按照key的Hash编码来进行排序的

class Program
{
    public static void Main(string[] args)
    {
        //实例化一个HashTable
        Hashtable table = new Hashtable();

        //增
        AddOperation(table);
        //删
        RemoveOperation(table);

        //改
        UpdateOperation(table);

        //查
        SearchOperation(table);

        //其他操作
        OtherOperation(table);
    }

    public static void AddOperation(Hashtable table) 
    {
        //添加的是键值对
        
        table.Add("name", "zhangSan");
        table.Add("age", 10);
        table.Add("gender", "male");

    }
    public static void SearchOperation(Hashtable table)
    {
        //HashTable中 存储的元素类型是DictionaryEntry
        //foreach (DictionaryEntry entry in table)
        //{
        //    //
        //    object key = entry.Key;
        //    //
        //    object value = entry.Value;

        //    Console.WriteLine(key + " " + value); ;
        //}

        //获取HahTable中所有的key
        ICollection keys = table.Keys;
        //遍历刚刚获取到的所有的key
        foreach (object key in keys)
        {
            object value = table[key];
            Console.WriteLine($"{key}   {value}");
        }

    }
    public static void UpdateOperation(Hashtable table)
    {
        //通过键来修改
        table["name"] = "laowang";
        //添加
        table["height"] = 172;

        //SearchOperation(table);
    }
    public static void RemoveOperation(Hashtable table)
    {
        //通过key来删除一个键值对
        table.Remove("name");
        //SearchOperation(table);
    }
    public static void OtherOperation(Hashtable table)
    {
        //判断HashTable中是否包含指定的键
        bool result = table.Contains("age");
        Console.WriteLine(result);
    }
}