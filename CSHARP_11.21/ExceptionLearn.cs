using System;

namespace CSHARP_11._21
{
    class ExceptionLearn:Exception
    {
        public void OutputScore(double score)
        {
            //业务逻辑错误是 bug，不是异常
            //指明类型的错误要放在前面
            //总是在程序入口（顶层方法）处catch未捕获的异常
            //不知道如何处理的情况，就不要处理

            if (score<0||score>100)
            {
                throw new Exception("分数输入错误：请输入0-100的数字");
            }

            try
            {
                DateTime today = new DateTime(1999,13,20);
                Console.WriteLine(today);
            }
             catch (IndexOutOfRangeException)   //索引超出范围异常
            {
                Console.WriteLine("超出范围");
                throw;           // 表示已阅，再次抛出错误。也可以不抛出，吞掉异常
            }
            catch (InvalidCastException)   //无效转换异常
            {

            }
            finally     //最后一定会执行的文件    
            {

                Console.WriteLine("最终执行的工作");
                //一般是用来清理文件，，关闭文件进程
            }
        }


    }
}
