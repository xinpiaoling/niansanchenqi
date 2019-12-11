using System;
using System.Collections;
using System.Collections.Generic;

namespace CSHARP_11._21
{
    class Program
    {


        static void Main(string[] args)
        {
            EventLearn wx = new EventLearn();
            //ChangeNumber ww = new ChangeNumber(wx.OnClick);

            wx.Click += EventLearn.UserClick;
            wx.Click += EventLearn.TeacherClicl;

            wx.OnClick();

            wx.Click -= EventLearn.UserClick;
            wx.Click -= EventLearn.TeacherClicl;

            wx.OnClick();





            ////调用委托。。。其实委托可以调用多种方法，只要符合返回参数类型和输入参数类型。
            //MrsWang wx = new MrsWang();
            //Buy XiaoZhang = new Buy(MrsWang.BuyMovieTicket);
            //XiaoZhang();
            //XiaoZhang += MrsWang.BuyMeal;
            //XiaoZhang();



            ////可空类型
            //int i;  //默认值为0
            //int? ii;   //默认值为null
            //Nullable<int> iii = new Nullable<int>();


            //int? num1 = null;
            //int? num2 = 45;
            //double? num3 = new double?();
            //double? num4 = 3.14157;

            //bool? boolval = new bool?();

            //// 显示值

            //Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}",
            //                   num1, num2, num3, num4);
            //Console.WriteLine("一个可空的布尔值： {0}", boolval);
            //Console.ReadLine();

            ////合并运算符 如果第一个变量的值为null，则返回第二个变量的值。否则返回第一个值。
            //num3 = num1 ?? num2;
            //Console.WriteLine(num3);
            //num3 = num4 ?? num3;
            //Console.WriteLine(num3);




            ///stack的方法使用
            // Stack i = new Stack();
            // Stack st = new Stack();
            // i.Push(22);
            // i.Push("erer");
            // i.Push(true);
            // Console.WriteLine(i.Peek());
            // Console.WriteLine();
            // foreach (var item in i)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine();

            // i.Pop();
            // foreach (var item in i)
            // {
            //     Console.WriteLine(item);

            // }
            // Console.WriteLine();
            // Console.WriteLine(i.Count);
            // Console.WriteLine();

            //object[] ii=i.ToArray();
            // foreach (var item in ii)
            // {
            //     Console.WriteLine(item);
            // }
            //用反射获取Publish()上的特性实例，输出其中包含的信息
            //Attribute attribute = HelpMoneyChangedAttribute.GetCustomAttribute(
            //    typeof(Problem),
            //    typeof(HelpMoneyChangedAttribute));
            //Console.WriteLine(((HelpMoneyChangedAttribute)attribute).Message);

            //object[] students = new object[10];
            //students[0] = "string类型";
            //students[2] = 15;
            //students[5] = new object();


            //object[] teachers = { "ooo", 10.22, new object(), null };

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in teachers)
            //{
            //    Console.WriteLine(item);
            //}

            //GenericClassLearn<string> wx = new GenericClassLearn<string>();
            //wx.Name = "王新";
            //wx.Add("");
            //GenericClassLearn<int> ii = new GenericClassLearn<int>();
            //ii.Name = 25;
            //ii.Add(10);



            //int a = 1;
            //object b=(object)a;         //装箱：值类型转换成引用类型
            //int c = (int)b;             //拆箱：引用类型转换成值类型

            ///匿名类，只读，里面字段随便写
            ///拥有相同属性字段
            //var tt =new {Name="套套",age="",score=15 };
            //tt.Name = "";
            //Console.WriteLine(tt.Name);

            ///索引器调用方式
            //Index wx = new Index();
            //wx[4] = "json";
            //foreach (var item in wx) 不能被遍历
            //{
            //    Console.WriteLine(item);

            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(wx[i]);
            //}



            //wx[0] = "c#";
            //wx[1] = "python";
            //wx[2]= "c++";
            //wx[12] = "ssss";
            //Console.WriteLine(wx[12]);





