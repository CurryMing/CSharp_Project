using System;
using System.Collections.Generic;
//Dictionary:存储的是键值对


class Program
{
    static void Main(string[] args)
    {
        //实例化一个Dictionary对象
        //Dictionary需要去指定key和value的类型
        Dictionary<string, string> dict = new Dictionary<string, string>();

        //增
        AddOperation(dict);

        //删
        RemoveOperation(dict);

        //改
        UpdateOperation(dict);

        //查
        SearchOperation(dict);
    }

    static void AddOperation(Dictionary<string,string> dict)
    {
        dict.Add("01", "Unity");
        dict.Add("02", "Google");
        dict.Add("03", "VS");
    }
    static void RemoveOperation(Dictionary<string, string> dict)
    {
        dict.Remove("03");
         
    }
    static void UpdateOperation(Dictionary<string, string> dict)
    {
        dict["03"] = "Vsual Studio";
    }
    static void SearchOperation(Dictionary<string, string> dict)
    {
        //直接遍历Dictionary
        //Dictionary<>中的元素类型是KeyValuePair<>
        //foreach (object value in dict)
        //{
        //    Console.WriteLine(value);
        //}
        
        //foreach (KeyValuePair<string,string> pair in dict)
        //{
        //    //获取Key
        //    string key = pair.Key;
        //    //获取Value
        //    string value = pair.Value;
        //    Console.WriteLine($"{key}   {value}");
        //}

        //获取Dictionary中所有的key
        ICollection<string> keys = dict.Keys;
        foreach (string key in keys)
        {
            //通过Key获取value
            string value = dict[key];

            Console.WriteLine($"{key}   {value}");
        }
    
    
    }
}


