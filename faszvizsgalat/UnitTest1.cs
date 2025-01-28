using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace faszvizsgalat
{
    
    [TestClass]
    public class UnitTest1
    {
        public fasz asd = new fasz();
        public pina dsa = new pina();
        [TestMethod]
        public void TestMethod1()
        {
            int numone = 10;
            int expected = 50;
            int result = asd.multiply(numone);
            Assert.AreEqual(expected, result);
            int numone_b = 0;
            int expected_b = 0;
            int result_b = asd.multiply(numone_b);
            Assert.AreEqual(expected_b, result_b);
            int numone_c = -1;
            int expected_c = -5;
            int result_c = asd.multiply(numone_c );
            Assert.AreEqual(expected_c, result_c);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double geciszam = 5;
            double hossz = 12.5;
            double expected =3.5;
            double result = asd.divide(geciszam, hossz);
            Assert.AreEqual(expected, result);
        }
        public void TestMethod3()
        {
            int numone_a = 7;
            int result_a = dsa.multiply(numone_a);
            int expected_a = 1;
            Assert.AreEqual(result_a, expected_a);
            int numone_b = 0;
            int expected_b = 0;
            int result_b = dsa.multiply(numone_b);
            Assert.AreEqual(expected_b, result_b);
            int numone_c = -7;
            int expected_c = -1;
            int result_c = dsa.multiply(numone_c);
            Assert.AreEqual(expected_c, result_c);
        }
        public void TestMethod4()
        {
            double numone = 2.5;
            double numtwo = 1.7;
            double numthree = 2.3;
            double expected = 6.5;
            double result = dsa.add(numone, numtwo, numthree);
            Assert.AreEqual(expected, result);

        }

    }
}
