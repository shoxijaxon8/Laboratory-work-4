using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LW3DB;

namespace LW3DBTest
{
    [TestClass]
    public class LW3DBTest
    {
        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(0, 0, 1)]
        public void AddIntegers_FromDataRowTest(int x, int y, int expected)
        {
            var target = new Maths();
            int actual = target.AddIntegers(x, y);
            Assert.AreEqual(expected, actual,
                "x:<{0}> y:<{1}>",
                new object[] { x, y });
        }
    }
}
