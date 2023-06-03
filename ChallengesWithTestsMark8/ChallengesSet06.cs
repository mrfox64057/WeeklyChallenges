using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            if (ignoreCase)
            {
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null)
            {
                return -1;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.LastIndexOf(str[i]) == i && str.IndexOf(str[i]) == i)
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount + 1);
                    currentCount = 0;
                }
            }

            return Math.Max(maxCount, currentCount + 1);
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0 || n > elements.Count)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
