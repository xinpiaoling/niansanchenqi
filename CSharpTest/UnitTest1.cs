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
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(current1.Previous, old);
            Assert.AreEqual(old.Next, current1);
            Assert.AreEqual(current1.Next, null);

            DoubleLinked current2 = new DoubleLinked();
            current2.InserAfter(old);
            //old 2 1
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(current2.Previous, old);
            Assert.AreEqual(current1.Previous, current2);
            Assert.AreEqual(current1.Next, null);
            Assert.AreEqual(current2.Next, current1);
            Assert.AreEqual(old.Next, current2);


        }
        [Test]
        public void InserBefore()
        {

            DoubleLinked old = new DoubleLinked();
            DoubleLinked current1 = new DoubleLinked();

            current1.InserBefore(old);
            //1 o
            Assert.AreEqual(current1.Previous, null);
            Assert.AreEqual(current1.Next, old);
            Assert.AreEqual(old.Previous, current1);
            Assert.AreEqual(old.Next, null);


            //1 2 o
            DoubleLinked current2 = new DoubleLinked();
            current2.InserBefore(old);


            Assert.AreEqual(old.Previous, current2);
            Assert.AreEqual(current2.Previous, current1);
            Assert.AreEqual(current1.Previous, null);
            Assert.AreEqual(current1.Next, current2);
            Assert.AreEqual(current2.Next, old);
            Assert.AreEqual(old.Next, null);
        }
        [Test]
        public void Delete()                 //降低耦合性，提高内聚性
        {
            DoubleLinked old = new DoubleLinked();
            //old  删除old
            old.Delete();
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(old.Next, null);

            //old 1   删除头部old
            DoubleLinked current1 = new DoubleLinked();
            current1.InserAfter(old);
            old.Delete();
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(old.Next, null);
            Assert.AreEqual(current1.Previous, null);
            Assert.AreEqual(current1.Next, null);

            //  1 old 删除尾部old
            current1.InserBefore(old);
            old.Delete();
            Assert.AreEqual(current1.Previous, null);
            Assert.AreEqual(current1.Next, null);
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(old.Next, null);

            //1  old  2   删除中间的old
            DoubleLinked current2 = new DoubleLinked();
            current1.InserBefore(old);
            current2.InserAfter(old);
            old.Delete();
            Assert.AreEqual(current1.Previous, null);
            Assert.AreEqual(current1.Next, current2);
            Assert.AreEqual(current2.Previous, current1);
            Assert.AreEqual(current2.Next, null);
            Assert.AreEqual(old.Next, null);
            Assert.AreEqual(old.Previous, null);

        }

        [Test]
        public void Swap()
        {
            //old 交换
            //DoubleLinked old = new DoubleLinked();
            //old.Swap(old,null);
            //Assert.AreEqual(old.Previous, null);
            //Assert.AreEqual(old.Next, null);
            //old.Delete();

            //old  1 交换为  1   old
            //DoubleLinked old = new DoubleLinked();
            //DoubleLinked current1 = new DoubleLinked();
            //old.InserBefore(current1);
            //old.Swap(current1);
            //Assert.AreEqual(current1.Previous,null);
            //Assert.AreEqual(old.Previous,current1);
            //Assert.AreEqual(current1.Next,old);
            //Assert.AreEqual(old.Next,null);


            //2  3  4头部交换为3  2  4

            //DoubleLinked current2 = new DoubleLinked();
            //DoubleLinked current3 = new DoubleLinked();
            //DoubleLinked current4 = new DoubleLinked();
            //current2.InserBefore(current3);
            //current3.InserBefore(current4);
            //current2.Swap(current3);
            //Assert.AreEqual(current4.Previous, current2);
            //Assert.AreEqual(current2.Previous, current3);
            //Assert.AreEqual(current3.Previous, null);
            //Assert.AreEqual(current3.Next, current2);
            //Assert.AreEqual(current2.Next, current4);
            //Assert.AreEqual(current4.Next, null);


            //////5  6  7 尾部交换为 5  7  6

            //DoubleLinked current5 = new DoubleLinked();
            //DoubleLinked current6 = new DoubleLinked();
            //DoubleLinked current7 = new DoubleLinked();
            //current5.InserBefore(current6);
            //current6.InserBefore(current7);
            //current6.Swap(current7);
            //Assert.AreEqual(current6.Previous, current7);
            //Assert.AreEqual(current7.Previous, current5);
            //Assert.AreEqual(current5.Previous, null);
            //Assert.AreEqual(current5.Next, current7);
            //Assert.AreEqual(current7.Next, current6);
            //Assert.AreEqual(current6.Next, null);




            //////8  9  10  11 中间交换为  8  10  9  11
            ///
            DoubleLinked current8 = new DoubleLinked();
            DoubleLinked current9 = new DoubleLinked();
            DoubleLinked current10 = new DoubleLinked();
            DoubleLinked current11 = new DoubleLinked();
            current8.InserBefore(current9);
            current9.InserBefore(current10);
            current10.InserBefore(current11);
            current9.Swap(current10);
            Assert.AreEqual(current11.Previous, current9);
            Assert.AreEqual(current9.Previous, current10);
            Assert.AreEqual(current10.Previous, current8);
            Assert.AreEqual(current8.Previous, null);
            Assert.AreEqual(current8.Next, current10);
            Assert.AreEqual(current10.Next, current9);
            Assert.AreEqual(current9.Next, current11);
            Assert.AreEqual(current11.Next, null);

        }

        [Test]
        public void FindBy()
        {







        }


    }
}