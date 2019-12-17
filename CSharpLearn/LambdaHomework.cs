using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
        public delegate int ProvideWater<T>(T name);
    public class LambdaHomework<T> where T:Person
    {
        //1.声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
        //2.使用：
        //        方法
        //        匿名方法
        //        lambda表达式
        //给上述委托赋值，并运行该委托
        //3.声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出

        public static int GetWater<T>(T name)
        {
            Console.WriteLine("竹篮打水一场空");
            return 1;
        }
    }
     public  class Person
    {

    }
}
