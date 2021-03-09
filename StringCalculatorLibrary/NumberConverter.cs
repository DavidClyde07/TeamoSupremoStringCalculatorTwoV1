using System.Linq;
using System.Collections.Generic;


namespace StringCalculatorLibrary
{
    public static class NumberConverter
    {
        public static IEnumerable<string> ConvertNegativesToPositives(this IEnumerable<string> splitTokens)
        {
            return splitTokens.Select(number => number.Replace("-", string.Empty));
        }
    }
}
