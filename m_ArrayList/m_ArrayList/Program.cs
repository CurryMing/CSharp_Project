using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        //增
        AddOperation(list);
        //删
        RemoveOperation(list);
        //改
        UpdateOperation(list);
        //查
        SearchOperation(list);
        //
        OtherOperation(list);
    }
    static void AddOperation(ArrayList list)
    {
        list.Add(1);
        list.Add("string");
        list.Add(true);
        list.Add(3.14);

        list.AddRange(new int[] { 1, 2, 3 });
        list.Add(new int[] { 1, 2, 3 });

        //插入
        list.Insert(0, "hello world");
        //批量插入
        list.InsertRange(0, new bool[] { false, false, false });
        //Console.WriteLine(list.Count);
    }
    static void RemoveOperation(ArrayList list)
    {
        //1.移除指定的第一个元素
        list.Remove(1);
        //2.移除指定下标的元素
        list.RemoveAt(4);
        //3.给定一个下标和长度，确定一个范围，移除这个范围内的元素
        list.RemoveRange(3, 2);
    }
    static void UpdateOperation(ArrayList list)
    {
        //1.通过下标来修改元素
        list[2] = false;
        //2.批量修改元素
        list.SetRange(0, new string[] { "a", "b", "c", "d" });
    }
    static void SearchOperation(ArrayList list)
    {
        //1.通过遍历下标（for foreach）
        //for(int i = 0; i < list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //}
        //（1）.注意类型（object类型）
        //（2）.不要在foreach中修改集合
        //foreach (object obj in list)
        //{
        //    Console.WriteLine(obj);
        //}
        //2.通过枚举器/迭代器遍历
        IEnumerator em = list.GetEnumerator();
            //枚举器一开始指向-1位
        while (em.MoveNext())
        {
            object obj = em.Current;
            Console.WriteLine(obj);
        }
        //3.查询某个元素对应的下标
        int index = list.IndexOf(3);//查询某个元素第一次出现的下标
        int index1 = list.LastIndexOf(3);//查询某个元素最后一次出现的下标
        int index2 = list.BinarySearch(3);//使用二分查找查询某个元素的下标（数组需要是已经排序好的）

    }
    static void OtherOperation(ArrayList list)
    {
        //1.集合排序，默认是升序排序的
        list.Sort();
        //2.集合倒叙
        list.Reverse();
        //3.判断集合是否包含某个元素
        list.Contains(3);
        //4.将一个集合的元素拷贝到另一个集合中
        ArrayList newList = new ArrayList();
        newList.AddRange(list);
        //5.将一个集合的元素拷贝到另一个数组中
        object[] newObj = new object[10];
        list.CopyTo(newObj);
    }
}

