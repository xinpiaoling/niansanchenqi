using System;
using System.Collections.Generic;
using System.Linq;
using CSharpLearn;
using CSHARPLearn;


namespace CSharpLearn

{

    public class Program
    {



        static void Main(string[] args)
        {

            //string和stringBuileder
            string str = "      距离回去，还有12天！   ";
            Console.WriteLine(str.Remove(1));
            Console.WriteLine(str.Remove(1,3));
            Console.WriteLine(str.Insert(0,"王新"));
            Console.WriteLine(str.Replace("回去","回西安"));
            Console.WriteLine(str.Substring(5));
            Console.WriteLine("!!!"+str.TrimEnd()+"###");
            Console.WriteLine("-------");

            string a = "源栈";
            string b = "，";
            string c = "欢迎您!";

            //直接把abc连接起来
            Console.WriteLine(string.Concat(a, b, c));
            //把abc用' '连接起来
            string joined = string.Join("----", a, b, c);
            Console.WriteLine(joined);   //注意空格：源栈 ， 欢迎您!





            //ExerciseOfLinq.ExerciseOfLinqDo();
            //LambdaHomework<Person> wx = new LambdaHomework<Person>();
            //Person cy = new Person();
            //ProvideWater<Person> pzq= new ProvideWater<Person>(LambdaHomework<Person>.GetWater<Person>);
            //pzq(cy);
            ////方法调用
            //LambdaHomework<Person>.GetWater(cy);
            ////匿名方法调用
            ////string name = string.Empty;
            //ProvideWater<Person> ww = delegate (Person name) { return 32; };
            //ww(cy);
            ////lambd表达式
            //ProvideWater<Person> cc = (Person name) => { return 20; };
            //cc(cy);

            //【练习1】李四的年终工作评定,如果定为A级,则工资涨500元,
            //如果定为B级,则工资涨200元,如果定为C级,工资不变,
            //如果定为D级工资降200元,如果定为E级工资降500元.
            //设李四的原工资为5000,请用户输入李四的评级,然后显示李四来年的工资.


            //练习使用switch  case default的用法
            //int salary = 5000;
            //bool b = true;
            //Console.WriteLine("请输入李四的年终工作评定：A/B/C/D/E");
            //string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "A":

            //            salary += 500;
            //            break;

            //    case "B":

            //            salary += 200;
            //            break;

            //    case "C":

            //            salary +=0; 
            //            break;

            //    case "D":

            //            salary -= 200;
            //            break;

            //    case "E":

            //            salary -= 500;
            //            break;

            //    default:

            //            Console.WriteLine("输入错误，重新输入！！！");
            //            b = false;
            //            break;


            //}

            //if (b)
            //{
            //    Console.WriteLine("李四的来年工资为：" + salary);
            //}



            //dynamic ss1 = "是么";
            //ss1 = 150;
            //Console.WriteLine(ss1);
            ////使用动态dynamic和var的区别。由于使用较少，暂时没有看出实际使用场景。
            //var ww1 = 99;
            //// ww = "www";
            //Console.WriteLine(ww1);


            //DateTime date = new DateTime(2019,1,1);
            ////date.DayOfWeek;
            //Console.WriteLine(date.DayOfWeek==DayOfWeek.Monday);
            //while (date.Year==2019)
            //{
            //    Console.WriteLine(date.ToString("yyyy年mm月dd天"));
            //    date = date.AddDays(7);
            //}


            ////偶然看到的整数类型强转为字符类型，从而变成a,b,c等字符
            //char w =(char) 98;
            //Console.WriteLine(w);  //输出结果为b








            //Value yf = new Value(12);

            //Console.WriteLine(yf.age);

            //Student wx=new Student();
            //对象是类的实例
            //wx是一个变量名
            //这是一个引用类型的变量
            //wx存在的是一个指向地址。指向值存在的地址。
            //new Student("ss");

            //yf.age = 38;

            //Value bcy = new Value(15);
            //bcy.age = 18;
            //C#把new Value("白云")的存放地址给bcy了。。。不是给值，所以是引用类型
            ///Console.WriteLine(bcy.age);

            //值类型的值传递    //传递的是值的副本


            //值类型的引用传递         //传递的是本身的值
            //int a = 10;
            //Console.WriteLine(ref Change(a));
            //引用类型的值传递          //传递的是值保存的地址的被命名变量的副本
            //Value bb = new Value();
            //bb.age = 10;
            //Add( bb);
            //Console.WriteLine(bb.age);

            //引用类型的引用传递         //传递的是值保存的地址的被命名变量的副本
            //Value bb = new Value();
            //bb.age = 10;
            //Add(ref bb);
            //Console.WriteLine(bb.age);
            //return
            //int cc = 5;
            //Ca(ref cc);
            //Console.WriteLine(cc);

            //Problem Change = new Problem("wx");
            ////Change.setName("");
            //Change.Name = "";
            //Console.WriteLine(Change.Name);
            //HelpMoney wx = new HelpMoney();
            //wx.Name = "王新";
            //wx.age = 18;
            //wx.num = 55;
            //Console.WriteLine(wx.Name+wx.age);

            //HelpMoney ww = new HelpMoney("线条");
            //HelpMoney ee = new HelpMoney("面积");

            //Console.WriteLine(ww.Line+"    "+ee.Line);
            ////Console.WriteLine(ww.GetLength());

            //HelpMoney rr = okz;
            //User wx = new User();
            //wx.Name = "admin";
            //wx.ChangePassword("min");
            //分别调用实例字段和静态字段，查看两者区别。
            //FactoryContext use = new FactoryContext();  
            //FactoryContext use2 = new FactoryContext();
            //use.num = 15;
            //use2.num = 20;
            //Console.WriteLine(use.num);
            //Console.WriteLine(use2.num);
            //use.Count();
            //use2.Count();
            //Console.WriteLine(use.getNum());
            //Console.WriteLine(use2.getNum());



            //Console.WriteLine(wx.Name);

            //SelfIntroduce();      
            //Console.WriteLine("加："+Add(10,5));
            //Console.WriteLine("减："+Minus(10, 5));
            //Console.WriteLine("乘："+Mutiply(10, 5));
            //Console.WriteLine("除："+Divide(10, 5));
            //Console.WriteLine(GetUnicode("九十八"));
            //double[] arr = { 1, 5, 10, 63, 20,98.5,1.5,0.5,-12 };
            //Console.WriteLine(Max(new double[] { 1, 5, 10, 63, 20,98.5,1.5,0.5,-12 }));
            //Console.WriteLine(GetUnicode('唱'));
            //double[] scores = {12,64,35.2,51,100.5 };
            //Console.WriteLine(GetAverage(scores));
            //GuessMe();
            //用变量name存储你的姓名，然后输出带有你姓名的入栈口号
            //string name = "王新";
            //Console.WriteLine(name);
            //在“入栈口号”的基础上，使用变量Age（年龄）、
            //IsFemale（是否男生）、
            //Height（身高，单位米）、
            //FromCity（来自哪里）存储你的个人信息，并在控制台逐行输出
            //int Age = 25;
            //bool IsFemal = false;
            //double Height = 173.5;
            //string FromCity = "宁夏";
            //Console.WriteLine(name + "学习C#");
            //Console.WriteLine(Age);
            //Console.WriteLine(IsFemal);
            //Console.WriteLine(Height + "米");
            //Console.WriteLine(FromCity);


            //输出两个整数 / 小数的和 / 差 / 积 / 商 / 余
            //int a1 = 20;
            //int a2 = 21;
            //Console.WriteLine(a1 + a2);
            //Console.WriteLine(a1 - a2);
            //Console.WriteLine(a1 / (float)a2);
            //Console.WriteLine(a1 * a2);
            //Console.WriteLine(a1 % a2);

            //double  b1 = 10.2;
            //double  b2 = 0.2;
            //Console.WriteLine(b1 + b2);
            //Console.WriteLine(b1 - b2);
            //Console.WriteLine(b1 * b2);
            //Console.WriteLine(b1 / b2);
            //Console.WriteLine(b1 % b2);

            //Console.ReadLine();
            ////电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（精确到小数点以后x位）
            //double w = ((23 + 7) * 12 - 8) / (float)6;
            //Console.WriteLine(Math.Round(w, 5));

            //输入一个字符，显示这个字符的unicode值
            //string s = "唱";
            //char m = '地';
            //Console.WriteLine((int)m);

            //输入一个整数，如果这个整数：
            //能被6整除，显示：六六顺
            //能被8整除，显示：发发发
            //否则，显示：大吉大利

            ///test1:3=>"大吉大利"
            ///test2:6=>"六六顺"
            ///test3:8=>"发发发"
            ///test4:24=>"法力无边"
            ///test5:55=>"大吉大利"
            //int s= 55;
            //if (s%6==0)
            //{
            //    if (s % 8 == 0)
            //    {
            //        Console.WriteLine("法力无边");
            //    }
            //    else
            //    {
            //        Console.WriteLine("六六顺");
            //    }


            //}
            //else if (s % 8 == 0)
            //{
            //    Console.WriteLine("发发发");
            //}
            //else
            //{
            //    Console.WriteLine("大吉大利");
            //}

            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //string[] name0 = { "彭志强", "于伟谦", "陈元", "jimmy" };
            //string[] name1 = new string[4] {"彭志强", "于伟谦", "陈元", "jimmy" };
            //for (int i = 0; i < name0.Length; i++)
            //{
            //    Console.WriteLine(name0[i]);
            //}
            //Console.WriteLine(name0.Length);
            //按座位装入二维数组，并输出共有多少名同学。
            //string[,] name10 = new string[4, 2] { { "彭志强", "于为谦" },
            //    { "陈元", "刘江平" }, 
            //    { "王新", "赵敬春" },
            //    { "阿泰", "曾俊清" } };

            //for (int i = 0; i < name10.getlength(0); i++)
            //{
            //    for (int j = 0; j < name10.getlength(1); j++)
            //    {
            //        Console.Write(name10[i,j]+"  ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //Console.WriteLine(name10.Length);

            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int j = 1;
            //while (j<10)
            //{
            //    Console.WriteLine(j);
            //    j += 2;
            //}
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //数组的位置已写答案
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int j = 0;
            //for (int i = 1; i < 100; i += 2)
            //{
            //    j = i + j;
            //}
            //Console.WriteLine(j);
            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] scores = {50,60,70,84,64.5,58,50};
            //double max = 0; 
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (max < scores[i])
            //    {
            //        max = scores[i];
            //    }
            //    else
            //    {
            //        //nothing
            //    }
            //}
            //Console.WriteLine(max);   //输出最大值
            //double min = scores[0];
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (min > scores[i])
            //    {
            //        min = scores[i];
            //    }
            //    else
            //    {
            //        //nothing
            //    }
            //}
            //Console.WriteLine(min);   //输出最小值
            //////找到100以内的所有质数（只能被1和它自己整除的数）
            //Console.WriteLine(2);
            //for (int i = 2; i < 100; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //            //nothing
            //        }
            //        else
            //        {
            //            if (j == i - 1)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }

