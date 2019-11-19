using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    /// <summary>
    /// 注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和邀请人（invitedBy）,和方法：Register()、Login()
    /// </summary>
    class User
    {
        //字段
        public string Name;          //字段可以在类的任何地方声明，供整个类使用。区别于变量
        public readonly int Password;      //可读类型的字段只能在初始化字段和构造函数中赋值，其他位置不可以
        private const string InvitedBy = "fg";   //默认static。初始化阶段必须赋值

        internal int age = 18;
        

        //无参构造函数/有参构造函数
        public User()          //public 是一个访问修饰符，表明任何地方都可以使用
        {


        }
        private User(int time)    //private 是一个访问修饰符，表明私有的，同一类中可以使用
        {


        }
        internal User(string name)  //internal 是一个访问修饰符，表明局域化。同一程序集中可以使用
        {
            this.Name = name;
            //Password++;
            //Console.WriteLine(name+"你确定是"+Password);
        }

        protected User(string name,int age)  //protected是一个访问修饰符，表明继承使用。只给它的子类使用。
        {


        }
        //一个推荐的原则：没有要求时候，默认总是给最低权限
        // 类的默认权限为internal，类成员的默认权限为private
        //权限和安全无关，因为可以用其他方法调用内部的类成员。更多的是提示作用。
        //方法
        public void Register()
        {
            

        }

        internal void Register(string invitedBy)
        {


        }

        protected void login()
        {
        }

        private void resetName()
        {
            ///1.外部不能直接修改    --private
            ///2.外部可以获取       --readonly
            ///3.（可通过方法等)内部可以修改
        }
        internal string getName()
        {
            return "智慧无双"+Name;

        }
        internal void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("姓名不能为空");
                return;
            }

            this.Name = name;

        }


        //属性:用于数据的存储和调用
        



        //静态构造函数

        //静态方法


        //析构函数
        ~User()
        {
            Console.WriteLine("GAME OVER!!!");
        }
    }
}
