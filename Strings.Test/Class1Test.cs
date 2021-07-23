using NUnit.Framework;
using Strings.Class;
using System.Collections.Generic;

namespace Strings.Test
{
    [TestFixture]
    public class Class1Test
    {
        private Class1 _class;

        [SetUp]
        public void Setup()
        {
            _class = new Class1();
        }

        //Arrange
        private static IEnumerable<object> StringListCombinations()
        {
            // Expected Value, Original Unprocessed String
            yield return new object[] { new List<string> { "Aabcd123", "bdefghj"}, new List<string> { "AAAabaacd1234", "bdefghj"} };
            yield return new object[] { new List<string> { "cvb1n2", "87jkh"}, new List<string> { "cvvbb1n21", "878jkhj"} };
            yield return new object[] { new List<string>(), null};
            yield return new object[] { new List<string>(), new List<string> { string.Empty }};
            yield return new object[] { new List<string>(), new List<string> { null }};
            yield return new object[] { new List<string>() { " " }, new List<string> { " " }};
        }

        [TestCaseSource(nameof(StringListCombinations))]
        public void Test1(List<string> expected, List<string> stringList)
        {
            //Act
            var actual = _class.Processor(stringList);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}