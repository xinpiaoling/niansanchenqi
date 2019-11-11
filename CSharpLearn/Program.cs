using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //用变量name存储你的姓名，然后输出带有你姓名的入栈口号
            string name = "王新";
            Console.WriteLine(name);
            //在“入栈口号”的基础上，使用变量Age（年龄）、
            //IsFemale（是否男生）、
            //Height（身高，单位米）、
            //FromCity（来自哪里）存储你的个人信息，并在控制台逐行输出
            int Age = 25;
            bool IsFemal = false;
            double Height = 173.5;
            string FromCity = "宁夏";
            Console.WriteLine(name+ "学习C#");
            Console.WriteLine(Age);
            Console.WriteLine(IsFemal);
            Console.WriteLine(Height + "米");
            Console.WriteLine(FromCity);

            //输出两个整数 / 小数的和 / 差 / 积 / 商






            //电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（精确到小数点以后x位）








            //int Score = 80;
            //string[] Name = { "彭志强", "余伟谦", "陈元", "jimmy" };

            //if (Score>60) {
            //    Console.WriteLine("passed");
            //}
            //else
            //{
            //    Console.WriteLine("failed");
            //}
            //for (int i = 0; i < Name.length; i++)
            //{
            //    Console.WriteLine(Name[i]);
            //}
            double[] Scores = { 80, 50, 4, 62 };
        for (int i = 0; i<Scores.Length; i++)
			{
            Console.WriteLine(Scores[i]);
			}
        }
    }
}
