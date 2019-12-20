using CSHARPLearn;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
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
            _publishTime = SystemTime.Now();
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
}
