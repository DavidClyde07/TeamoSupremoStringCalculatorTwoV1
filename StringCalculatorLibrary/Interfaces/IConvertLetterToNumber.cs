using System.Collections.Generic;

namespace StringCalculatorLibrary.Interfaces
{
    public interface IConvertLetterToNumber
    {
        IEnumerable<int> ConvertListOfStringToListOfInt(IEnumerable<string> input);
    }
}