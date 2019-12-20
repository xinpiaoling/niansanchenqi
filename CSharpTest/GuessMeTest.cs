using CSharpLearn;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest
{
    class GuessMeTest
    {

        [Test]
        public void GuessMeRightTest()
        {
            Assert.AreEqual(GuessMe.GuessRight(0), GuessMe.Input1);
            Assert.AreEqual(GuessMe.GuessRight(3), GuessMe.Input1);
            Assert.AreEqual(GuessMe.GuessRight(6), GuessMe.Input2);
            Assert.AreEqual(GuessMe.GuessRight(8), GuessMe.Input3);
            Assert.AreEqual(GuessMe.GuessRight(10), GuessMe.Input4);
            Assert.AreEqual(GuessMe.GuessRight(11), GuessMe.Input5);
        }
        [Test]
        public void GuessMeWrongTest()
        {
            Assert.AreEqual(GuessMe.GuessWrong(50,60,10),GuessMe.Input6);
            Assert.AreEqual(GuessMe.GuessWrong(50, 60, 1), GuessMe.BigInput);
            Assert.AreEqual(GuessMe.GuessWrong(60, 50, 1), GuessMe.SmallInput);
        }
    }
}
