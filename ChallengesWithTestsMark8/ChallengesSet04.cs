using System;
using System.Linq;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers.Sum() == 0) 
            {
                return 0;
            }
            int evenSum = numbers.Where(x => x % 2 == 0).Sum();
            int oddnums = numbers.Where(x => x % 2 != 0).Sum();

            return evenSum - oddnums;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] texts = new string[] { str1, str2, str3, str4 };
            int length = texts.Select(x => x.Length).Min();
            return length;
          
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] nums = new int[] { number1, number2, number3, number4 }; 
            int shortestnum = nums.Select(x => x).Min();
            return shortestnum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] lengths = new int[]{ sideLength1, sideLength2, sideLength3 };
            if (lengths[0] !> 0 || lengths[1] !> 0 || lengths[2] !> 0)
            {
                return false;

            }
            else
            {
                return (lengths[0] + lengths[1] > lengths[2] && lengths[1] + lengths[2] > lengths[0] && lengths[0] + lengths[2] > lengths[1]);
            }
        }

        public bool IsStringANumber(string input)
        {
    
            bool isNumber = int.TryParse(input, out int number);
            bool isDecimal = double.TryParse(input, out double number2);
            if (isNumber || isDecimal)
            {
                return true;
            }
            else 
            {
                return false;
            }
         
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            
            bool nullAmountIsGreater = (objs.Where(x => x == null).Count() > objs.Where(x => x != null).Count()) ? true : false;
            return nullAmountIsGreater; 
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Sum() == 0 || numbers.Where(x => x % 2 == 0).Count() == 0)
            {
                return 0;
            }
            else 
            { 
                return numbers.Where(x => x % 2 == 0).Average();
            }
            

        }

        public int Factorial(int number)
        {
            if (number < 0) 
            {
                throw new ArgumentOutOfRangeException();
            }
            else if(number == 1 || number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
