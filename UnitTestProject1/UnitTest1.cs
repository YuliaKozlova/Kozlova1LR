using Kozlova1LR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

    
            // �������� ������
            int a = 3;
            int b = 5;
            int expected = 15;

            // ��������� �������� � ������� ������������ ������
            Umnogenie g = new Umnogenie();
            int actual = g.RectangleArea(a, b);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expected, actual);
        }
    }
}
        