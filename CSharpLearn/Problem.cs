﻿using System;
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
        //Publish()：发布一篇求助，并将其保存到数据库
       public string Database { get; set; }       //暂定为数据库

        void Publish(string problem)           
        {
            this.Database = problem;
        }
        //Load(int Id)：根据Id从数据库获取一条求助
        //string Load(int Id)
        //{

        //    if (Id==DatabaseId)
        //    {
        //        return Database;
        //    }

        //}

        //Delete()：删除某个求助
        //void Delete(int Id)
        //{
        //    if (Id == DatabaseId)
        //    {

        //    }
        //}

        //repoistory：可用于在底层实现上述方法和数据库的连接操作等

        //在这里调用仓库类的静态方法

    }
}