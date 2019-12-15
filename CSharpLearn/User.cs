using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    ///让User类无法被继承
     internal  sealed class User
    {
        //user.Password在类的外部只能读不能改，且为User类添加ChangePasword()方法，以修改其密码
        private string password;
        //public string Password { get; private set; }
        public void ChangePassword(string password)
        {
            this.password = password;
        }
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _name;
        public string Name
        {
            get
            {
                return _name;
                
            }
            set
            {
                if (value=="admin")
                {
                    Console.WriteLine("已改变");
                    _name = "系统管理员";
                }
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
                if (value<0)
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

    }

    //lass Wx:User
    //{

    //}


}
