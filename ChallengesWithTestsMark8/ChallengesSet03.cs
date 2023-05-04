using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null) 
            { 
                return false;
            }

            foreach (var item in vals)
            {
                //if(var item == false in vals)
                //{
                //    return true;
                //}
            }
            return false;
            //return vals != null && vals.Length != 0 && vals.Contains(false);
        }                                           //vals.All(false); Ask about

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 != 0) 
                {
                    sum += number;
                }
            } 
            return sum % 2 != 0;//same as if else below
            //if (sum % 2 != 0) 
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            //return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
           //if(numbers == null || numbers.Count() == 0)
           // {
           //     return false;
           // }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isLowerUpper = false;
            var isNumber = false;
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
