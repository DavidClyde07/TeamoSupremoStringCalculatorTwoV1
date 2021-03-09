﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class ValidateNumbers
    {
        const int MaxLimit = 1000;
        public static void ThrowExceptionIfOverMaxLimit(this IEnumerable<int> input)
        {
            if(input.Any(number => number>MaxLimit))
            {
                throw new ArgumentException($"Numbers over {MaxLimit} are not allowed. You entered: {String.Join(", ", input.Where(number => number >MaxLimit))}");
            }
        }
    }
}