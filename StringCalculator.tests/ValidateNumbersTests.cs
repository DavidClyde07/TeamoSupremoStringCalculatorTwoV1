using NUnit.Framework;
using System.Collections.Generic;
using System;
using StringCalculatorLibrary;

namespace StringCalculator.tests
{
    public class ValidateNumbersTests
    {
        [Test]
        public void GIVEN_ListOfNumbersWithNumbersInTheThousands_WHEN_ThrowingExceptionForNumbersOverMaxLimit_THROW_ArgumentException()
        {
            List<int> input = new List<int>() {1,2000,3000,4} ;
            
            //Act + Assert
            var result = Assert.Throws<ArgumentException>(() => input.ThrowExceptionIfOverMaxLimit());
            Assert.That(result.Message, Is.EqualTo("Numbers over 1000 are not allowed. You entered: 2000, 3000"));
        }
    }
}