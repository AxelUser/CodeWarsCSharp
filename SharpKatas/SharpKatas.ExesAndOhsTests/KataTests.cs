using System;
using NUnit.Framework;
using SharpKatas.ExesAndOhs;

namespace SharpKatas.ExesAndOhsTests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
            Assert.AreEqual(true, Kata.XO("xxOo"));
            Assert.AreEqual(false, Kata.XO("xxxm"));
            Assert.AreEqual(false, Kata.XO("Oo"));
            Assert.AreEqual(false, Kata.XO("ooom"));
        }
    }
}
