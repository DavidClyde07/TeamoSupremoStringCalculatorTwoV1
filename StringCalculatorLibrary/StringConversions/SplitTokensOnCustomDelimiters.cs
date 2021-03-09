using StringCalculatorLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace StringCalculatorLibrary.StringConversions
{
    public class SplitTokensOnCustomDelimiters : IStringSplitter
    {
        const string NewLineDelimiter = "\n";
        private string[] _customDelimiters = new[] { "##", "[", "]" };

        public IEnumerable<string> SplitTokensOnDelimiters(string numbers)
        {
            var splitTokensAndDelimiters = numbers.Split(NewLineDelimiter, StringSplitOptions.RemoveEmptyEntries);
            var splitCustomDelimiters = splitTokensAndDelimiters[0].Split(_customDelimiters, StringSplitOptions.RemoveEmptyEntries);
            var splitTokens = splitTokensAndDelimiters[1].Split(splitCustomDelimiters, StringSplitOptions.RemoveEmptyEntries);

            return splitTokens;
        }
    }
}
