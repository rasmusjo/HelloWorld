using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDynaTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void ThisTestIsSilly()
        {
            //Arrange
            bool shouldBeTrue;

            //Act
            shouldBeTrue = true;

            //Assert
            Assert.AreEqual(true, shouldBeTrue);
        }
    }
}
