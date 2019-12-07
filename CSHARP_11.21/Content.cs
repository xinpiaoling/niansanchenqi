using System;


namespace CSHARP_11._21
{
    interface IAgreeOrDisagree
    {
        void Agree();
        void Disagree();
    }
    abstract class Content
    {
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        public  string kind;
        public Content(string  content)
        {
            if (content==string.Empty)
            {
                Console.WriteLine("不能为空值");
                return;
            }
            else
            {
                this.kind = content;
            }
        }

        private DateTime createTime;
        public abstract DateTime PublishTime();
        public User Author { get; set; }
        public abstract void Publish();
    }
    class Problem:Content,IAgreeOrDisagree
    {

        public User Author { get; set; }
        public int Reward { get; set; }
        public Problem(string content):base(content)
        {

        }
        public override DateTime PublishTime()
        {
            throw new NotImplementedException();
        }
        //将HelpMoneyChanged应用于Publish()方法
        [HelpMoneyChanged(2)]
        public override void Publish()
        {
           Author.HelpMoney -= Reward;
        }
        public void Agree()
        {
            
        }
        public void Disagree()
        {

        }
    }
    class Article:Content,IAgreeOrDisagree
    {
        public User Author { get; set; }
        public Article(string content) : base(content)
        {

        }
        public override DateTime PublishTime()
        {
            throw new NotImplementedException();
        }
        public override   void Publish()
        {
            Author.HelpMoney -= 1;
        }

        public void Agree()
        {
            Author.HelpMoney += 1;
            //评价者的帮帮点不会
        }

        public void Disagree()
        {
            Author.HelpMoney -= 1;

        }
    }
    class Suggest : Content
    {
        public User Author { get; set; }
        public Suggest(string content) :base(content)
        {
           
        }
        public override DateTime PublishTime()
        {
            throw new NotImplementedException();
        }
        public override void Publish()
        {
            
        }
    }


    //添加一个新类ContentService，其中有一个发布（Publish()）方法：
    //如果发布Article，需要消耗一个帮帮币
    //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币
    //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，
    //赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？


    class ContentService
    {
        public virtual void Publish(Content content)
        {
            content.Publish();
        }
    }

    //将TokenManager作为User类的属性
    class User
    {
        public int HelpMoney { get; set; }
        public TokenManager Manger { get; set; }
    }
    //之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
    //想一想他们应该在哪里赋值比较好，并完成相应代码
    
}
