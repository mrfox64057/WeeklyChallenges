using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            //foreach (int num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        result += num;
            //    }
            //    else
            //    {
            //        result -= num;
            //    }
            //}
            //return result;

            return numbers.Where(n => n % 2 == 0).Sum() - numbers.Where(n => n % 2 != 0).Sum();

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //int[] lengths = { str1.Length, str2.Length, str3.Length, str4.Length };
            //Array.Sort(lengths);
            //return lengths[0];

            return new[] { str1, str2, str3, str4 }.Min(s => s.Length);

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //int smallest = number1;
            //if (number2 < smallest)
            //{
            //    smallest = number2;
            //}
            //if (number3 < smallest)
            //{
            //    smallest = number3;
            //}
            //if (number4 < smallest)
            //{
            //    smallest = number4;
            //}
            //return smallest;

            //return new[] { number1, number2, number3, number4 }.Min();

            return Math.Min(number1, Math.Min(number2, Math.Min(number3, number4)));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Dictionary<string, string> nameChanges = new Dictionary<string, string>()
            {
            };

            if (biz.Name == null)
            {
                biz.Name = "TrueCoders";
            }
            else if (nameChanges.ContainsKey(biz.Name))
            {
                biz.Name = nameChanges[biz.Name];
            }
            else
            {
                biz.Name = "TrueCoders";
            }

            //biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength1 + sideLength3 > sideLength2);
            //return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            //try
            //{
            //    double.Parse(input);
            //    return true;
            //}
            //catch (FormatException)
            //{
            //    return false;
            //}
            //catch (ArgumentException)
            //{
            //    return false;
            //}

            //if (input == null)
            //{
            //    return false;
            //}

            //return Regex.IsMatch(input, @"^(\+|-)?\d+(\.\d+)?$");

            double result;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            return count > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return sum / count;
        }

        public int Factorial(int number)
        {
            return number < 0 ? throw new ArgumentOutOfRangeException("number", "Input cannot be negative") : Enumerable.Range(1, number).Aggregate((x, y) => x * y);

            //if (number < 0)
            //{
            //    throw new ArgumentOutOfRangeException("number", "Input cannot be negative");
            //}

            //int result = 1;

            //while (number > 0)
            //{
            //    result *= number;
            //    number--;
            //}

            //return result;
        }
    }
}