            //TokenManager wx = new TokenManager();
            //Console.WriteLine("初始状态："+wx._tokens);
            //wx.Add(Token.SuperAdmin);
            //Console.WriteLine(wx._tokens);
            //Console.WriteLine(wx.Has(Token.Admin));
            ////wx.Remove(Token.Blogger);
            //wx.Remove(Token.SuperAdmin);
            //Console.WriteLine(wx._tokens);
            ////Child ch = new Child();
            //Father td = new Father();

            //ch.height = 15;
            //ch.width = 10;
            //ch.Date = "2019年11月21日21:36:48";
            //Console.WriteLine(ch.Add());
            //Console.WriteLine(ch.Adds(100));
            //Console.WriteLine(td.Add());
            //Console.WriteLine("很奇怪的用法{0}");
            //Father should = new Father();
            //should.Eat();
            // should = new Child();
            //should.Eat();

            //Problem tom = new Problem("val");
            //tom.Kind="cat";
            //Console.WriteLine("tom出生的日期:"+tom.PublishTime);
            //Problem jack = new Problem("val");
            //jack.method();
            //Console.WriteLine("它是一只："+tom.Kind);
            //Article myl = new Article("val");
            //Console.WriteLine("-------------------------");

            //Content Father = new Content("val");
            //Father.Eat();
            //tom.Eat();
            //myl.Eat();

            //Add BOX1 = new Add();
            //Add BOX2 = new Add();
            //Add BOX3 = new Add();
            //BOX1.SetA (10);
            //BOX1.SetB (15);
            //BOX2.SetA (100);
            //BOX2.SetB (150);
            //BOX3 = BOX2 + BOX1;
            //Console.WriteLine(BOX3.GetA());
            //Console.WriteLine(BOX3.GetType());



            //Animal[] animals = new Animal[3];
            //animals[0] = new Animal();
            //animals[1] = new Cat();
            //animals[2] = new Dog();
            //for (int i = 0; i <animals.Length ; i++)
            //{
            //    animals[i].Eat();
            //}



            //Assemly程序集。是.net中最小的执行单元
            //Console.WriteLine("".GetType().Name);
            //Console.WriteLine(typeof(Int32).Assembly);

            //Animal example = new Animal();
            //Console.WriteLine(example.GetType().       //得到类型信息
            //    GetField("kind",    //取非公开的，实例的字段
            //    BindingFlags.NonPublic |BindingFlags.Instance )
            //    .GetValue(example));   //从对象cat里面取值


            //Type typeinfo= typeof(Animal);
            //Console.WriteLine(typeinfo);

            //Animal wx = new Cat();
            //Console.WriteLine(wx.GetType());


            //下面的对比struct是值类型和class是引用类型


            //Major是sruct类型，Name是属性
            //Major Book=new Major();
            //Major Book1=new Major();
            //Book.name = "闪烁";
            //Book1 = Book;
            //Book1.name = "不闪烁";
            //Console.WriteLine(Book.name);
            //Console.WriteLine(Book1.name);
            ////Book.Name ;
            ////Book.Math();
            //Add Try = new Add();
            //Add Try1 = new Add();
            //Try.a = "熄灭";
            //Try1 = Try;
            //Try1.a = "不熄灭";
            //Console.WriteLine(Try.a);
            //Console.WriteLine("--------------");
            //Console.WriteLine(Try1.a);



            //时间类型的使用



            //DateTime dt = new DateTime(2019,12,1,15,30,20);
            ////显示以奈秒计算的时间单位
            //Console.WriteLine(dt.Ticks);
            ////可以在原有日期上加天数或者年份，，，小时分秒等都可以
            //DateTime s=dt.AddDays(10);
            //DateTime s1 = dt.AddYears(1);
            //Console.WriteLine(s);
            //Console.WriteLine(s1);
            ////通过纳秒，再通过ToString()转换为日期格式
            //DateTime nu = new DateTime(1132471111111);
            //Console.WriteLine(nu.ToString("yyyy/mm/dd hh;mm;ss"));

            //Console.WriteLine(dt.ToString("yyyy/MM/dd"));
            ////两个日期可以相减，得到一个时间差
            //TimeSpan span = DateTime.Now - new DateTime(2019,1,1);
            //Console.WriteLine(span.TotalSeconds);





