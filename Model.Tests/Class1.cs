using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ModelTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void test()
        {
            Assert.AreEqual(Model.Class1.fun(), 2);
        }
    }
}
