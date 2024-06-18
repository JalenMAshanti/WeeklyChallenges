using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool IsOdd = (numbers != null) ? numbers.Where(x => x % 2 !=0).Sum() % 2 != 0: false; 
            return IsOdd;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           return password.Any(Char.IsDigit) && password.Any(Char.IsUpper) && password.Any(Char.IsLower);
            
        }

        public char GetFirstLetterOfString(string val)
        {
           return Convert.ToChar(val.Substring(0,1));          
        }

        public char GetLastLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0:dividend / divisor;  
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 100; i++) 
            {
                if (i % 2 != 0) 
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();            
            }
        }
    }
}