            //    }

            //}



            ///判断一个输入的数是否是质数
            ////int n = int.Parse(Console.ReadLine());
            //int k = 0;            
            //Console.WriteLine(2);
            //for (int n = 2; n < 100; n++)
            //{
            //    for (int i = 2; i < n; i++)
            //    {
            //        if (!(n % i == 0))
            //        {
            //            k++;
            //        //Console.WriteLine(i);
            //        //Console.WriteLine(k);
            //            if (n - 2 == k)
            //               {
            //                  Console.WriteLine(n + "是质数");
            //               }
            //        }
            //        else
            //        {                        
            //            //nothing
            //        }
            //    }
            //    k = 0;
            //}
            //if (n - 2 == k)
            //{
            //    Console.WriteLine(n + "是质数");
            //}
            //else
            //{
            //    Console.WriteLine(n + "不是质数");
            //}


            //Console.WriteLine(k);
            // n = 3=>k = 1,
            // n = 5=>k = 3,
            // n = 7=>k = 5,
            // n = 11=>k = 9,
            // n = 97=>k = 95
            //n =  =>k=n-2

            //int a = 10;
            //int b = 22;
            ////Console.WriteLine($"交换前   a:{a}   b:{b}");
            // Swap(ref a, ref b);
            //Console.WriteLine($"交换后   a:{a}   b:{b}");
            //int length = 10;
            //int[] finish = new int[length];
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(BinarySeek(numbers,5)); 
            //string name = "王新";
            //int age = 25;
            //bool isFemal = false;
            //string fromCity = "宁夏";
            //SelfIntroduction((name, age, isFemal, fromCity));        //输入元祖参数的两种方法：1
            //SelfIntroduction(self: (name, age, isFemal, fromCity));    //输入元祖参数的两种方法：2
            //GetArray(10,1,150);
            //Test(5);

