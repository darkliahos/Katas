using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.Main;

namespace Kata.UnitTest
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Main.Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Main.Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Main.Kata.DuplicateEncode("Success"), "should ignorecase");
            Assert.AreEqual("))((", Main.Kata.DuplicateEncode("(( @"));
        }
    }

}
