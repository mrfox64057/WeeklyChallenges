using ChallengesWithTestsMark8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        //ChatGPT answers at bottom
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n; int nextNumber = startNumber + (n - remainder) % n; return nextNumber == startNumber ? startNumber + n : nextNumber; 
            
            //int remainder = startNumber % n;
            //int nextNumber = startNumber + (n - remainder) % n;
            //return nextNumber == startNumber ? startNumber + n : nextNumber;

        }


        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++) if (businesses[i].TotalRevenue == 0) businesses[i].Name = "CLOSED";

            //for (int i = 0; i < businesses.Length; i++)
            //{
            //    if (businesses[i].TotalRevenue == 0)
            //    {
            //        businesses[i].Name = "CLOSED";
            //    }
            //}
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder sentence = new StringBuilder();
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    sentence.Append(word.Trim());
                    sentence.Append(" ");
                }
            }

            if (sentence.Length > 0)
            {
                sentence[sentence.Length - 1] = '.'; 
            }

            return sentence.ToString().Trim();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (set.Contains(complement))
                {
                    return true;
                }
                set.Add(num);
            }

            return false;
        }
    }
}



//public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses) => { for (int i = 0; i < businesses.Length; i++) { if (businesses[i].TotalRevenue == 0) { businesses[i].Name = "CLOSED"; } } }

//public int GetNextNumberDivisibleByN(int startNumber, int n) => startNumber + (n - (startNumber % n)) % n;

//public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses) { for (int i = 0; i < businesses.Length; i++) if (businesses[i].TotalRevenue == 0) businesses[i].Name = "CLOSED"; }

//public bool IsAscendingOrder(int[] numbers) => numbers != null && numbers.Length > 0 && Enumerable.Range(1, numbers.Length - 1).All(i => numbers[i] >= numbers[i - 1]);

//public int SumElementsThatFollowAnEven(int[] numbers) => numbers != null && numbers.Length >= 2 ? numbers.Where((num, i) => i < numbers.Length - 1 && num % 2 == 0).Sum(num => numbers[num + 1]) : 0;

//public string TurnWordsIntoSentence(string[] words) => words != null && words.Length > 0 ? string.Join(" ", words.Where(word => !string.IsNullOrWhiteSpace(word)).Select(word => word.Trim())) + "." : string.Empty;

//public double[] GetEveryFourthElement(List<double> elements) => elements?.Where((element, i) => i % 4 == 3).ToArray() ?? new double[0];

//public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber) => nums != null && nums.Length >= 2 && nums.Distinct().Any(num => nums.Contains(targetNumber - num));

