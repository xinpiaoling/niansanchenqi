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

            //Problem tom = new Problem("val");
            //tom.Kind="cat";
            //Console.WriteLine("tom出生的日期:"+tom.PublishTime);
            //Problem jack = new Problem("val");
            //jack.method();
            //Console.WriteLine("它是一只："+tom.Kind);
            //Article myl = new Article("val");
            //Console.WriteLine("-------------------------");

            //Content Father = new Content("val");
            //Father.Eat();
            //tom.Eat();
            //myl.Eat();

            //Add BOX1 = new Add();
            //Add BOX2 = new Add();
            //Add BOX3 = new Add();
            //BOX1.SetA (10);
            //BOX1.SetB (15);
            //BOX2.SetA (100);
            //BOX2.SetB (150);
            //BOX3 = BOX2 + BOX1;
            //Console.WriteLine(BOX3.GetA());
            //Console.WriteLine(BOX3.GetType());



            Animal[] animals = new Animal[3];
            animals[0] = new Animal();
            animals[1] = new Cat();
            animals[2] = new Dog();
            for (int i = 0; i <animals.Length ; i++)
            {
                animals[i].Eat();
            }
            
        }
    }
    class Add
    {

        //private int a;
        //private int b;

        //public void SetA(int a)
        //{
        //    this.a = a;
        //}
        //public void SetB(int b)
        //{
        //    this.b = b;
        //}
        //public int GetA()
        //{
        //    return a;
        //}


        /// <summary>
        /// 运算符重载是对相同的参数类型，根据同一方法名和运算符的不同组合进行运算，达到重载的作用。
        /// 实际上还是在方法内部对对象的值类型参数进行了运算。
        /// 
        /// </summary>
        /// <param name="Box1"></param>
        /// <param name="Box2"></param>
        /// <returns></returns>
        //public static Add operator+(Add Box1, Add Box2)
        //{
        //    Add Box3 = new Add();
        //    Box3.a = Box1.a + Box2.a;
        //    Box3.b = Box1.b + Box2.b;
        //    return Box3; 
        //}
       
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
