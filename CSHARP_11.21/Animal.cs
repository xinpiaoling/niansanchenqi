using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    class Animal
    {
        public  virtual  void Eat()
        {
            Console.WriteLine("吃饭时间到了");
        }

    }
    class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("吃鱼");
        }
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
