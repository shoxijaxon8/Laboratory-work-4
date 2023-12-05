using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LW3;

namespace LW3Test
{
    [TestClass]
    public class LW3Test1
    {
        [TestMethod]
        public void Div_32Div002_Returned160()
        {
            // arrange 
            var calc = new ResistanceLED();
            double arg1 = 5;
            double arg2 = 1.8;
            double arg3 = 0.02;
            double expected = 160;
            // act
            double result = calc.Div(arg1, arg2, arg3);
            // assert            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Oh my god, we can't divison on zero")]
        public void Div_4Div0_ZeroDivException()
        {
            // arrange 
            var calc = new ResistanceLED();
            double arg1 = 5;
            double arg2 = 1.8;
            double arg3 = 0;
            double expected = 160;
            // act
            double result = calc.Div(arg1, arg2, arg3);
            // assert            
            Assert.AreEqual(expected, result);
        }
    }
}
