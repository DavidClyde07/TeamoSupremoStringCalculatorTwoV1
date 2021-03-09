using System;
using System.Collections.Generic;
using StringCalculatorLibrary.Interfaces;

namespace StringCalculatorLibrary
{
    public class ConvertLetterToNumber : IConvertLetterToNumber
    {
        const int MaxLetter = 10;
        const int a_Assci = 97;

        public IEnumerable<int> ConvertListOfStringToListOfInt(IEnumerable<string> input)
        { 
            foreach (var item in input)
            {
                if(item.Length ==1  && !Char.IsDigit(Char.Parse(item)))
                {
                    int letterNumber =  ((int)Char.Parse(item) - a_Assci);
                    
                    if(letterNumber < MaxLetter)
                    {
                       yield return letterNumber;
                    }
                }
                else
                {
                    yield return(int.Parse(item));
                }
            }
        }
    }
}
