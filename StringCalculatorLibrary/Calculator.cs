using System;
using System.Collections.Generic;
using System.Linq;
using StringCalculatorLibrary.Interfaces;

namespace StringCalculatorLibrary
{
    public class Calculator : ICalculator
    {
        private IConvertLetterToNumber _convertLetterToNumber;
        private IStringSplitter _stringSplitter;

        public Calculator(IConvertLetterToNumber convertLetterToNumber, IStringSplitter stringSplitter)
        {
            this._convertLetterToNumber = convertLetterToNumber;
            this._stringSplitter = stringSplitter;
        }

        public int Subtract(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }

            IEnumerable<string> formatString = _stringSplitter.SplitTokensOnDelimiters(input);
            IEnumerable<string> positiveNumbers = formatString.ConvertNegativesToPositives();
            IEnumerable<int> numbersOnly = _convertLetterToNumber.ConvertListOfStringToListOfInt(positiveNumbers); 
            
            numbersOnly.ThrowExceptionIfOverMaxLimit();

            return numbersOnly.Sum()*-1;
        }
    }
}