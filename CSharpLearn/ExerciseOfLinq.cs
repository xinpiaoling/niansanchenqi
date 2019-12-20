using CSHARPLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLearn
{
    public static class ExerciseOfLinq
    {

        static User fg, xy;
        static Keyword sql, csharp, net, java, js;
        static Article Sql, Java, Js, Csharp;
        static Comment wx, atai, pzq, cy;
        static IEnumerable<Article> articles;
        static ExerciseOfLinq()
        {
            //在之前“文章 / 评价 / 评论 / 用户 / 关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：

            //找出“飞哥”发布的文章
            //找出2019年1月1日以后“小鱼”发布的文章
            //按发布时间升序 / 降序排列显示文章
            //统计每个用户各发布了多少篇文章
            //找出包含关键字“C#”或“.NET”的文章
            //找出评论数量最多的文章


            //给User赋值
            fg = new User() { Name = "飞哥" };
            xy = new User() { Name = "小余" };
            //给Keyword赋值
            csharp = new Keyword() { Content = "C#", Used = 2 };
            net = new Keyword() { Content = ".net", Used = 1 };
            sql = new Keyword() { Content = "SQL" };
            js = new Keyword() { Content = "javascript" };
            java = new Keyword() { Content = "java" };
            //给Article赋值
            Sql = new Article("文章") { Title = "Sql", Author = fg, Words = 2015, Keyword = new List<Keyword> { csharp, java } };
            Csharp = new Article("文章") { Title = "Csharp", Author = fg, Words = 11122, Keyword = new List<Keyword> { net, sql } };
            Js = new Article("文章") { Title = "Js", Author = xy, Words = 7502, Keyword = new List<Keyword> { js, java } };
            Java = new Article("文章") { Title = "Java", Author = fg, Words = 2019, Keyword = new List<Keyword> { net, sql } };
            //给Comment赋值
            wx = new Comment(Sql) { Body = "写的很真实" };
            atai = new Comment(Js) { Body = "写的很一般" };
            pzq = new Comment(Sql) { Body = "写的比较差" };
            cy = new Comment(Java) { Body = "写的太偏激" };
            //给Article赋值
            Sql.Comments = new List<Comment>() { wx, pzq };
            Js.Comments = new List<Comment>() { atai };
            Java.Comments = new List<Comment>() { cy };
            Csharp.Comments = new List<Comment>() { };

            //“文章”集合
            articles = new List<Article> { Sql, Csharp, Js, Java };
            //实际状态
            //IEnumerable<Article> articles = new List<Article> 
            //{   Sql,//Title="Sql",Author=new User(){Name="飞哥"},
            //        //Keyword=new List<Keyword>{new Keyword(){Content="C#",Used=2},
            //        //new Keyword(){Content="Java"},
            //        //Comments=new List<Comment>{new Comment(sql){Body="写的很真实"},new Comment(sql){Body="写的比较差"}}}
            //    Csharp,
            //    Js,
            //    Java 
            //};
            //发布文章
            Sql.Publish();
            Csharp.Publish();
            Js.Publish();
            Java.Publish();

        }

        //外部调用入口方法
        public static void ExerciseOfLinqDo()
        {
            ArticleByFeiGe();
            ArticlesByXiaoYuByTime();
            ArticlesByTimeAsc();
            ArticlesByTimeDesc();
            ArticleByAuthorCount();
            ArticleByFindKeyword();
            ArticleByMostComments();
        }
        //找出“飞哥”发布的文章
        private static void ArticleByFeiGe()
        {
            var feiArticle = from a in articles
                             where a.Author.Name == "飞哥"
                             select a;
            var feiArticle1 = articles
                              .Where(a => a.Author.Name == "飞哥");
            foreach (var item in feiArticle)
            {
                Console.WriteLine(item.Author.Name + item.Words);

            }
        }
        //找出2019年1月1日以后“小鱼”发布的文章
        private static void ArticlesByXiaoYuByTime()
        {
            var ArticlesByXiaoYuByTime = from a in articles
                                         where a.PublishTime > new DateTime(2019 / 1 / 1) && a.Author.Name == "小余"
                                         select a;
            var ArticlesByXiaoYuByTime1 = articles.
                                      Where(a => a.PublishTime > new DateTime(2019 / 1 / 1) && a.Author.Name == "小余");
            foreach (var item in ArticlesByXiaoYuByTime)
            {
                Console.WriteLine(item.Author.Name + "  " + item.Words);
            }
        }

        //按发布时间升序
        private static void ArticlesByTimeAsc()
        {
            var ArticlesByTimeAsc = from a in articles
                                    orderby a.PublishTime ascending
                                    select a;
            var ArticlesByTimeAsc1 = articles.OrderBy(a => a.PublishTime);
            foreach (var item in ArticlesByTimeAsc)
            {
                Console.WriteLine(item.Author.Name + "  " + item.Words);
            }
        }
        // 降序排列显示文章
        private static void ArticlesByTimeDesc()
        {
            var ArticlesByTimeDesc = from a in articles
                                     orderby a.PublishTime descending
                                     select a;
            var ArticlesByTimeDesc1 = articles.OrderByDescending(a => a.PublishTime);
            foreach (var item in ArticlesByTimeDesc)
            {
                Console.WriteLine(item.Author.Name + "  " + item.Words);
            }
        }
        //统计每个用户各发布了多少篇文章
        private static void ArticleByAuthorCount()
        {
            var ArticleByAuthorCount = from a in articles
                                       group a by a.Author.Name into an
                                       select new
                                       {
                                           Author = an.Key,
                                           count = an.Count()
                                       };
            var ArticleByAuthorCount1 = articles.GroupBy(a => a.Author.Name)
                                         .Select(ag => new
                                         {
                                             Key = ag.Key,
                                             Count = ag.Count()
                                         });
            foreach (var item in ArticleByAuthorCount)
            {
                Console.WriteLine(item.Author + "  " + item.count);
            }
        }
        //找出包含关键字“C#”或“.NET”的文章
        private static void ArticleByFindKeyword()
        {
            var ArticleByFindKeyword = from a in articles
                                       where a.Keyword.Contains(net) || a.Keyword.Contains(csharp)
                                       select a;
            var ArticleByFindKeyword1 = articles.Where(a => a.Keyword.Contains(net) || a.Keyword.Contains(csharp));
            foreach (var item in ArticleByFindKeyword)
            {
                Console.WriteLine(item.Author.Name + "------" + item.Words);
            }
        }
        //找出评论数量最多的文章
        private static void ArticleByMostComments()
        {
            var ArticleByMostComments = (from a in articles
                                         orderby a.Comments?.Count() descending
                                         select a).First();
            var ArticleByMostComments1 = (articles.OrderByDescending(a => a.Comments.Count())).First();
            Console.WriteLine(ArticleByMostComments.Title);
        }
        //找出每个作者评论数量最多的文章
        private static void ArticlesByAuthorMostComments()
        {
            var ArticlesByAuthorMostComments = from a in articles
                                               group a by a.Author into ag
                                               select (from aga in ag
                                                       orderby aga.Comments.Count
                                                       select aga).First();
        }
        //找出每个作者最近发布的一篇文章
        private static void ArticlesByAuthorRecently()
        {
            Console.WriteLine("---------");
            //var ArticlesByAuthorRecently=from a in articles
            //                             group a by a.Author.Name into ag
            //                             orderby ag.
            var ArticlesByAuthorRecently = articles.GroupBy(a => a.Author.Name)
                                          .Select(ag => new
                                          {
                                              Recently = ag.Max(a => a.PublishTime)
                                          });
            foreach (var item in ArticlesByAuthorRecently)
            {
                Console.WriteLine(item.Recently);
            }
        }

        //为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的文章作者

    }
}
