using NUnit.Framework;
using StringCalculatorLibrary.Interfaces;
using StringCalculatorLibrary;
using System.Collections.Generic;

namespace StringCalculator.tests
{
    public class ConvertLetterToNumberTests
    {
        private IConvertLetterToNumber _convertLetterToNumber;
        [SetUp]
        public void Setup()
        {
            _convertLetterToNumber = new ConvertLetterToNumber();
        }

        [Test]
        public void GIVEN_ListOFStringsWithLettersAndNumbers_WHEN_ConvertingLettersToNumbers_RETURN_IntList()
        {
            //Arrange
            List<string> input = new List<string> {"1","c","d", "k"}; 
            List<int> expected = new List<int> {1,2,3}; 
            //Act
            var result = _convertLetterToNumber.ConvertListOfStringToListOfInt(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}