using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//正则表达式：就是用来判断某一个字符串是否匹配一定的格式
//没有代码提示，就是一个字符串

class Program
{
    static void Main(string[] args)
    {
        string num = "";
        //^:匹配一个字符串的开头
        //$:匹配一个字符串的结尾

        //[]:匹配一位字符，这一位字符可以是这个中括号[]中的任何一个
        //[1-9]:[a-zA-Z]:这一位字符可取的范围
        //[^1-9]:[1-9]之外的任何字符

        //{m}:前面的一位字符连续出现了m次
        //{m,}:前面的一位字符至少连续出现了m次
        //{m,n}:前面一位字符出现了[m,n]次

        //+：前面的一位字符连续出现了1次或多次
        //*：前面的一位字符连续出现了0次或多次
        //？：前面的一位字符连续出现了0次或1次

        //\d:[0-9]
        //\D:[^0-9]

        //.:通配符，可以匹配任意字符

        #region
        //while (true)
        //{
        //    num = Console.ReadLine();
        //    //bool result = Regex.IsMatch(num, "@^[1-9]\d{4,10}$");
        //    //bool result = CheckQQNumber(num);
        //    //以h开头，以o结尾
        //    string pattern = "^hel+o$";
        //    Regex r = new Regex(pattern);
        //    bool result = r.IsMatch(num);

        //    if (result)
        //        Console.WriteLine("合法");
        //    else
        //        Console.WriteLine("不合法");
        //}
        #endregion
        while (true)
        {
            num = Console.ReadLine();
            string result = CheckPhone(num);
            //if (result)
                Console.WriteLine(result);
            //else
                //Console.WriteLine("不合法");
        }
    }

    //1.判断一个QQ号是否合法
    public static bool CheckQQNumber(string QQ)
    {
        //QQ:
        //1.纯数字
        //2.不能以0开头
        //3.长度范围:[5,11]
        bool isNumber = true;
        for (int i = 0; i < QQ.Length; i++)
        {
            if (!(QQ[i] >= '0' && QQ[i] <= '9'))
            {
                isNumber = false;
                break;
            }
        }

        bool isZeroStart = !(QQ[0] == '0');

        bool length = QQ.Length >= 5 && QQ.Length <= 11;

        return isNumber && isZeroStart && length;
    }
    
    //2.判断手机号
    public static bool CheckPhoneNumber(string num)
    {
        //正则
        string pattern = "^1[34578]\\d{9}$";
        return Regex.IsMatch(num, pattern);
    }

    //3.判断邮箱
    public static bool CheckEmail(string email)
    {
        string pattern = "^[0-9a-zA-Z_\\.]+@[0-9a-zA-Z]+\\.com$";

        return Regex.IsMatch(email, pattern);
    }
     
    //4.屏蔽手机号中间四位
    public static string CheckPhone(string phone)
    {
        //分组：()表示一个分组

        string pattern = "^(1[34578]\\d)(\\d{4})(\\d{4})$";
        //获取每一个分组的字符串
        //获取到一个匹配的结果
        Match match = Regex.Match(phone, pattern);
        //获取到所有的分组
        GroupCollection groups = match.Groups;
        string group1 = groups[1].Value;
        string group2 = groups[2].Value;
        string group3 = groups[3].Value;
        return group1 + "****" + group3;
    }

    //5.替换字符串
    public static string FixName(string names)
    {
        string pattern = " {2,}";
        return Regex.Replace(names, pattern, "，");      
    }

}

