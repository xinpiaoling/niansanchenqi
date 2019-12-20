using CSharpLearn;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest
{

    class StringMethodTest
    {
        [Test]
        public void MimicJoinTest()
        {
            Assert.AreEqual(StringMethod.MimicJoin(
                StringMethod._character, StringMethod._array),
                "a-b-c-d");
        }

    }
}
