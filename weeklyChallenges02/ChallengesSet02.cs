using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges02
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            if (alphabet.ToLower().Contains(c) || alphabet.ToUpper().Contains(c))

            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int totalElements = vals.Count();
            int isEven = totalElements % 2;
            if (totalElements == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            int numberIsEven = number % 2;
            if (numberIsEven == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsNumberOdd(int num)
        {
            int numberIsOdd = num % 2;
            if (numberIsOdd != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if(numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if ( str1.Length <= str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }

        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
