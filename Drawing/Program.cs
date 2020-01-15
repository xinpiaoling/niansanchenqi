using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成验证码
            //Draw.Do ();
            //用户输入匹配
            //try
            //{
            //    string input = Console.ReadLine();
            //    if (input==null)
            //    {
            //        throw new Exception("您输入的验证码不能为空.");
            //    }
            //    Draw.DetermineDrawString(input);
            //}
            //catch (FileNotFoundException)
            //{

            //    throw;
            //}
            //finally
            //{

            //}
            //现有一个txt文件，里面存放了若干email地址，使用分号（;）或者换行进行了分隔。
            //    请删除其中重复的email地址，并按每30个email一行（行内用;分隔）重新组织
            //string path = @"C:\17bang\repeat.txt";
            ////FileStream file = File.Create(@"C:\17bang\repeat.txt");
            //string email = File.ReadAllText(path);
            //string[] Email = email.Split(';');
            //StringBuilder stringBuilders = new StringBuilder();
            //for (int i = 0; i <Email.Length; i++)
            //{
            //    if (Email.Count(c => c == Email[i]) == 1)
            //    {
            //        stringBuilders.Append(Email[i]+";");
            //    }
            //    //if (i%30==0)
            //    //{
            //    //    Console.Write("\n");
            //    //}
            //}
            //Console.WriteLine(stringBuilders.ToString());

        }


    }
}
