using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 2;
            int b = 2;
            int[,] array = new int[a, b];
            array[0, 0] = -4;
            array[0, 1] = 2;
            array[1, 0] = -5;
            array[1, 1] = 6;
            Assert.AreEqual(-9, LAB2._5OOP.Program.Sum(array));
        }
    }
}
