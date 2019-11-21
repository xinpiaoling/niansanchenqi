using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 面向对象编程和面向过程编程
/// 简单理解：这是两种设计模式。
/// 面向对象的一种表现形式：类。类的特征：封装、继承、多态
/// 封装可以理解为对函数的管理，
/// </summary>
namespace CSharpLearn
{
    /// <summary>
    /// 注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和邀请人（invitedBy）,和方法：Register()、Login()
    /// </summary>
    class UserLearn
    {
        //字段
        private string name;          //字段可以在类的任何地方声明，供整个类使用。区别于变量
        private readonly string password;      //可读类型的字段只能在初始化字段和构造函数中赋值，其他位置不可以
        private const string invitedBy = "fg";   //默认static。初始化阶段必须赋值

        internal int age = 18;


        //无参构造函数/有参构造函数
        public UserLearn()          //public 是一个访问修饰符，表明任何地方都可以使用
        {


        }
        private UserLearn(int time)    //private 是一个访问修饰符，表明私有的，同一类中可以使用
        {


        }
        internal UserLearn(string name)  //internal 是一个访问修饰符，表明局域化。同一程序集中可以使用
        {
            this.name = name;
            //Password++;
            //Console.WriteLine(name+"你确定是"+Password);
        }

        protected UserLearn(string name, int age)  //protected是一个访问修饰符，表明继承使用。只给它的子类使用。
        {


        }
        internal UserLearn(string name, int age, int number)
            : this(name)                          //可以使用这样的方式调用前面的构造函数
        {
            this.age = age;
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
            return "智慧无双" + name;

        }
        internal void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("姓名不能为空");
                return;
            }

            this.name = name;

        }


        //属性:用于数据的存储和调用

        public string Property { get; set; }    //属性存放字段的方式
        public string Attribute { get; }       //设置只读字段
                                               //public string Attribute { get => Attribute; }     //一种简写方法

        public string Nature
        { set
            {
                if (value == "wx")
                {
                    Nature = value;
                }

            }
        }

        //静态构造函数
        static UserLearn()
        {                 

            //静态构造函数有点特别，没有访问修饰符，也没有参数
            //静态构造函数不能被开发人员调用，只能.NET运行时在使用类之前，自动调用一次且仅有一次，所以访问修饰符对它没有意义
           
         }
             /// <summary>
             /// 用static修饰类名，称为静态类。通常用于将静态方法归类，比如Console和Math类
             /// </summary>

         //静态字段
         public static string  Field;  //静态的字段常用来定义常量，通过类调用，不同的对象使用的是同一个字段，这一点与实例字段不同。
        public static string At="源栈";       //换一种理解：静态成员是唯一的，实例的成员根据不同对象是不唯一的                       
        //静态方法
        public static void enroll()          //静态的方法只能调用静态字段，不能调用实例字段
        {
            Console.WriteLine("王新在"+At);   //深刻理解：实例成员可以调用静态成员，静态成员不可以调用实例成员
        }

        //析构函数                     //作用是清除很久不用的实例对象的调用占用的内存，释放内存。
        ~UserLearn()                 //析构函数是默认自带的，不需要被显示申明。
        {                        
            Console.WriteLine("GAME OVER!!!");
        }
    }    //值类型变量会在出栈时被自动清空，其所占用的内存就会被释放
}        //引用类型的变量的对象在引用类型的变量出栈时不会被自动清空，内存就不会被释放，这既是内存泄漏。
