using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Main
{
    public static class Kata
    {
        public static string DuplicateEncode(string word)
        {
            var result = string.Empty;
            var lowercaseWord = word.ToLower();
            foreach (var character in lowercaseWord)
            {
                var occurences = lowercaseWord.Count(c => c == character); //If this was an intensive operation then I would maybe not do this on each itteration
                if (occurences > 1)
                {
                    result += ")";
                }
                else
                {
                    result += "(";
                }
                
            }
            return result;
        }
    }
}
