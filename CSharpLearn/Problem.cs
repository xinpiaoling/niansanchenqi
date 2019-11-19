using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    /// <summary>
    /// 求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（Publish
    /// DateTime）和作者（Author），和方法Publish()
    /// </summary>
    class Problem
    {
        //属性
        internal string name;
        internal string Name
        {

            get
            {
                return "举世无双" + name;
            }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("姓名不能为空");
                    return;
                }

                //this.Name = Name;
                name = value; 
            }

        }

        public Problem(string name)
        {
            //this.name = name;

        }




    }
}
