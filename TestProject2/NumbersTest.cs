using NET22_WebAppDevopsTest;

namespace TestProject2
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void VariableTest()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(10, 12);
            var expected = 22;
            //Act
            Assert.AreEqual(expected, actual);
            //Assert
        }
        [TestMethod]
        public void VariableTest2()
        {
            //Arrange
            Numbers num = new Numbers();
            var actual = num.Add(11, 12);
            var expected = 22;
            //Act
            Assert.AreEqual(expected, actual);
            //Assert
        }
    }
}