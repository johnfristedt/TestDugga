using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDugga.Test
{
    [TestClass]
    public class NumberFetcherTests
    {
        [TestMethod]
        public void NumberFetcherWorksWithThousands()
        {
            // Arrange
            string value = "1k";
            int expected = 1000;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFetcherWorksWithMillions()
        {
            // Arrange
            string value = "1m";
            int expected = 1000;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFetcherWorksWithBillions()
        {
            // Arrange
            string value = "1b";
            int expected = 1000;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFetcherWorksWithTrillions()
        {
            // Arrange
            string value = "1t";
            int expected = 1000;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFetcherReturnsInputValueWithoutShorthand()
        {
            // Arrange
            string value = "100";
            int expected = 100;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFetcherReturnsNumberWithOnlyShorthand()
        {
            // Arrange
            string value = "k";
            int expected = 1000;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFetcherReturnsMinusOneWithWrongShorthand()
        {
            // Arrange
            string value = "1o";
            int expected = -1;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void NumberFetcherReturnsMinusOneWithDoubleShorthand()
        {
            // Arrange
            string value = "1kk";
            int expected = -1;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void NumberFetcherReturnsMinusOneWithIncorrectShorthandPosition()
        {
            // Arrange
            string value = "1k1";
            int expected = -1;
            int actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
