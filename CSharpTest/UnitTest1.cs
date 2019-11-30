using NUnit.Framework;
using CSHARP_11._21;

namespace Tests
{
    public class DoubleLinkedTest
    {
        [SetUp]//����֮ǰ����
        public void Setup()
        {
        }

        [Test]//���Ե�ʱ������
        public void Test1()
        {
            //assert����
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
            //old  ɾ��old
            old.Delete(old);
            Assert.AreEqual(old.Previous, null);
            Assert.AreEqual(old.Next, null);

            //old 1 2  ɾ��ͷ��old
            DoubleLinked current1 = new DoubleLinked();
            current1.InserAfter(old);
            current1.Delete(old);
            Assert.AreEqual(old.Next, null);
            Assert.AreEqual(current1.Previous, null);

            // 2 1 old ɾ��β��old
            current1.InserBefore(old);
            current1.Delete(old);
            Assert.AreEqual(current1.Next, null);
            Assert.AreEqual(old.Previous, null);
            //1  old  2   ɾ���м��old
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
            //old ����
            DoubleLinked old = new DoubleLinked();
            //old.Swap(old,null);
            //Assert.AreEqual(old.Previous, null);
            //Assert.AreEqual(old.Next, null);

            //old 1 2ͷ������Ϊ1 old 2

            DoubleLinked current1 = new DoubleLinked();
            DoubleLinked current2 = new DoubleLinked();
            current1.InserAfter(old);
            current2.InserAfter(current1);
            old.Swap(current1, current2);

            Assert.AreEqual(current1.Next,old);
            Assert.AreEqual(old.Next, current2);
            Assert.AreEqual(current2.Previous,old);
            Assert.AreEqual(old.Previous, current1);

            //1 old 2 β������Ϊ 1 2 old
            current1.Swap(current2, old);
            
            Assert.AreEqual(current1.Next, current2);
            Assert.AreEqual(current2.Next, old);
            Assert.AreEqual(old.Previous, current2);
            Assert.AreEqual(current2.Previous,current1);



            //1 2 old 3 �м佻��Ϊ 1 old 2 3
            DoubleLinked current3 = new DoubleLinked();
            current3.InserAfter(old);
            current1.Swap(current2,old);




        }




    }
}