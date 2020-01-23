using System;
/*
 *数据模型 
 */
class Book
{
    public string name;
    public double price;
    public Author author;

    public Book(string name,string authorName,int authorAge,int authorGender,double price)
    {
        this.name = name;
        this.price = price;
        this.author = new Author(authorName, authorAge, authorGender);
    }

    //摘要:
    //     返回表示当前对象的字符串。
    //
    // 返回结果:
    //     表示当前对象的字符串。
    //在使用一个对象的时候会自动调用
    public override string ToString()
    {
        return "{\n\t书名：" + name + "\n\t售价：" + price + "\n\t作者：{" + author;
    }
}

enum Gender { Male, Female }

class Author
{
    public string name;
    public int age;
    public Gender gender;

    //构造方法
    public Author(string name,int age,int gender)
    {
        this.name = name;
        this.age = age;
        this.gender = (Gender)gender;
    }

    public override string ToString()
    {
        string g = gender == Gender.Male ? "男" : "女";

        return "\n\t\t名字：" + name + "\n\t\t年龄：" +age + "\n\t\t性别：" + g + "\n\t}\n}";
    }
}

