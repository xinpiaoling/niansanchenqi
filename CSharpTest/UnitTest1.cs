using NUnit.Framework;
using CSHARP_11._21;

namespace Tests
{
    public class DoubleLinkedTest
    {
        [SetUp]//测试之前运行
        public void Setup()
        {
        }

        [Test]//测试的时候运行
        public void Test1()
        {
            //assert断言
            Assert.Pass();
        }
        [Test]

        public void InsertAfter()
        {
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current1 = new DoubleLinked();
            
            current1.InserAfter(old);
            //old - current1

            Assert.AreEqual(current1.Previous,old);
            Assert.AreEqual(old.Next, current1);

            DoubleLinked current2 = new DoubleLinked();
            current2.InserAfter(old);
            //old 2 1

            Assert.AreEqual(current2.Previous,old);
            Assert.AreEqual(current2.Next, current1);
            


            Assert.AreEqual(old.Next, current2);
            Assert.AreEqual(current1.Previous, current2);


        }
        [Test]
        public void InserBefore()
        {    
            //1 o
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current1 = new DoubleLinked();

            current1.InserBefore(old);
            

            Assert.AreEqual(current1.Next,old);
            Assert.AreEqual(old.Previous,current1);


            //1 2 o
            DoubleLinked current2 = new DoubleLinked();
            current2.InserBefore(old);
            
            Assert.AreEqual(old.Previous, current2);
            Assert.AreEqual(current2.Previous, current1);
            Assert.AreEqual(current1.Next, current2);
            Assert.AreEqual(current2.Next, old);

        }
        [Test]
        public void Delete()
        {   
            DoubleLinked old = new DoubleLinked();
            //old  删除old
            old.Delete(old);
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(old.Next, null);

            //old 1 2  删除头部old
            DoubleLinked current1 = new DoubleLinked();
            current1.InserAfter(old);
            current1.Delete(old);
            Assert.AreEqual(old.Next, null);
            Assert.AreEqual(current1.Previous, null);

            // 2 1 old 删除尾部old
            current1.InserBefore(old);
            current1.Delete(old);
            Assert.AreEqual(current1.Next, null);
            Assert.AreEqual(old.Previous, null);
            //1  old  2   删除中间的old
            DoubleLinked current2 = new DoubleLinked();
            current1.InserBefore(old);
            current2.InserAfter(old);
            current2.Delete(old);
            Assert.AreEqual(current1.Next,current2);
            Assert.AreEqual(current2.Previous, current1);


        }

        [Test]
        public void Swap()
        {
            //old 交换
            DoubleLinked old = new DoubleLinked();
            //old.Swap(old,null);
            //Assert.AreEqual(old.Previous, null);
            //Assert.AreEqual(old.Next, null);

            //old 1 2头部交换为1 old 2

            DoubleLinked current1 = new DoubleLinked();
            DoubleLinked current2 = new DoubleLinked();
            current1.InserAfter(old);
            current2.InserAfter(current1);
            old.Swap(current1, current2);

            Assert.AreEqual(current1.Next,old);
            Assert.AreEqual(old.Next, current2);
            Assert.AreEqual(current2.Previous,old);
            Assert.AreEqual(old.Previous, current1);

            //1 old 2 尾部交换为 1 2 old
            current1.Swap(current2, old);
            
            Assert.AreEqual(current1.Next, current2);
            Assert.AreEqual(current2.Next, old);
            Assert.AreEqual(old.Previous, current2);
            Assert.AreEqual(current2.Previous,current1);



            //1 2 old 3 中间交换为 1 old 2 3
            DoubleLinked current3 = new DoubleLinked();
            current3.InserAfter(old);
            current1.Swap(current2,old);




        }




    }
}