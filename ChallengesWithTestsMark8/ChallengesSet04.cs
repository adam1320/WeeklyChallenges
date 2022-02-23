using System;
using System.Linq;
using System.Collections.Generic;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(i => i % 2 == 0).Sum() - numbers.Where(i => i % 2 != 0).Sum();

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[] { str1, str2, str3, str4 };
            return strings.Min(i => i.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new int[] { number1, number2, number3, number4 };
            return numbers.Min(i => i);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength3 + sideLength1 > sideLength2
                )
                return true;
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            return (double.TryParse(input, out double result));
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int majority = (objs.Count() / 2);
            int nullnumb = 0;

            foreach(object obj in objs)
            {
                if (obj == null)
                { 
                    nullnumb ++;
                }
            }
            if (nullnumb > majority)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 )
            {
                return 0;
            }
            var evenNum = numbers.Where(i => i % 2 == 0);
            if (evenNum.Count() == 0)
            { return 0; }
                return evenNum.Average();
           
            
        }

        public int Factorial(int number)
        {
            if (number == 0)
            { return 1; }
            else if ( number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number - 1; i > 0; i--)
            { 
                number = number * i; 
            }

            return number;
            
        }
    }
}
