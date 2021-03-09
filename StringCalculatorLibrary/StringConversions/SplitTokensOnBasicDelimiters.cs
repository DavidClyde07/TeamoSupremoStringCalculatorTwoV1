using StringCalculatorLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace StringCalculatorLibrary.StringConversions
{
    public class SplitTokensOnBasicDelimiters : IStringSplitter
    {
        private string[] _delimiters = new[] { ",", "\n" };

        public IEnumerable<string> SplitTokensOnDelimiters(string numbers)
        {
            return numbers.Split(_delimiters, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
