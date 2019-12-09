using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    /// <summary>
    /// 泛型的优点：
    /// 代码重用，
    /// 类型安全，检查编译时的输入
    /// 提高性能，避免装箱拆箱
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericClassLearn<T>
    {
        public T Name;
        public T Add(T money)
        {
            Console.WriteLine("你是一个穷逼");
            return money;
        }
        //public GenericClassLearn<T>()
        //{

        //}
    }
    /// <summary>
    /// 泛型用于类，接口，方法，委托
    /// </summary>
    interface IGenericLearn
    {

    }
}