            //int[] rule = {10,48,15,41,35,15,62 };
            //var indexOfNu=IndexOf(rule,35);
            //Console.WriteLine(indexOfNu);
            //order();
            //int[] array = { 49, 38, 65, 97, 76, 13, 27 };
            //sort(array, 0, array.Length - 1);
            //Console.ReadLine();

            //int[] arr = { 15, 3, 64, 42, 87, 21, 6, 70, 32 };
            //int low = 0;
            //int high = arr.Length - 1;
            //sort(arr, low, high);
            ////////////////////////////////////////////
            ///////////////////////////////////////////////
            ////////////////////////////////////////////
            ////////////////////////////////////////////
            //int i = 0;
            //State(i);
        }
        //自我介绍：SelfIntroduce()
        //static void SelfIntroduce()
        //{
        //    string name = "王新";
        //    int age = 25;
        //    bool isFemal = false;
        //    double height = 1.73;
        //    string fromCity = "宁夏";
        //    Console.WriteLine("名字："+name);
        //    Console.WriteLine("年龄："+age);
        //    Console.WriteLine("是否为女性："+isFemal);
        //    Console.WriteLine("身高："+height);
        //    Console.WriteLine("来自："+fromCity);
        //}
        //加减乘除：Add()/Minus()/Mutiply()/Divide()
        //static int Add(int a,int b) {
        //    return a + b;
        //}
        //static int Minus(int a, int b)
        //{
        //    return a - b;
        //}
        //static int Mutiply(int a, int b)
        //{
        //    return a * b;
        //}
        //static int Divide(int a, int b)
        //{
        //    return a / b;
        //}
        //取字符值：GetUnicode()
        //static int GetUnicode(char str)
        //{
        //    int istr=(int)str;
        //    return istr;
        //}


