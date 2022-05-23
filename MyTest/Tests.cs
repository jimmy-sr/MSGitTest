using System;
using NUnit.Framework;

namespace MyTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Hello");
        }
    }
}