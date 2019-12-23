using System;
using System.Collections.Generic;
using System.Linq;
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
                new XComment("以下存放所有“源栈”文章"),
                new XElement("article"
                     , new XAttribute("isDraft", "false")
                     , new XElement("id", 1)
                     , new XElement("title", "源栈培训：C#进阶-7：Linq to XML")
                     , new XElement("body", "什么是XML（EXtensible Markup" +
                     " Language）是一种文本文件格式被设计用来传输和存储数据" +
                     "由：标签和属性组成元素（节点），由元素组成“树状结构”" +
                     "必须有而且只能有一个根节点其他：")
                     , new XElement("authorId", 1)
                     , new XElement("publishDate", "2019/6/18 18:15")
                     , new XElement("comments"
                         , new XElement("comment"
                             , new XAttribute("recommend", "true")
                             , new XElement("id", 12)
                             , new XElement("body", "不错，赞！")
                             , new XElement("authorId", 2))
                         , new XElement("comment"
                              , new XElement("id", "14")
                              , new XElement("body", "作业太难了")
                              , new XElement("authorId", 3)
                                       )
                                  )
                           ),
                new XElement("article"
                    , new XAttribute("isDraft", "true")
                        , new XElement("id", 2)
                        , new XElement("title", "源栈培训：C#进阶-6：异步和并行")
                        , new XElement("authorId", "1"))
                );
            Console.WriteLine(homework);
            //然后，将其以文件形式存放到磁盘中；
            homework.Save("C:\\17bang\\luckystack.xml");
            //再从磁盘中读取到内存中。
            XElement element = XElement.Load("C:\\17bang\\luckystack.xml");
            //在根节点下添加一个新的article元素，内容至少包含id、title和authorId
            Console.WriteLine("-------");
            homework.Add(new XElement("article"
                           , new XElement("title")
                           , new XElement("body")
                           , new XElement("AuthorId")));
            Console.WriteLine(homework);
            Console.WriteLine("------------------------------------");
            //Console.WriteLine(homework.Element("article").Attribute("isDraft"));
            //删除id = 12的评论
            var selectHomework = from e in homework.Descendants()
                                 where e.Name == "id"
                                 where e.Value == "12"
                                 select e;
            //XElement idCard = (from a in articles.Descendants("comment")
            //                   where a.Element("id").Value == "12"
            //                   select a).Single();
            IList<XElement> IselectHomework = selectHomework.ToList();
            foreach (var item in IselectHomework)
            {
                item.Parent.Remove();
            }
            Console.WriteLine(homework);
            homework.Save("C:\\17bang\\luckystack.xml");
            Console.WriteLine("--------------------");
            //改变id = 2的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行
            var IdHomework = from h in homework.Descendants()
                             where h.Name == "id"
                             where h.Value == "2"
                             select h;
            IList<XElement> IIdHomework = IdHomework.ToList();
            foreach (var item in IIdHomework)
            {
                item.Parent.SetAttributeValue("isDraft","false");
                item.Parent.SetElementValue("title", "源栈培训：C#进阶-8：异步和并行");
            }
            Console.WriteLine(homework);

        }
    }
}
