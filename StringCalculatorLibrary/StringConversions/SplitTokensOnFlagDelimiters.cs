using System;
using System.Collections.Generic;
using StringCalculatorLibrary.Interfaces;

namespace StringCalculatorLibrary.StringConversions
{
    public class SplitTokensOnFlagDelimiters : IStringSplitter
    {
        const string NewLineDelimiter = "\n";
        const int FirstFlagSeperatorPosition = 1;
        const int SecondFlagSeperatorPosition = 3;
        const int StartPositionOfFlagSeperators = 0;
        const int EndPositionOfFlagSeperators = 5;

        public IEnumerable<string> SplitTokensOnDelimiters(string numbers)
        {
            var customFlagDelimiters = new[] { numbers[FirstFlagSeperatorPosition], numbers[SecondFlagSeperatorPosition] };

            var splitNumbers = numbers.Replace(numbers.Substring(StartPositionOfFlagSeperators, EndPositionOfFlagSeperators), string.Empty);
            var splitNumbersAndCustomDelimiters = numbers.Split(NewLineDelimiter, StringSplitOptions.RemoveEmptyEntries);
            var splitCustomSeperators = splitNumbers.Split(customFlagDelimiters, StringSplitOptions.RemoveEmptyEntries);
            var splitNumbersByDelimiters = splitNumbersAndCustomDelimiters[1].Split(splitCustomSeperators, StringSplitOptions.RemoveEmptyEntries);

            return splitNumbersByDelimiters;
        }
    }
}
