using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {          
            //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            //随机字符串
            //混淆用的各色像素点
            //混淆用的直线（或曲线）
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.AliceBlue);
            Random random1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(new Pen(Color.Black), new Point(random1.Next(200)
                    , random1.Next(100)),
                    new Point(random1.Next(200),
                    random1.Next(100)));
                Thread.Sleep(1);
            }
            g.DrawString(
                Program.GetDrawString(),
                new Font("宋体",50),
                new SolidBrush(Color.Black),
                new PointF(30, 10));
            
            //随机点
            for (int i = 0; i < 200; i++)
            {
             
                image.SetPixel(random1.Next(200),
                    random1.Next(100), 
                    Color.FromArgb(random1.Next(255),
                      random1.Next(255),
                      random1.Next(255)));
                Thread.Sleep(1);
            }
            image.Save(@"C:\17bang\hello.jpg", ImageFormat.Jpeg);
        }
        //得到随机字符串
        static string GetDrawString()
        {
            string stringRepoistory = "abcdefgSHGKNSKC12389713";
            char[] temp = stringRepoistory.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int random = new Random().Next(0, temp.Length - 1);
                stringBuilder.Append(temp[random]);
                Thread.Sleep(15);
            }
            string drawString = stringBuilder.ToString();
            return drawString;
        }
    }
}
