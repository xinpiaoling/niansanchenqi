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


}
