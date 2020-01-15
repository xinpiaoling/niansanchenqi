using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drawing
{
    public class Draw
    {
        private static string drawString;

        public static void Do()
        {
            //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            //随机字符串
            //混淆用的各色像素点
            //混淆用的直线（或曲线）
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.AliceBlue);
            Random random1 = new Random();

            Draw.GetDrawLine(g, random1);

            Draw.GetDrawString(g);

            //随机点
            Draw.GetDrawSetPixel(image, random1);

            image.Save(@"C:\17bang\hello.jpg", ImageFormat.Jpeg);
        }
        //将生成验证码的代码拆分成若干个方法，并为其添加异常机制，要求能够：
        //显式的抛出一个自定义异常
        //捕获并包裹一个被抛出的异常，记入日志文件，然后再次抛出
        //根据不同的异常，给用户相应的友好的异常提示
        //使用using释放文件资源
        /// <summary>
        /// 得到随机字符串
        /// </summary>
        /// <returns></returns>
        static void GetDrawString(Graphics g)
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
             drawString = stringBuilder.ToString();

            g.DrawString(
                drawString,
               new Font("宋体", 50),
               new SolidBrush(Color.Black),
               new PointF(30, 10)

           );
        }
        /// <summary>
        /// 随机点
        /// </summary>
        /// <param name="image"></param>
        /// <param name="random1"></param>
        static void GetDrawSetPixel(Bitmap image, Random random1)
        {
            for (int i = 0; i < 200; i++)
            {

                image.SetPixel(random1.Next(200),
                               random1.Next(100),
                               Color.FromArgb(random1.Next(255),
                                              random1.Next(255),
                                              random1.Next(255)
                                              )
                               );
                Thread.Sleep(1);
            }
        }
        /// <summary>
        /// 随机直线
        /// </summary>
        static void GetDrawLine(Graphics g, Random random1)
        {
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(new Pen(Color.Black), new Point(random1.Next(200)
                    , random1.Next(100)),
                    new Point(random1.Next(200),
                    random1.Next(100)));
                Thread.Sleep(1);
            }

        }
        public  static bool DetermineDrawString(string input)
        {
            if (drawString==input)
            {
                Console.WriteLine("恭喜您输入的验证码正确.");
                return true;
            }
            else
            {
                Console.WriteLine("很遗憾您输入的验证码有误.");
                return false;
            }
            
        }
    }
}
