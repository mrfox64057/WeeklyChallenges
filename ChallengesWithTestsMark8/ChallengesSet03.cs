using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //if (vals == null) 
            //{ 
            //    return false;
            //}

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
            //return vals != null && vals.Length != 0 && vals.Contains(false);
        }                                           //vals.All(false); Ask about

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //if (numbers == null)
            //{
            //    return false;
            //}

            int sum = 0;

            //foreach (var number in numbers)
            //{
            //    if (number % 2 != 0) 
            //    {
            //        sum += number;
            //    }
            //} 
            //return sum % 2 != 0;//same as if else below
            //if (sum % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
            //if (numbers == null || numbers.Count() == 0)
            //{
            //    return false;
            //}
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //return password.Any(c => char.IsLetter(c)) && password.Any(c => char.IsDigit(c)) && password.Any(c => char.IsUpper(c));

            var isLower = false;
            var isDigit = false;
            var isUpper = false;
            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLower = true;
                }
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
            }
            if (isLower && isDigit && isUpper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException();
            }
            return val[0];

            //oneLine  //public char GetFirstLetterOfString(string val) => string.IsNullOrEmpty(val) ? throw new ArgumentException() : val.First(c => char.IsLetterOrDigit(c));

            //if (string.IsNullOrEmpty(val))
            //{
            //    throw new ArgumentException();
            //}

            //char firstChar = val[0];

            //if (!char.IsLetterOrDigit(firstChar))
            //{
            //    throw new ArgumentException();
            //}

            //return firstChar;
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length - 1];
            //oneLine  public char GetLastLetterOfString(string val) => string.IsNullOrEmpty(val) ? throw new ArgumentException() : val.Last(c => char.IsLetterOrDigit(c));

            //if (string.IsNullOrEmpty(val))
            //{
            //    throw new ArgumentException();
            //}

            //char lastChar = val[val.Length - 1];

            //if (!char.IsLetterOrDigit(lastChar))
            //{
            //    throw new ArgumentException();
            //}

            //return lastChar;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
            //int[] result = new int[50];
            //int count = 0;
            //int num = 1;
            //do
            //{
            //    if (num % 2 != 0)
            //    {
            //        result[count] = num;
            //        count++;
            //    }
            //    num++;
            //} while (count < 50);
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = words[i].ToUpper();
            //}

            //oneLine  words = words.Select(w => w.ToUpper()).ToArray();  

            for (int i = 0; i < words.Length; i++)
            {
                switch (words[i])
                {
                    case null:
                        words[i] = null;
                        break;
                    case "":
                        words[i] = "";
                        break;
                    default:
                        words[i] = words[i].ToUpper();
                        break;
                }
            }


        }
    }
}
