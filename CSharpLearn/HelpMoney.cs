using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{


    class HelpMoney
    {/// <summary>
    /// 属性是字段的封装
    /// </summary>
        public string Name { get; set; }  //C#.net简写方法

        //C#常规属性写法：用于内部有限制条件的时候使用
       

        private string teacher;
        public string Teacher            
        {
            get{
                return teacher;
            }
            set{
                teacher = value;

            }
        }



        public string line=string.Empty;       //指代一个空的字符串，静态的只读的字段
       // public string test;
        public string test { get { return test; } set { value = test; } }
        
        public HelpMoney(string line)
        {
            this.line = line;    //this解决了重名冲突的问题。使用this就会表明this.line是一个字段，不写this的话系统会识别line为参数
        }
        // public string GetLength()
        //{
        //    return Line;
        //}

    }

}
