using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDyna.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void ThisIsASillyTest()
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
