using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    class DateTimeHomework
    {
        //思考dynamic和var的区别
        ///dynamic只是在编译时绕过了编译器的检查，在运行时会被发现报错
        ///var是在编译时检查，后面写了数据类型，前面的var会自动识别为当前数据类型
        ///平时使用var即可



    }

    //用代码证明struct定义的类型是值类型
    struct library
    {
        private int desk;
        public int RoomNumber { get; set; }

    }
    class libraryC
    {
        public int RoomNumber { get; set; }
    }
    //构造一个能装任何数据的数组，并完成数据的读写
    class arr
    {
        public object[] Array { get; set; } = new object[2];

        public string Name { get; set; }



    }
    //一起帮中用户可以被分为：访客（Visited）、注册用户（Registered）、
    //    可发布（Published）和管理员（Admin）。
    //    请据此设计一个枚举类型Role（角色），
    //    并将其用于User对象，让User对象可以角色属性。
    enum Role
    {
        Visited,
        Registered,
        Published,
        Admin
    }
     //    源栈的学费是按周计费的，所以请实现这两个功能：
    //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
    //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
    static class yearGetWeek
    {
        public static void GetDate()
        {
            Console.WriteLine("请输入年份：");
            bool checkInput = int.TryParse(Console.ReadLine(), out int year);
            if (checkInput)
            {
                DateTime dateFirstDay = new DateTime(year, 1, 1);
                DateTime dateFinallyDay = new DateTime(year + 1, 1, 1);

                while (dateFirstDay.DayOfWeek != DayOfWeek.Monday)
                {
                    dateFirstDay = dateFirstDay.AddDays(1);
                }
                for (int i = 1; dateFirstDay < dateFinallyDay; i++)
                {

                    Console.WriteLine($"第{i}周:");
                    Console.Write(dateFirstDay.ToString("yyyy年MM月dd日"));
                    dateFirstDay = dateFirstDay.AddDays(6);
                    Console.Write("---");
                    Console.WriteLine(dateFirstDay.ToString("yyyy年MM月dd日"));
                    dateFirstDay = dateFirstDay.AddDays(1);
                }
            }
            else
            {
                Console.WriteLine("请输入正确的年份");
            }
        }
        //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
        [Flags]
        enum Token 
        {
            SuperAdmin=1,
            Admin=2,
            Blogger=4,
            Newbie=8,
            Registered=16
        }
        ///声明一个令牌管理（TokenManager）类：
        ///使用私有的Token枚举_tokens存储所具有的权限暴露Add(Token)、Remove(Token)和Has(Token)方法，
        ///可以添加、删除和查看其权限 将TokenManager作为User类的属性
        
        class TokenManager
        {
            private Token _tokens;
            public void Add(Token Permissions)
            {
                _tokens = Permissions | _tokens;
            }

            public void Remove(Token Permissions)
            {
                _tokens = Permissions ^ _tokens;
            }

            public void Has(Token Permissions)
            {
                _tokens = Permissions & _tokens;
            }





        }
        //将TokenManager作为User类的属性
        class User
        {
            public  TokenManager Manger { get; set; }
        }
    }

}
