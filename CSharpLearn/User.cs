using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    class User
    {
        //user.Password在类的外部只能读不能改，且为User类添加ChangePasword()方法，以修改其密码
        public string Password { get; private set; }
        public void ChangePassword(string password)
        {
            this.Password = password;
        }
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        //private string name;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value=="admin")
                {
                    Name = "系统管理员";
                }
            }
        }
        
    }


}
