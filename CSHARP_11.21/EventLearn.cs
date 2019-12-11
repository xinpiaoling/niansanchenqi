using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    public delegate void ChangeNumber();

    class EventLearn
    {
        public event ChangeNumber Click;

        public void OnClick()
        {
            if (Click!=null)
            {
                Click();
                Console.WriteLine("事件完成");
            }
            else
            {
                Console.WriteLine("事件上没有绑定方法");
            }
        }
        public static void UserClick()
        {
            Console.WriteLine("用户点击触发的事件");
        }
        public static void TeacherClicl()
        {
            Console.WriteLine("老师触发的事件");
        }
    }
}
