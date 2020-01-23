using System;

/*
 * 用来做数据管理的类
 * 核心功能
 */ 

//对于这个静态类，我们没有必要去实例化一个它的对象
//只希望它给我们提供一些方法
static class BookManager
{
    //书籍容量
    private static int capcity = 10;
    //记录当前存储了多少本书
    private static int count = 0;
    //存储所有书籍的信息的数组
    public static Book[] allBooks = new Book[capcity];

    /// <summary>
    /// 新增一本书
    /// </summary>
    /// <param name="book">要添加书本的信息</param>
    /// <returns></returns>
    //增
    public static bool AddBook(Book book)
    {
        //容量已满
        if (count > capcity)
            return false;
        //存放在count位置，并将count计算器+1
        allBooks[count++] = book;
        return true;
    }

    /// <summary>
    /// 删除所有的书籍
    /// </summary>
    //删
    public static bool DeleteAll()
    {
        //让数组中的所有元素置为null
        for (int i = 0; i < count; i++)
        {
            allBooks[i] = null;
        }
        //将count置为0
        count = 0;
        return true;
    }

    /// <summary>
    /// //查找所有书本
    /// </summary>
    //查
    public static void FindAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(allBooks[i]);
        }
    }
    /// <summary>
    /// 通过书名来查找
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static Book[] FindByName(string name,Findflags findFlags)
    {
        //声明一个临时数组来存放查找到的书本
        Book[] temp = new Book[count];
        //声明一个变量来存放实际查找到的数量
        int resultCount = 0;
        //
        for (int i = 0; i < count; i++)
        {
            string findName = findFlags == Findflags.ByBookName ? allBooks[i].name : allBooks[i].author.name;
            if(findName == name)
            {
                //把这本书放到temp数组中
                temp[resultCount++] = allBooks[i];
            }
        }
        //现在，temp数组中存放的都是满足条件的书本，但是temp数组后面可能是null
        Book[] results = new Book[resultCount];
        for (int i = 0; i < resultCount; i++)
        {
            results[i] = temp[i];
        }

        return results;
    }
}
//查询标签
enum Findflags
{
    ByBookName,
    ByAuthorName
}

