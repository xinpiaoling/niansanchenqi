using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    public class Student
    {
        public Student()
        {

        }
        //公开可使用
        //无参构造函数
        private Student(string yf)
        {

        }
        //有参构造函数
        //仅当前类可使用
        internal Student(string fg,int age)
        {

        }
        //仅当前程序集可使用

    }
}
