using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    class Intity
    {
        protected int Id;

    }
    class Content:Intity
    {
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        protected  string kind;
        public string Kind
        {
            get
            {
                return kind;
            }
            set
            {
                if (value==null)
                {
                    Console.WriteLine("输入的值不能为空值");
                    return;
                }
                else
                {
                    kind = value;
                }
            }
        }


        public Content(string notNull)
        {

        }


        private readonly  DateTime creatTime=DateTime.Now;
        public DateTime PublishTime
        {
            get
            {
                //Console.WriteLine(creatTime);
                return creatTime;  
            }
            
        }

        public void Eat()
        {
            Console.WriteLine("它喜欢吃鱼！！！");
        }


        //public DateTime PublishTime;
        

    }
    class Problem:Content
    {
        public Problem(string notNull):base(notNull)
        {

        }
        public void method()
        {
            //new Problem().method(); 
        }
        public void Eat()
        {
            Console.WriteLine("但它有时候会很挑剔！！！");
        }
    }
    class Article:Content
    {
        public Article(string notNull) : base(notNull)
        {

        }
        public void Eat()
        {
            Console.WriteLine("有时候不喜欢吃猫粮！！！");
        }
    }
    class Suggest : Content
    {
        public Suggest(string notNull) :base(notNull)
        {
            this.kind = notNull;
        }
        public void Drink()
        {
            Console.WriteLine("偶尔给它一口饮料喝，但它不喜欢");
        }
    }
}
