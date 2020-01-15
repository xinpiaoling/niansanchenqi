using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;      

namespace CSharpLearn
{
     class Repoistory<T>
    {
        //    定义一个仓库（Repoistory）类，其中包含：
        //    一个int类型的常量version
        public const  int verison=10;
        //一个静态只读的字符串connection，以后可用于连接数据库

        public static readonly string connection;

        //思考Respoitory应该是static类还是实例类更好
        //think:静态类通常用于对于静态的方法进行分类。
        //仓库用于存储、调用、修改数据。方法是使用SQL SERVER查询固定方法，所以应该使用静态类



    }
    //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
    public class FactoryContext
    {
        public  int num;
        public static int num2;
        public void Count()
        {
            num2++;
        }
        public int getNum()
        {
            return num2;
        }

        //尝试using System.Console
        public void Try()
        {
            WriteLine("");
        }



        //子类继承父类的字段，属性，构造函数，方法
        //子类是单一继承，不能继承两个以上的类，但可以继承多个接口
        //使用private就不能继承。
        public class Store : FactoryContext
        {
            internal int field;
            public Store()
            {
              
            }
        }


    }
}
