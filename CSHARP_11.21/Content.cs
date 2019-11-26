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
        public Content(string  content)
        {
            if (content==string.Empty)
            {
                Console.WriteLine("不能为空值");
            }
            else
            {
                this.kind = content;
            }
        }


 

        
        //private DateTime PublishTime
        //{
        //    get
        //    {
        //        //Console.WriteLine(creatTime);
        //        return creatTime;  
        //    }
            
        //}

 
        

    }
    class Problem:Content
    {
        public Problem(string content):base(content)
        {

        }
  
    }
    class Article:Content
    {
        public Article(string content) : base(content)
        {

        }
 
    }
    class Suggest : Content
    {
        public Suggest(string content) :base(content)
        {
           
        }

    }
}
