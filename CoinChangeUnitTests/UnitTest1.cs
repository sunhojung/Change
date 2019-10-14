using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinChangeUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinimumChange() 
        {
            Dictionary<int, int> testValue = Coin.Change(0);
            Assert.AreEqual(0, testValue.Count);
        }

        [TestMethod]
        public void MaximumChange() 
        {
            Dictionary<int, int> testValue = Coin.Change(10000);
            Assert.AreEqual(50, testValue[200]);
            Assert.AreEqual(1, testValue.Count);
        }

        [TestMethod]
        public void RoundedChange() //checks to see if the change gets rounded correctly from a midpoint
        {
            Dictionary<int, int> testValue = Coin.Change(5);
            Assert.AreEqual(1, testValue[10]);
            Assert.AreEqual(1, testValue.Count);
        }

        [TestMethod]
        public void RoundedChange2() //checks to see if the change gets rounded correctly from a midpoint
        {
            Dictionary<int, int> testValue = Coin.Change(15);
            Assert.AreEqual(1, testValue[20]);
            Assert.AreEqual(1, testValue.Count);
        }

        [TestMethod]
        public void RoundedChange3() //checks to see if the change gets rounded correctly from a midpoint
        {
            Dictionary<int, int> testValue = Coin.Change(25);
            Assert.AreEqual(1, testValue[10]);
            Assert.AreEqual(1, testValue[20]);
            Assert.AreEqual(2, testValue.Count);
        }
    }
}
