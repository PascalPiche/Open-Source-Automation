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
        public void GetByteCountWithValidHexStringTest()
        {
            string[] hexString = new string[5] {"", "a","00","011","013235"};
            int[] expected = new int[5] {0,0,1,1,3};

            for (int c = 0; c < hexString.Length; c++)
            {
		        int actual = HexEncoding.GetByteCount(hexString[c]);
                Assert.AreEqual(expected[c],actual, "The hexString : " + hexString[c] + " should give a ByteCount of : " + expected[c]);
	        }
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
            Assert.IsNotNull(target, "HexEncoding initialisation succeed");
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
        ///A test for IsHexDigit with good values
        ///should return true
        ///</summary>
        [TestMethod()]
        public void IsHexDigitGoodValuesTest()
        {
            char[] c = new char[22] {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','A','B','C','D','E','F'};
            bool expected = true;
            foreach (var item in c)
            {
                bool actual;
                actual = HexEncoding.IsHexDigit(item);
                Assert.AreEqual(expected, actual, item + " : is HEX digit");
            }
        }

        /// <summary>
        ///A test for IsHexDigit with bad values
        ///should return false
        ///</summary>
        [TestMethod()]
        public void IsHexDigitBadValuesTest()
        {
            char[] c = new char[9] { 'g', 'G', '-', '_', '^', '?', '&', 'q', 'z'};
            bool expected = false;
            foreach (var item in c)
            {
                bool actual;
                actual = HexEncoding.IsHexDigit(item);
                Assert.AreEqual(expected, actual, item + " : is not an HEX digit");
            }
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
