using CSharpLearn;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest
{
    class ExeciseOfLinqTest
    {
        [Test]
        public void ArticleByFeiGeTest()
        {
            //Assert.AreEqual();
        }
        [Test]
        public void AuthorProblemRewardOverFiveTest()
        {
            Assert.AreEqual(ExerciseOfLinq.AuthorProblemRewardOverFive(),"小余");
        }
    }
}
