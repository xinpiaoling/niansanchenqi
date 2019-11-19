using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    class HelpMoney
    {
        public string Name { get; set; }  //C#.net简写方法

        //C#常规属性写法：用于内部有变化的时候 

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
       
    }
}