        //取最高分：GetMax()
        /// <summary>
        /// get max number
        /// </summary>
        /// <param name="arr">input array</param>
        /// <returns>max number</returns>
        //static double Max(double[] arr) {
        //    double max=arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (max<arr[i])
        //        {
        //            max = arr[i];
        //        }
        //        else
        //        {
        //            //do nothing
        //        }
        //    }
        //    return  max;
        //}
        //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        //static double GetAverage(double[] scores) {
        //    double sum=0;
        //    for (int i = 0; i < scores.Length; i++)
        //    {
        //        sum=sum+scores[i];
        //    }
        //    double average =Math.Round( sum / scores.Length,2);

        //    return average;
        //}
        //完成“猜数字”游戏，方法名GuessMe()

        //static void guessme()
        //{
        //    int m = new random().next(1, 100);
        //    for (int i = 1; i < 11; i++)
        //    {

        //        console.writeline("请输入一个整数");
        //        string input = console.readline();
        //        bool n = int.tryparse(input, out int a);
        //        if (!n)
        //        {
        //            console.writeline("第" + i + "次输入错误，请输入一个整数");
        //        }
        //        else
        //        {
        //            console.write("第" + i + "次比较：");
        //            if (m == a)
        //            {
        //                if (i < 3)
        //                {
        //                    console.write("你是一个天才！！！");                          
        //                }
        //                else if (i < 6)
        //                {
        //                    console.write("你登上了珠峰！！！");
        //                }
        //                else if (i < 10)
        //                {
        //                    console.write("你是一个普通人！！！");
        //                }
        //                else if (i == 10)
        //                {
        //                    console.write("你太难了，终于猜对了！！！");
        //                }
        //                else
        //                {
        //                    //i定义区间为1-10，不存在其他情况
        //                }
        //                console.writeline();
        //                break;
        //            }
        //            else if (m < a)
        //            {
        //                console.write("大了");
        //                console.writeline();
        //                if (i == 10)
        //                {
        //                    console.writeline("游戏结束！！！弱鸡");
        //                }
        //                else
        //                {
        //                    //do nothing
        //                }
        //            }
        //            else if (m > a)
        //            {
        //                console.write("小了");
        //                console.writeline();
        //                if (i == 10)
        //                {
        //                    console.writeline("游戏结束！！！弱鸡");
        //                }
        //                else
        //                {
        //                    //do nothing
        //                }
        //            }
        //            else
        //            {
        //                //do nothing 
        //            }
        //        }
        //    }
        //}
        //static void Valueb(ref int vv) {
        //    vv+=5;

