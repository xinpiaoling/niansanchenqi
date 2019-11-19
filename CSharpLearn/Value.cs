using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    public class Value
    {
        /// <summary>
        ///  引用类型的值传递
        /// </summary>
        /// <param name="age1"></param>
        public Value()
        {
    
        }

        //public Value yf = new Value(12);


        public  int age ;
        //public string name = "白云";  //不建议初始化的时候赋值
        public string name;
        internal Value(string name)
        {
            //name = "白云";
            //this.name = name;
        }
         //ctor 快捷方式，



    }
}
