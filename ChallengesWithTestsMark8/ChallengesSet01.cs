﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }   
            else
            {
                return number2;
            }

        }

    public long Multiply(long factor1, long factor2)
        {
            long answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
       
        {
            if (string.IsNullOrEmpty(nameOfPerson))
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
            
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
