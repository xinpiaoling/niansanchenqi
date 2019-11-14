using System;

namespace CSharpLearn
{
    class Program
    {













        static void Main(string[] args)
        {


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

        }
        //自我介绍：SelfIntroduce()
        //static void SelfIntroduce()
        //{
        //    string name = "王新";
        //    int age = 25;
        //    bool isFemal = false;
        //    double height = 17.3;
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

        //static void GuessMe()
        //{
        //    int m = new Random().Next(1, 20);
        //    for (int i = 1; i < 11; i++)
        //    {

        //        Console.WriteLine("请输入一个整数");
        //        string input = Console.ReadLine();
        //        bool n = int.TryParse(input, out int a);
        //        if (n == false)
        //        {
        //            Console.WriteLine("第" + i + "次输入错误，请输入一个整数");
        //        }
        //        else
        //        {
        //            Console.Write("第" + i + "次比较：");
        //            if (m < a)
        //            {
        //                Console.Write("大了");
        //                Console.WriteLine();
        //                if (i == 10)
        //                {
        //                    Console.WriteLine("游戏结束！！！弱鸡");
        //                }
        //                else
        //                {
        //                    do nothing
        //                }
        //            }
        //            else if (m > a)
        //            {
        //                Console.Write("小了");
        //                Console.WriteLine();
        //                if (i == 10)
        //                {
        //                    Console.WriteLine("游戏结束！！！弱鸡");
        //                }
        //                else
        //                {
        //                    do nothing
        //                }
        //            }
        //            else
        //            {
        //                if (i < 3)
        //                {
        //                    Console.Write("你是一个天才！！！");
        //                    Console.WriteLine();
        //                    break;
        //                }
        //                if (i < 6)
        //                {
        //                    Console.Write("你登上了珠峰！！！");
        //                    break;
        //                }
        //                if (i < 10)
        //                {
        //                    Console.Write("你是一个普通人！！！");
        //                    break;
        //                }
        //                if (i == 10)
        //                {
        //                    Console.WriteLine("你太难了，终于猜对了！！！");
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
