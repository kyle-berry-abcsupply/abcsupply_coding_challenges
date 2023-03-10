using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MagicIndex.Tests
{
    [TestClass]
    public class MagicTest
    {
        [TestMethod]
        public void ExampleOne()
        {
            var magic = new Magic();
            var containsMagicIndexActual = magic.ContainsMagicIndex(new List<int> { -10, -8, 2, 5, 12});
            Assert.AreEqual(true, containsMagicIndexActual);
        }

        [TestMethod]
        public void ExampleTwo()
        {
            var magic = new Magic();
            var containsMagicIndexActual = magic.ContainsMagicIndex(new List<int> { -5, -4, -3, -2, -1 });
            Assert.AreEqual(false, containsMagicIndexActual);
        }

        [TestMethod]
        public void ExampleThree()
        {
            var magic = new Magic();
            var containsMagicIndexActual = magic.ContainsMagicIndex(new List<int> { 1, 2, 3, 4, 5 });
            Assert.AreEqual(false, containsMagicIndexActual);
        }

        [TestMethod]
        public void ExampleFour()
        {
            var magic = new Magic();
            var containsMagicIndexActual = magic.ContainsMagicIndex(new List<int> { -1, -2, -3, -4, -5, -6, -7, -8, -9, 9 });
            Assert.AreEqual(true, containsMagicIndexActual);
        }

        [TestMethod]
        public void ExampleFive()
        {
            var magic = new Magic();
            var containsMagicIndexActual = magic.ContainsMagicIndex(new List<int> { 0, 2, 4, 6, 8 });
            Assert.AreEqual(true, containsMagicIndexActual);
        }
    }
}