        //}
        //默认参数和不写参数会执行哪一个函数
        //优先执行不写参数的那个函数，如test2
        //static void  Test(int i=1,string j="等")
        //{
        //    Console.WriteLine("test1");

        //}
        //static void Test(int i=10 )
        //{
        //    Console.WriteLine("test2");

        //}


        //用ref调用Swap()方法交换两个同学的床位号
        //static void Swap(ref int a, ref int b)
        //{
        //    int middle;
        //    middle = b;
        //    b = a;
        //    a = middle;
        //}
        //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。
        //利用可选参数控制：
        //最小值（默认为1）
        //相邻两个元素之间的最大差值（默认为5）
        //元素个数（默认为10个）
        //static int[] GetArray(int i = 0, int length = 10, int min = 1, int max = 100)
        //{

        //    int[] finish = new int[length];
        //    while (i < length)
        //    {
        //        int random = new Random().Next(finish[i], finish[i]+5);
        //        if (i == 0)
        //        {
        //            finish[i] = random;
        //            Console.Write("整数类型："+finish[i]+",  ");
        //            i++;
        //        }
        //        else
        //        {
        //            if ((random - finish[i - 1]) < 6 && (random - finish[i - 1] >= 0))
        //            {
        //                finish[i] = random;
        //                Console.Write(+finish[i]+",  ");
        //                i++;
        //            }
        //            else
        //            {
        //                //do nothing
        //            }

        //        }

        //    }
        //    return finish;
        //}

        //重载GetArray()，使其返回一个string[]
        //static string[] GetArray(int length = 10, int min = 1, int max = 100)
        //{
        //    int i = 0;
        //    int[] finish = new int[length];
        //    string[] strFinish = new string[length];
        //    while (i < length)
        //    {
        //        int random = new Random().Next(min, max);
        //        if (i == 0)
        //        {
        //            finish[i] = random;


        //            strFinish[i]= Convert.ToString(random);
        //            Console.Write("字符串类型："+strFinish[i]+",  ");
        //            i++;
        //        }
        //        else
        //        {
        //            if ((random - finish[i - 1]) < 6 && (random - finish[i - 1] >= 0))
        //            {
        //                finish[i] = random;

        //                strFinish[i] = Convert.ToString(random);
        //                Console.Write(strFinish[i]+",  ");
        //                i++;
        //            }
        //            else
        //            {
        //                //do nothing
        //            }

        //        }

        //    }
        //    return strFinish;
        //}
        //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
        //传入一个有序（从大到小/从小到大）数组和数组中要查找的元素
        //如果找到，返回该元素所在的下标；否则，返回-1

        //test1:
        //int[] numbers={1,2,3,4,5,6};  5
        //输出：4
        //test2:
        //int[] numbers={1,2,3,4,5,6,7};  10
        //输出：-1
        //static int BinarySeek(int[] numbers, int target)
        //{
        //    int left = 0;
        //    int right = numbers.Length - 1;
        //    int middle;
        //    while (left < right)
        //    {
        //        middle = (left + right) / 2;
        //        if (target > numbers[middle])
        //        {
        //            left = middle + 1;
        //        }
        //        else if (target < numbers[middle])
        //        {
        //            right = middle + 1;
        //        }
        //        else
        //        {
        //            return middle;
        //            
        //        }
        //    }
        //    return -1;
        //}

        //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
        //static void SelfIntroduction((string name, int age, bool isFemal, string fromCity) self)
        //{
        //    Console.WriteLine("名字：      "+self.name + "年龄： " + self.age + "是否为女性：" + self.isFemal + "来自：  " + self.fromCity);
        //    Console.WriteLine("年龄：      " + self.age);
        //    Console.WriteLine("是否为女性： " + self.isFemal);
        //    Console.WriteLine("来自：      " + self.fromCity);

