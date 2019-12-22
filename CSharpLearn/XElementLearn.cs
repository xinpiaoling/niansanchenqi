using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CSharpLearn
{
    class XElementLearn
    {
        public static void XElementDo()
        {
            XElement classroom = new XElement(
               "classroom",
               new XComment("源栈欢迎您！！！"),
               new XElement("location", "cq",
                  new XAttribute("head", true)),
               new XElement("teachers",
                  new XElement("name", "大飞哥",
                     new XAttribute("position", "head"),
                     new XAttribute("age", 1)),
                  new XElement("name", "小余"),
                  new XElement("name", "cy")
               ));
            Console.WriteLine(classroom);
            Console.WriteLine("----------");
            XElement homework = new XElement(
                "articles",
                new XComment("以下存放所有“源栈”文章" ),
                new XElement("article"
                     ,new XAttribute("isDraft", "false")
                     ,new XElement("id",1)
                     ,new XElement("title", "源栈培训：C#进阶-7：Linq to XML")
                     ,new XElement("body", "什么是XML（EXtensible Markup" +
                     " Language）是一种文本文件格式被设计用来传输和存储数据" +
                     "由：标签和属性组成元素（节点），由元素组成“树状结构”" +
                     "必须有而且只能有一个根节点其他：")
                     ,new XElement("authorId", 1)
                     ,new XElement("publishDate", "2019/6/18 18:15")
                     ,new XElement("comments"
                         ,new XElement("comment"
                             ,new XAttribute("recommend","true")
                             ,new XElement("id",12)
                             ,new XElement("body","不错，赞！")
                             ,new XElement("authorId",2))
                         ,new XElement("comment"
                              ,new XElement("id",14)
                              ,new XElement("body","作业太难了")
                              ,new XElement("authorId",3)
                                       )
                                  )
                           ),
                new XElement("article"
                    ,new XAttribute("isDraft", "true")
                        ,new XElement("id",2)
                        ,new XElement("title", "源栈培训：C#进阶-6：异步和并行")
                        ,new XElement("authorId","1"))
                );
            Console.WriteLine(homework);
        }
    }
}
