using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellusTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void EnsimmainenTesti ()
        {
            Assert.That(2, Is.EqualTo(2));
        }
    }
}
