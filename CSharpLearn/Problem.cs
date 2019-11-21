using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    /// <summary>
    /// 求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（Publish
    /// DateTime）和作者（Author），和方法Publish()
    /// </summary>
    class Problem
    {
        private string title;
        private string body;
        private int reward;
        private DateTime publishDateTime;
        User author;
       public string Title { get; set; }
       public string Body { get; set; }
       public int Reward { get; set; }
       public DateTime PublishDateTime { get; set; }
       public string Author { get; set; }

        void Publish()
        {

        }
    }
}
