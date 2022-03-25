using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var List = new List<int>();
            int max = startNumber * n;

            

            if (startNumber == 0)
            { return n; }

            for (int i = 0; i < max; i++)
            {
                if (i > startNumber && i % n == 0)
                    List.Add(i);
            }
            List.ToArray();
            return List[0];
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length;i++)
            { if (businesses[i].TotalRevenue == 0)
                    businesses[i].Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            for (int i = 1; i < numbers.Length;i++)
            {
                if (numbers[i] < numbers[i - 1])
                { return false; }
            }
            return true;
           
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length;i++)
            { 
                if (numbers[i - 1] % 2 == 0)
                { 
                    sum += numbers[i]; 
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
           
            if (words == null || words.Length == 0)
            {
                return "";
            }
            int goodWords = 0;
            var wordList = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == "  ")
                { }
                else
                { wordList.Add(words[i].Trim());
                    goodWords += 1;
                }

            }
           
            if (goodWords == 0)
            { return ""; }
            else
            {
                return String.Join(" ", wordList) + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            
            if (elements == null || elements.Count == 0)
            {
                 return new double [0];
            }
            var myList = new List<double>();
            for (int i = 3; i < elements.Count; i+=4)
            {
                myList.Add (elements[i]);
            }

            return myList.ToArray(); 
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)
            { return false; }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    { return true; }
                }
            }
            return false;
        }
    }
}
