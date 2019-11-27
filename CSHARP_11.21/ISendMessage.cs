using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），
    //用Console.WriteLine() 实现Send()。
    //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
    //假设User类同时继承了ISendMessage和IChat，如何处理？
    //标明继承的方法是哪一个接口的即可
    interface ISendMessage
    {
        void send();
    }
    interface IChat
    {
        void send();
    }
    class EmailMessag : ISendMessage,IChat
    {
        void IChat.send()
        {
            throw new NotImplementedException();
        }

        void ISendMessage.send()
        {
            Console.WriteLine("这是邮箱的信息");
        }

    }
    class DBMessage : ISendMessage

    {
        public void send()
        {
            Console.WriteLine("这是数据库的信息");
        }
    }
    
}
