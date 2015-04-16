using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberUtilities;


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
            long expected = 1000;
            long actual;

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
            long expected = 1000;
            long actual;

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
            long expected = 1000;
            long actual;

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
            long expected = 1000;
            long actual;

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
            long expected = 100;
            long actual;

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
            long expected = 1000;
            long actual;

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
            long expected = -1;
            long actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void NumberFetcherReturnsMinusOneWithDoubleShorthand()
        {
            // Arrange
            string value = "1kk";
            long expected = -1;
            long actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void NumberFetcherReturnsMinusOneWithIncorrectShorthandPosition()
        {
            // Arrange
            string value = "1k1";
            long expected = -1;
            long actual;

            // Act
            actual = NumberFetcher.Fetch(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