        //    ///SelfIntroduction(self: 23);    //再次调用方法
        //}
        //IndexOf()，通过遍历在无序数组中   找到某个值的下标，找不到返回-1
        //test1: {10,48,62,41,35,15,62 },62  =>2  明确需求：返回重复数字的第一个值下标
        //test2: {10,48,62,41,35,15,62 },48  =>1  返回下标1
        //test3: {"10","48","62","41","35","15","62" },56 =>error 明确需求： 数组为整数数组，值为整数类型

        //static int IndexOf(int[] rule,int number)
        //{
        //    int i = 0;
        //    while( i < rule.Length)
        //    {
        //        if (number==rule[i])
        //        {
        //            return i;
        //        }
        //        else
        //        {
        //           //do nothing
        //        }
        //        i++;
        //    }
        //    return -1;
        //}












        //快速排序
        ///start 7,5,8,3,6,2,9,1     key =a[0]=>7     
        ///i=0 j=7 从后向前找
        ///one   1,5,8,3,6,2,9,7       //j   a[7]<key   交换
        ///i=0 j=6 从前向后找
        ///two   1,5,8,3,6,2,9,7       //i   a[0]<key   不交换
        ///i=1 j=6 从前向后找      
        ///three 1,5,8,3,6,2,9,7       //i   a[2]>key    交换
        ///
        //static void order()
        //{
        //    //int[] arr = { 5, 8, 7, 3, 1, 9, 6, 2, 4 };
        //    int[] arr = { 4, 2, 1, 3, 5, 9, 6, 7, 8 };
        //    int i = 0;
        //    int j = 4 - 1;
        //    int key = arr[0];
        //    int middle;
        //    int[] anser = new int[arr.Length];


        //    while (i < j)
        //    {
        //        while (key < arr[j] && i < j)    //key=2   i=0,j=1   {2,1}      
        //        {                         //key=1   i=0,j=1   {1,2}  //key=1   i=0,j=0  {1}
        //            j--;
        //            //i=0,j=0
        //        }
        //        //if (i==j&&i==0)
        //        //{
        //        //    break;
        //        //}
        //        middle = arr[i];
        //        arr[i] = arr[j];
        //        arr[j] = middle;
        //        while (key > arr[i] && i < j)   //key=1,i=0,j=0  {1,2} 
        //        {

        //            //if (j == 0)
        //            //{
        //            //    break;
        //            //}
        //            //else
        //            //{
        //            i++;
        //            //}                 //  i=0  ,j=0

        //        }
        //        //if (i == j && i == 1)
        //        //{
        //        //    break;
        //        //}
        //        //if (i==j&&i==0)
        //        //{
        //        //    anser[i] = arr[i];
        //        //    Console.WriteLine(anser[i]);
        //        //    i++;
        //        //    anser[i] = arr[i];
        //        //    Console.WriteLine(anser[i]);
        //        //    break;
        //        //}
        //        middle = arr[i];
        //        arr[i] = arr[j];
        //        arr[j] = middle;

        //    }
        //    //if (i == j && j == 0)
        //    //{
        //    //    anser[i + 1] = arr[i + 1];
        //    //    //Console.WriteLine(anser[i+1]);
        //    //}
        //    anser[i] = arr[i];
        //    //Console.WriteLine(anser[i]);

        //    //if (i == 0 && j == 0)
        //    //{
        //    for (int m = 0; m < arr.Length; m++)
        //    {
        //        Console.Write(arr[m] + ",  ");
        //    }
        //    //    break;
        //    //}

        //    //key = arr[0];
        //    //i = 0;
        //    //j = arr.Length - 1;


        //}


        //    i = arr.Length / 2+1;
        //    j = arr.Length - 1;
        //    key = arr[arr.Length / 2+1];
        //    while (!(i == arr.Length / 2 && j == arr.Length / 2))
        //    {
        //        while (i != j)
        //        {
        //            while (key < arr[j])    //key=2   i=0,j=1   {2,1}      
        //            {                         //key=1   i=0,j=1   {1,2}  //key=1   i=0,j=0  {1}
        //                j--;
        //                //i=0,j=0
        //            }
        //            //if (i==j&&i==0)
        //            //{
        //            //    break;
        //            //}
        //            middle = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = middle;
        //            while (key > arr[i])   //key=1,i=0,j=0  {1,2} 
        //            {

