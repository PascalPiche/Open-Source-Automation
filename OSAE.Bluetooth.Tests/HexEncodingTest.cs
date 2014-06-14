using OSAE.Bluetooth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OSAE.Bluetooth.Tests
{
    
    
    /// <summary>
    ///This is a test class for HexEncodingTest and is intended
    ///to contain all HexEncodingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HexEncodingTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetByteCount
        ///</summary>
        [TestMethod()]
        public void GetByteCountTest()
        {
            string hexString = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = HexEncoding.GetByteCount(hexString);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetBytes
        ///</summary>
        [TestMethod()]
        public void GetBytesTest()
        {
            string hexString = string.Empty; // TODO: Initialize to an appropriate value
            int discarded = 0; // TODO: Initialize to an appropriate value
            int discardedExpected = 0; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = HexEncoding.GetBytes(hexString, out discarded);
            Assert.AreEqual(discardedExpected, discarded);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HexEncoding Constructor
        ///</summary>
        [TestMethod()]
        public void HexEncodingConstructorTest()
        {
            HexEncoding target = new HexEncoding();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for HexToByte
        ///</summary>
        [TestMethod()]
        [DeploymentItem("OSAE.Bluetooth.dll")]
        public void HexToByteTest()
        {
            // Creation of the private accessor for 'Microsoft.VisualStudio.TestTools.TypesAndSymbols.Assembly' failed
            Assert.Inconclusive("Creation of the private accessor for \'Microsoft.VisualStudio.TestTools.TypesAndSy" +
                    "mbols.Assembly\' failed");
        }

        /// <summary>
        ///A test for InHexFormat
        ///</summary>
        [TestMethod()]
        public void InHexFormatTest()
        {
            string hexString = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = HexEncoding.InHexFormat(hexString);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsHexDigit
        ///</summary>
        [TestMethod()]
        public void IsHexDigitTest()
        {
            char c = '\0'; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = HexEncoding.IsHexDigit(c);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = HexEncoding.ToString(bytes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