            //装箱拆箱的过程
            //理解为object和值类型之间的转换。与其他类无关，了解知识
            //object i = new object();
            //int p = (int)i;
            //int ii = 10;
            //Console.WriteLine(p);
            //Console.WriteLine(ii.GetType());
            //Console.WriteLine(i.GetType()); 



            ////用代码证明struct定义的类型是值类型
            //library shanxi = new library();
            //library beijing = new library();

            //shanxi.RoomNumber = 52;
            //beijing = shanxi;

            //beijing.RoomNumber = 53;
            //Console.WriteLine(shanxi.RoomNumber);
            //Console.WriteLine(beijing.RoomNumber);
            ////library是struct类型，libraryC是class类型
            ////值类型的对象改变，与引用类型的对象改变，两者的值不一样
            //libraryC chongqing = new libraryC();
            //libraryC sichuan=new libraryC();
            //chongqing.RoomNumber = 100;
            //sichuan = chongqing;
            //chongqing.RoomNumber = 101;
            //Console.WriteLine(chongqing.RoomNumber);
            //Console.WriteLine(sichuan.RoomNumber);


            //构造一个能装任何数据的数组，并完成数据的读写
            //arr b = new arr();
            //b.Array[0] = 15;
            //b.Array[1] = "ss";
            ////b.Array[3] = 15.33;
            //foreach (var item in b.Array)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine(DateTime.Now.DayOfWeek);
            //DateTime.Now.DayOfWeek;


            //    源栈的学费是按周计费的，所以请实现这两个功能：
            //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
            //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：

            //yearGetWeek.GetDate();


            //反射的简单使用，获得类的私有字段方法
            //例
            //Animal cat = new Animal("猫");
            //获得类型
            //Type typeOf = cat.GetType();
            //获得字段     BindingFlags,注意这个enum，他使用了位运算的权限管理功能。
            // FieldInfo getInfo= typeOf.GetField("kind",BindingFlags.NonPublic | BindingFlags.Instance);
            //通过GetValue()方法，得到这个私有字段的值
            //Console.WriteLine(getInfo.GetValue(cat));

            //Attribute attribute = FlagsAttribute.GetCustomAttribute(typeof(Attribute),typeof(AttributeUsageAttribute));

            //Console.WriteLine(((AttributeUsageAttribute)attribute).Inherited);

            //Console.WriteLine(Roles.Student|Roles.Teacher);

            //Add t1 = new Add();
            //t1.a = "reference";
            //Add t2 = new Add();
            //t2.a = "reference";
            //Console.WriteLine(t1.a==t2.a);
            //Console.WriteLine(t1.a.Equals(t2.a));
            //==与equals的区别：值类型没有区别。引用类型==判断的是栈中的引用地址是否一样。
            //               equals判断的是两个对象在堆中的数据是否一样，即两个引用类型是否是对同一个对象的引用。
        }
    }
    [Flags]
    enum Roles
    {
        Student = 1,
        Teacher = 2,
        Cleaner = 4
    }




    class Add
    {
        public string a;



        //private int a;
        //private int b;
        //public string Try { get; set; }

        //public void SetA(int a)
        //{
        //    this.a = a;
        //}
        //public void SetB(int b)
        //{
        //    this.b = b;
        //}
        //public int GetA()
        //{
        //    return a;
        //}


        /// <summary>
        /// 运算符重载是对相同的参数类型，根据同一方法名和运算符的不同组合进行运算，达到重载的作用。
        /// 实际上还是在方法内部对对象的值类型参数进行了运算。
        /// 
        /// </summary>
        /// <param name="Box1"></param>
        /// <param name="Box2"></param>
        /// <returns></returns>
        //public static Add operator+(Add Box1, Add Box2)
        //{
        //    Add Box3 = new Add();
        //    Box3.a = Box1.a + Box2.a;
        //    Box3.b = Box1.b + Box2.b;
        //    return Box3; 
        //}

    }

    //class Father
    //{
    //    internal virtual void Eat()
    //    {
    //        Console.WriteLine("父亲吃饭！！");
    //    }
    //}
    //class Child : Father
    //{
    //    internal override void Eat()
    //    {
    //        Console.WriteLine("孩子吃饭");
    //    }
    //}
}
