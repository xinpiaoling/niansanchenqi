using System;
using System.Collections.Generic;
using System.Text;
using CSharpLearn;

namespace CSharpLearn
{
    ///让User类无法被继承
    internal sealed class User
    {
        //user.Password在类的外部只能读不能改，且为User类添加ChangePasword()方法，以修改其密码
        private string _password;
        public string Password { get; private set; }
        public void ChangePassword(string password)
        {
            //确保用户（User）的密码（Password）：
            //长度不低于6
            //必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成

            if (password.Length <= 6)
            {
                throw new Exception("密码长度不可以低于6位");
            }
            if (!PasswordCheck.PasswordCheckMethod(password))
            {
                throw new Exception("密码必须由大小写英语单词、数字" +
                    "和特殊符号（~!@#$%^&*()_+）组成");
            }
            this._password = password;
        }

        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _name;
        public string Name
        {
            //设计一个适用的机制，能确保用户（User）的昵称（Name）
            //不能含有admin、17bang、管理员等敏感词。
            get
            {
                return _name;

            }
            set
            {
                if (value.Contains("admin") || value.Contains("17bang") || value.Contains("管理员"))
                {
                    throw new Exception("不可以含有admin、17bang、管理员等敏感词");
                }
                //if (value=="admin")
                //{
                //    Console.WriteLine("已改变");
                //    _name = "系统管理员";
                //}
                else
                {
                    _name = value;
                }
            }
        }
        //problem.Reward不能为负数
        private int reward;
        public int Reward
        {
            get
            {
                return reward;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("reward不能为负数");
                }
                else
                {
                    reward = value;
                }
            }
        }
        public int HelpMoney { get; set; }

        //public static implicit operator User(CSharpLearn.User v)
        //{
        //    throw new NotImplementedException();
        //}
        //public TokenManager Manger { get; set; }
        //判断是否含有大小写字母和特殊符号

    }

    //lass Wx:User
    //{

    //}

}