        //                //if (j == 0)
        //                //{
        //                //    break;
        //                //}
        //                //else
        //                //{
        //                i++;
        //                //}                 //  i=0  ,j=0

        //            }
        //            if (i == j && i == 1)
        //            {
        //                break;
        //            }
        //            //if (i==j&&i==0)
        //            //{
        //            //    anser[i] = arr[i];
        //            //    Console.WriteLine(anser[i]);
        //            //    i++;
        //            //    anser[i] = arr[i];
        //            //    Console.WriteLine(anser[i]);
        //            //    break;
        //            //}
        //            middle = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = middle;

        //        }
        //        //if (i == j && j == 0)
        //        //{
        //        //    anser[i + 1] = arr[i + 1];
        //        //    Console.WriteLine(anser[i + 1]);
        //        //}
        //        anser[i] = arr[i];
        //        //Console.WriteLine(anser[i]);

        //        if (i == arr.Length / 2+1 && j == arr.Length / 2+1)
        //        {
        //            //    for (int m = 0; m < arr.length; m++)
        //            //    {
        //            //        console.write(arr[m] + ",  ");
        //            //    }
        //            break;
        //        }

        //        key = arr[arr.Length / 2+1];
        //        i = arr.Length / 2+1;
        //        j = arr.Length - 1;


        //    }
        //    for (int m = 0; m < anser.Length; m++)
        //    {
        //        Console.Write(anser[m] + ",  ");
        //    }
        //}
        //        *一次排序单元，完成此方法，key左边都比key小，key右边都比key大。


        //**@param array排序数组 


        //**@param low排序起始位置 


        //**@param high排序结束位置

        //**@return单元排序后的数组
        //        private static int sortunit(int[] array, int low, int high)
        //        {
        //            int key = array[low];

        //            while (low < high)
        //            {
        //                /*从后向前搜索比key小的值*/
        //                while (array[high] >= key && high > low)
        //                    --high;
        //                /*比key小的放左边*/
        //                array[low] = array[high];
        //                /*从前向后搜索比key大的值，比key大的放右边*/
        //                while (array[low] <= key && high > low)
        //                    ++low;
        //                /*比key大的放右边*/
        //                array[high] = array[low];
        //            }
        //            /*左边都比key小，右边都比key大。//将key放在游标当前位置。//此时low等于high */
        //            array[low] = key;


        //            foreach (int i in array)
        //            {
        //                Console.Write("{0}\t", i);
        //            }
        //            Console.WriteLine();
        //            return high;
        //        }
        //        /**快速排序 
        //*@paramarry 
        //*@return */
        //        public static void sort(int[] array, int low, int high)
        //        {
        //            if (low >= high)
        //            {
        //                return;

        //            }
        //            /*完成一次单元排序*/
        //            int index = sortunit(array, low, high);

        //            /*对左边单元进行排序*/
        //            sort(array, low, index - 1);
        //            /*对右边单元进行排序*/
        //            sort(array, index + 1, high);
        //        }


        //static void State(int i)
        //{
        //    if (i > 3)
        //    {
        //        return;
        //    }
        //    int a=Stack(i);
        //    State(a);
        //    Console.WriteLine( "无知");
        //}


        //static int Stack(int i)
        //{
        //    i++;
        //    Console.WriteLine("第" + i + "次：你好，嵌套函数");
        //    return i;
        //}



        //值传递的引用类型
        //static void Change(int a)
        //{
        //    a++;
        //}
        //引用类型的引用类型,把自身地址的变量名字传入后，变量名字被重新定义一个新的值的地址（默认0），所以
        //现在新的age是0，和以前的age没有关系。
        ///传入的还是地址
        static void Add(ref Value wx)
        {
            wx = new Value();
            wx.age++;
            Console.WriteLine(wx.age);
        }
        static void Ca(ref int dd)
        {
            dd = dd + dd;
            Console.WriteLine(dd);
        }



    }
}
