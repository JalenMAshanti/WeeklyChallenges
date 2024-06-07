using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
          return char.IsLetter(c);
           //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           
            return (vals.Length % 2 == 0) ? true : false;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {


            return (numbers != null && numbers.Count() != 0) ? numbers.Min() + numbers.Max() : 0;
            
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null) ? numbers.Sum(x => x) : 0;
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            return (numbers != null) ? numbers.Where(x => x % 2 == 0).Sum() : 0;
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null && numbers.Sum() % 2 != 0) ? true : false ;
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long result = 0; 
            if (number < 0)
            {

                result = 0;
            }

            else if (number > 0) {

                for (int i = 0; i < number; i++) { 
                   
                    if (i % 2 != 0) 
                    {
                        result++; 
                    }
             
                
                }

                
            }

             return result;
            //throw new NotImplementedException();
        }
    }
}
