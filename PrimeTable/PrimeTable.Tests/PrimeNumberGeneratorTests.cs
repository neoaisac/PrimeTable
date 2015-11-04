﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Tests
{
    [TestFixture]
    class PrimeNumberGeneratorTests
    {
        private Lib.PrimeNumberGenerator _testObject;

        [SetUp]
        public void BeforeEachTest()
        {
            _testObject = new Lib.PrimeNumberGenerator();
        }

        [TestCase(10)]
        [TestCase(0, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(-1,ExpectedException = typeof(ArgumentOutOfRangeException))]
        [Test]
        public void PrimeNumberGenerator_Generate(int length)
        {
            // Arrange
            // Act
            var result = _testObject.Generate(length);

            // Assert
            Assert.Equals(length, result.Count());
        }

        [TestCase(4, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(1, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(0, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [Test]
        public bool PrimeNumberGenerator_IsPrime(int value)
        {
            // Arrange
            // Act
            var result = _testObject.IsPrime(value);

            // Assert
            return result;
        }
    }
}
