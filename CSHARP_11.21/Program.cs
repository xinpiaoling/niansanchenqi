using System;

namespace CSHARP_11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Child ch = new Child();
            //Father td = new Father();

            //ch.height = 15;
            //ch.width = 10;
            //ch.Date = "2019年11月21日21:36:48";
            //Console.WriteLine(ch.Add());
            //Console.WriteLine(ch.Adds(100));
            //Console.WriteLine(td.Add());
            //Console.WriteLine("很奇怪的用法{0}");
            //Father should = new Father();
            //should.Eat();
            // should = new Child();
            //should.Eat();

            Problem tom = new Problem("val");
            tom.Kind="cat";
            Console.WriteLine("tom出生的日期:"+tom.PublishTime);
            Problem jack = new Problem("val");
            jack.method();
            Console.WriteLine("它是一只："+tom.Kind);
            Article myl = new Article("val");
            Console.WriteLine("-------------------------");

            Content Father = new Content("val");
            Father.Eat();
            tom.Eat();
            myl.Eat();


            
        }
    }

    //class Father
    //{
    //    internal virtual void Eat()
    //    {
    //        Console.WriteLine("父亲吃饭！！");
    //    }
    //}
    //class Child : Father
    //{
    //    internal override void Eat()
    //    {
    //        Console.WriteLine("孩子吃饭");
    //    }
    //}
}
