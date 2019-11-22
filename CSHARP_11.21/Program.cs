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
            Console.WriteLine("很奇怪的用法{0}");


            Console.WriteLine("Hello World!");
        }
    }

    class Father
    {
        public int width;
        public int height;
        public int Add()
        {
            return width + height;
        }
        public string Date { get; set; }
    }
    class Child : Father
    {
        public string Adds(int par)
        {
            return Date + par;
        }
    }
}
