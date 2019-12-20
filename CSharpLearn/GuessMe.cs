using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    public class GuessMe
    {
        //完成“猜数字”游戏，方法名GuessMe()
        //private static int _count;
        //private static int _acturalNumber;
        //private static int _guessNumber;

        public const string Input1 = "你是一个天才！！！";
        public const string Input2 = "你登上了珠峰！！！";
        public const string Input3 = "你是一个普通人！！！";
        public const string Input4 = "你太难了，终于猜对了！！！";
        public const string Input5 = "后续可能更改的需求";
        public const string Input6 = "游戏结束！！！弱鸡";
        public const string BigInput = "大了";
        public const string SmallInput = "小了";



        public static void DoGuessMe()
        {
            int _acturalNumber = 50;//new Random().Next(1, 100);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("请输入一个整数");
                string input = Console.ReadLine();
                bool n = int.TryParse(input, out int _guessNumber);
                if (!n)
                {
                    Console.WriteLine("第" + i + "次输入错误，请输入一个整数");
                }
                else
                {
                    //_count = i;
                    if (_acturalNumber==_guessNumber)
                    {
                        GuessRight(i);
                        break;
                    }
                    else
                    {
                        GuessWrong(_acturalNumber, _guessNumber,i);
                    }
                }
            }
        }
        public static string GuessRight(int _count)
        {
            if (_count < 4)
            {
               Console.WriteLine(Input1);
               return Input1;
            }
            else if (_count < 7)
            {
                Console.Write(Input2);
                return Input2;
            }
            else if (_count < 10)
            {
                Console.Write(Input3);
                return Input3;
            }
            else if (_count == 10)
            {
                Console.Write(Input4);
                return Input4;
            }
            else
            {
                //i定义区间为1-10，不存在其他情况
                return Input5;
            }
        }
        public static string GuessWrong(int _acturalNumber, int _guessNumber,int _count)
        {
            if (_count == 10)
            {
                Console.WriteLine(Input6);
                return Input6;
            }//else do nothing
            if (_acturalNumber < _guessNumber)
            {
                Console.Write(BigInput);
                return BigInput;
            }
            else
            {
                Console.Write(SmallInput);
                return SmallInput;
            }
            
        }
    }
}
