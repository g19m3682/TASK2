using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            House h = new House(0, 0);
            //Act   function that is being tested
            h.ResetHouse();
            //Assert
            Assert.AreEqual(4,h.GetCount(), "Seeds total have to be 4");  //the string is the message that is
                // displayed when test fails and tells you the expected answer.
        }
    }
}