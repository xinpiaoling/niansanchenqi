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
        public static int score;
        public Index()
        {

        }
        public Index(int para)
        {
            score = para;
        }

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
        private string[] _keys = {"csharp","sql","javascript",".net","mvc","json","bootstrap" };
        public string this[int index]
        {
            get { return _keys[index]; }
            set { _keys[index] = value; }
        }

    }


}
