using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    struct Major   //结构通常用于不复杂的小型数据的封装，结构实例化的对象存放在栈中
    {              //值类型存放在变量里面，变量存放在栈里面
        //public Major()   //不能声明一个无参构造函数,,,系统自动声明一个无参构造函数
        //{

        //}
        public Major(string It)//如果写有参构造函数，必须赋值给字段一个默认值
        {
            name = It;
            Name = "";
        }
        

        public string name;   //结构字段不能被初始化赋值
        public string Name { get; set; }

        public void Math()
        {

        }



    }
    struct Library
    {



    }

















    enum Option     //枚举
    {
        start,
        stop,
        parse
    }


}

   