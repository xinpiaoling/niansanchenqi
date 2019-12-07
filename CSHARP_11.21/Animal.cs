using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    class Animal
    {
        private string kind;
        public Animal()
        {
            this.kind = "person";
        }
        public virtual void Eat()
        {
            Console.WriteLine("吃饭时间到了");
        }

        dynamic i = 15;
        public Animal(string kind)
        {
            this.kind = kind;
        }

    }


       
    class CuteAttribute:Attribute   //继承自Attribute
    {
        //一般是框架提供，框架通过特性标签读取类或类成员的行为
    }



    
    [Cute]   //本质还是一个类
    internal class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("吃鱼");
        }


        [Cute]  //可以加在类或类成员的名字上，进行调用
        public int age = 1;

    }
    class Dog : Animal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("吃骨头");
        }
    }
}
