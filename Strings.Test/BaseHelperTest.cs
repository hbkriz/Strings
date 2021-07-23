using NUnit.Framework;
using Strings.Class;
using System.Collections.Generic;
using System;

namespace Strings.Test
{
    [TestFixture]
    public class ExceedingMaxLengthTest
    {
        //Arrange
        private static IEnumerable<object> StringCombinations()
        {
            yield return new object[] { Guid.NewGuid().ToString("n").Substring(0, 8), 8, 15 };
            yield return new object[] { Guid.NewGuid().ToString("n").Substring(0, 10), 10, 15 };
            yield return new object[] { Guid.NewGuid().ToString("n").Substring(0, 20), 15, 15 };
            yield return new object[] { Guid.NewGuid().ToString("n").Substring(0, 30), 25, 25 };
            yield return new object[] { Guid.NewGuid().ToString("n").Substring(0, 25), 20, 20 };
        }

        [TestCaseSource(nameof(StringCombinations))]
        public void MainTest(string givenString, int expectedLength, int maxLength)
        {
            //Act
            var actual = givenString.ExceedingMaxLength(maxLength);

            //Assert
            Assert.AreEqual(expectedLength, actual.Length);
        }
    }

    [TestFixture]
    public class RemovingContiguousCharactersTest
    {
        //Arrange
        private static IEnumerable<object> StringCombinations()
        {
            yield return new object[] { "AAAcDc3WwWkLqc3ivd__K", "AcD3WwkLqivd_K" };
            yield return new object[] { "MMMMmAAAaryLAnd", "MmAaryLnd" };
        }

        [TestCaseSource(nameof(StringCombinations))]
        public void MainTest(string givenString, string expectedString)
        {
            //Act
            var actualString = givenString.RemovingContiguousCharacters();

            //Assert
            Assert.AreEqual(expectedString, actualString);
        }
    }

    [TestFixture]
    public class ReplaceCharacterWithAnotherTest
    {
        //Arrange
        private static IEnumerable<object> StringCombinations()
        {
            yield return new object[] { "$", "£", "ABCD$$JKL", "ABCD££JKL" };
            yield return new object[] { "%", "@", "B%*H&J%KL", "B@*H&J@KL" };
        }

        [TestCaseSource(nameof(StringCombinations))]
        public void MainTest(string replace, string replaceWith, string givenString, string expectedString)
        {
            //Act
            var actualString = givenString.ReplaceCharacterWithAnother(replace, replaceWith);

            //Assert
            Assert.AreEqual(expectedString, actualString);
        }
    }

    [TestFixture]
    public class ReplaceWithEmptyStringTest
    {
        //Arrange
        private static IEnumerable<object> StringCombinations()
        {
            yield return new object[] { "$", "ABCD$$JKL", "ABCDJKL" };
            yield return new object[] { "%", "B%*H&J%KL", "B*H&JKL" };
            yield return new object[] { "4", "AB4CD$$4JKL", "ABCD$$JKL" };
            yield return new object[] { "_", "B__H_J_KL", "BHJKL" };
            yield return new object[] { "20", "2B40CD204JKL", "2B40CD4JKL" };
        }

        [TestCaseSource(nameof(StringCombinations))]
        public void MainTest(string replace, string givenString, string expectedString)
        {
            //Act
            var actualString = givenString.ReplaceWithEmptyString(replace);

            //Assert
            Assert.AreEqual(expectedString, actualString);
        }
    }
}