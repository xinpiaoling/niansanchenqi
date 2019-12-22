using CSharpLearn;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTest
{
    class GetCountTest
    {
        [Test]
        public void GetCountMethod()
        {
            Assert.AreEqual(StringMethod.GetCount("abcabcab", "ab"), 3);
            Assert.Throws<Exception>(() => StringMethod.GetCount("abc", "abccc"));
            Assert.Throws<Exception>(()=>StringMethod.GetCount("",""));
            Assert.Throws<Exception>(() => StringMethod.GetCount("abc", ""));
            Assert.Throws<Exception>(()=>StringMethod.GetCount(null,null));
        }





    }
}
