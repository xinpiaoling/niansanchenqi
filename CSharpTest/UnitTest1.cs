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
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current1 = new DoubleLinked();

            current1.InserBefore(old);
            //1 o

            Assert.AreEqual(current1.Next,old);
            Assert.AreEqual(old.Previous,current1);

            DoubleLinked current2 = new DoubleLinked();
            current2.InserBefore(old);
            //1 2 o



            Assert.AreEqual(old.Previous, current2);
            Assert.AreEqual(current2.Previous, current1);
            Assert.AreEqual(current1.Next, current2);
            Assert.AreEqual(current2.Next, old);

        }
    }
}