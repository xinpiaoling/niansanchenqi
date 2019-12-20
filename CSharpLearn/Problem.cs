using CSHARPLearn;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    /// <summary>
    /// 求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（Publish
    /// DateTime）和作者（Author），和方法Publish()
    /// </summary>
    class Problem : Content, IAgreeOrDisagree
    {

        public User Author { get; set; }
        public int Reward { get; set; }
        public Problem(string content) : base(content)
        {

        }

        //将HelpMoneyChanged应用于Publish()方法
        //[HelpMoneyChanged(2)]
        public override void Publish()
        {
            if (Author == null)
            {
                throw new Exception();
            }
            Author.HelpMoney -= Reward;
            Console.WriteLine("棒棒币减少：" + Reward);
            _publishTime = SystemTime.Now();
        }
        public void Agree()
        {

        }
        public void Disagree()
        {

        }
    }






    //public  class Problem
    //{
    //    private string title;
    //    private string body;
    //    private int reward;
    //    private DateTime publishDateTime;
    //    User author;
    //   public string Title { get; set; }
    //   public string Body { get; set; }
    //    //修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
    //   public int Reward { 
    //        get 
    //        {
    //            return reward ;
    //        } 
    //        set 
    //        {
    //            if (value<0)
    //            {
    //                throw new ArgumentOutOfRangeException("参数越界");
    //            }
    //            reward = value;
    //        } 
    //    }
    //   public DateTime PublishDateTime { get; set; }
    //   public string Author { get; set; }
    //    //Publish()：发布一篇求助，并将其保存到数据库
    //   public string Database { get; set; }       //暂定为数据库

    //    void Publish(string problem)           
    //    {
    //        this.Database = problem;
    //    }
    //    //Load(int Id)：根据Id从数据库获取一条求助
    //    //string Load(int Id)
    //    //{

    //    //    if (Id==DatabaseId)
    //    //    {
    //    //        return Database;
    //    //    }

    //    //}

    //    //Delete()：删除某个求助
    //    //void Delete(int Id)
    //    //{
    //    //    if (Id == DatabaseId)
    //    //    {

    //    //    }
    //    //}

    //    //repoistory：可用于在底层实现上述方法和数据库的连接操作等

    //    //在这里调用仓库类的静态方法




}

