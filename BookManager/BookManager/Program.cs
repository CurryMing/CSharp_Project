using System;

class Program
{
    public static void Main(string[] args)
    {
        string name = "西游记";
        double price = 199.9;

        string authorName = "吴承恩";
        int authorAge = 20;
        int authorGender = 1;

        Book book01 = new Book(name, authorName, authorAge, authorGender, price);
        bool addResult = BookManager.AddBook(book01);
        Book[] result = BookManager.FindByName("西游记", Findflags.ByBookName);
        foreach (Book book in result)
        {
            Console.WriteLine(book);
        }
    }
}

