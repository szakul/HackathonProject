using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;

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

        [Test]
        public void test1()
        {
            Recruiter a = new Recruiter();

            a.Ihgvhd = 7;
            Assert.AreEqual(a.Ihgvhd, 7);
        }
    }
}
