using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // arrange
            int a = 3;
            int b = 5;
            int expected = 15;

            // act

           
             int actual = g.RectangleArea(a, b);

            // assert
            Assert.AreEqual(expected, actual);


        }
    }
}
