using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    struct  Infomation
    {
        public int Name;
        public Infomation(int dd)
        {
            Name = dd;
            Score = dd + 2;

        }
        public int Score { get; set; }


    }
     public class Index
    { 
        /// <summary>
        /// 索引器
        /// </summary>
        private string[] _scores = { "csharp", "sql", "javascript" };
        //public  string this[int index] 
        //{
        //    get { return _scores[index]; }
        //    set { _scores[index] = value; }
        //}
        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] _keys = new string[Number];
        public static int Number = 10;

        public Index()
        {
            for (int i = 0; i <_keys.Length ; i++)
            {
                _keys[i] = "关键字";
            }
        }
        public string this[int index]
        {
            get 
            {
                if (index < Number && index >= 0)
                {
                    return _keys[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("会不会进来这里");
                }
            }
            set
            {
                if (index<Number && index>=0)
                {

                    _keys[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("关键字输入数量不能超过10个");
                }
               
            }
        }

    }


}
