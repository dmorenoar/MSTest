using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tools;

namespace Tools.Tests
{
    [TestClass]
    public sealed class UtilsTests
    {
        [TestMethod]
        [TestCategory("UtilsTests")]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrange
            int a = 3;
            int b = 5;

            //Act
            int result = Utils.Add(a, b);

            //Assert
            Assert.AreEqual(8, result);
        }

        [DataTestMethod]
        [TestCategory("UtilsTests")]
        [DataRow(3, 5, 8)]
        [DataRow(-2, 2, 0)]
        [DataRow(0, 0, 0)]
        public void Add_ShouldReturnCorrectSum_DataDriven(int a, int b, int expected)
        {
            //Act
            int result = Utils.Add(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [TestCategory("UtilsTests")]
        [DataRow(4, true)]
        [DataRow(7, false)]
        public void IsEven_ShouldReturnExpectedResult_DataDriven(int num, bool expected)
        {
            //Act
            bool result = Utils.IsEven(num);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [TestCategory("UtilsTests")]
        public void IsEven_ShouldReturnIsFalseForOddNumbers()
        {
            //Arrange
            int num = 5;

            //Act
            bool result = Utils.IsEven(num);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [TestCategory("UtilsTests")]
        public void IsEven_ShouldReturnTrueForEvenNumbers()
        {
            //Arrange
            int num = 4;
            //Act
            bool result = Utils.IsEven(num);
            //Assert
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [TestCategory("NumbersTests")]
        [DataRow(2, 4, 4)]
        [DataRow(5, 3, 5)]
        [DataRow(6, 6, 6)]
        public void Max_ShouldReturnExpectedResult_DataDriven(int numberOne, int numberTwo, int expected)
        {
            //Act
            int result = Utils.Max(numberOne, numberTwo);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [TestCategory("NumbersTests")]
        [DataRow(3, true)]
        [DataRow(0, true)]
        [DataRow(10, true)]
        [DataRow(-1, false)]
        public void IsValidGrade_ShouldValidateCorrectly(int grade, bool expected)
        {
            Assert.AreEqual(expected, Utils.IsValidGrade(grade));
        }

        [TestMethod]
        [TestCategory("UtilsTests")]
        public void Reverse_ShouldReturnNull_WhenInputIsNull()
        {
            //Arrange
            string input = null;
            //Act
            string result = Utils.Reverse(input);
            //Assert
            Assert.IsNull(result);
        }

        [DataTestMethod]
        [TestCategory("UtilsTests")]
        [DataRow("hello", "olleh")]
        [DataRow("Tools", "slooT")]
        [DataRow("", "")]
        public void Reverse_ShouldReturnReversedString_DataDriven(string input, string expected)
        {
            //Act
            string result = Utils.Reverse(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [TestCategory("UtilsTests")]
        [DataRow("hello")]
        [DataRow("Tools")]
        [DataRow("abcd")]
        public void Reverse_ShouldNotReturnSameString_DataDriven(string input)
        {
            //Act
            string result = Utils.Reverse(input);
            //Assert
            Assert.AreNotEqual(input, result);
        }

        [TestMethod]
        [TestCategory("UtilsTests")]
        public void Reverse_ShouldNotReturnSameString()
        {
            //Arrange
            string input = "example";
            //Act
            string result = Utils.Reverse(input);
            //Assert
            Assert.AreNotEqual(input, result);
        }



    }
}

