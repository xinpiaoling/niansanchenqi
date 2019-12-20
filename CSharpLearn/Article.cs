using CSHARPLearn;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
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
            _publishTime = SystemTime.Now();
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
}
