using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    public class StringMethod
    {
        //不使用string自带的Join()方法，定义一个mimicJoin()方法，
        //    能将若干字符串用指定的分隔符连接起来，
        //    比如：mimicJoin("-","a","b","c","d")，其运行结果为：
        public static string _character = "-"; 
        public static string[] _array = new string[] {"a","b","c","d" };
        public static string _result;
        public static string  MimicJoin(string Character, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i==0)
                {
                    _result = array[i] + Character;
                }
                else if (i==array.Length-1)
                {
                    _result = _result + array[i];
                }
                else
                {
                    _result = _result + array[i] + Character;
                }
            }
            Console.WriteLine(_result);
            return _result;
        }
        //实现GetCount(string container, string target)方法，
        //可以统计出container中有多少个target
        public static int GetCount(string container,string target)
        {
            if (string.IsNullOrEmpty(container) || string.IsNullOrEmpty(target))
            {
                throw new Exception("container and target  is not allow  Null or Empty");
            }
            if (container.Length<target.Length)
            {
                throw new Exception("contain length is not less than target length ");
            }
            char[] containerChar = container.ToCharArray();
            int count = 0;
            for (int i = 0; i <= containerChar.Length - target.Length; i++)
            {
                string containerSub = container.Substring(i, target.Length);
                if (containerSub.Contains(target))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
