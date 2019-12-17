﻿using CSharpLearn;
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
        public string Title { get; set; }
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
            _publishTime = DateTime.Now;
        }
        public void Agree()
        {

        }
        public void Disagree()
        {

        }
    }
    internal class Article : Content, IAgreeOrDisagree
    {

        public List<Keyword> Keyword { get; set; }//文章有多个关键字
        public List<Comment> Comments { get; set; }//文章有多个评论

        //public User Author { get; set; }
        public int Words { get; set; }
        public Article(string content) : base(content)
        {

        }

        public override void Publish()
        {
            if (Author == null)
            {
                throw new ArgumentNullException("作者不能为空");
            }
            Author.HelpMoney -= 1;
            _publishTime = DateTime.Now;
        }

        public void Agree()
        {
            Author.HelpMoney += 1;

        }

        public void Disagree()
        {
            Author.HelpMoney -= 1;

        }
    }
    internal class Suggest : Content
    {
        public User Author { get; set; }
        public Suggest(string content) : base(content)
        {

        }
        public override void Publish()
        {
            if (Author == null)
            {
                throw new ArgumentNullException("作者不能为空");
            }
            _publishTime = DateTime.Now;
        }
        public void Agree(User voter)
        {
            Author.HelpMoney += 1;
        }
        public void Disagree(User voter)
        {
            Author.HelpMoney -= 1;
        }
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
