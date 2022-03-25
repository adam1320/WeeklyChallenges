using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (string.Equals(words, null) || words.Contains(null))
            { return false; }

            if (ignoreCase == true)
            { word = word.ToLower();
                List<string> lcString = words.Select(x => x.ToLower()).ToList();
               
                containsWord = lcString.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            bool prime = false;
            if (num >= 0)
            {
                if (num % 2 != 0  && num % 3 != 0)
                { prime = true; }

                if (num == 2 || num == 3)
                { prime =  true; }

                if (num == 1)
                { prime = false; }
            }
            return prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uid;

            for (int i = 0; i < str.Length; i++)
            {
                uid = true;
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == str[j] && i != j)
                        { uid = false; }

                    }
                }
                if (uid == true)
                {index = i; }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i <= numbers.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount ++;
                }
                if (currentCount> count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();
            var nullCheck = new double[0];

            if (elements == null || elements.Count == 0)
            { return nullCheck; }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }
             
            return nthElement.ToArray();
        }
    }
}
