using CSharpLearn;
using System;
using System.Collections.Generic;


namespace CSHARPLearn
{
    interface IAgreeOrDisagree
    {
        void Agree();
        void Disagree();
    }
    internal abstract class Content
    {
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        protected string kind;
        public Content(string content)
        {
            //在NEW一个对象时通过子类调用父类构造为createTime赋值
            _createTime = DateTime.Now;
            if (content == string.Empty)
            {
                Console.WriteLine("不能为空值");
                return;
            }
            else
            {
                this.kind = content;
            }
        }
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                //确保文章（Article）的标题不能为null值
                //，也不能为一个或多个空字符组成的字符串
                //，而且如果标题前后有空格，也予以删除
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("_title is not null!");
                }
                else
                {
                    _title = value.Trim();
                }
            }
        }
        protected DateTime _createTime;
        public DateTime CreateTime { get { return _createTime; } }

        protected DateTime _publishTime;
        public DateTime PublishTime { get { return _publishTime; } }
        public User Author { get; set; }
        public int AgreeCount { get; set; }
        public int DisagreeCount { get; set; }
        public string[] _keyword { get; set; }
        public abstract void Publish();

    }
   




    //添加一个新类ContentService，其中有一个发布（Publish()）方法：
    //如果发布Article，需要消耗一个帮帮币
    //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币
    //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，
    //赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？




    //将TokenManager作为User类的属性
    // internal class User
    //{
    //    public int HelpMoney { get; set; }

    //    public static implicit operator User(CSharpLearn.User v)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    //public TokenManager Manger { get; set; }
    //}
    //之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
    //想一想他们应该在哪里赋值比较好，并完成相应代码

}
