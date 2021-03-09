using System.Collections.Generic;

namespace StringCalculatorLibrary.Interfaces
{
    public interface IStringSplitter
    {
        IEnumerable<string> SplitTokensOnDelimiters(string numbers);
    }
}
