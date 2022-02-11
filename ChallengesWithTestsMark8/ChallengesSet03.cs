using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }

   
            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;
            if (password == null || password.Count() == 0)
            { return false; }
            for (int i = 0; i < password.Length; i++)
            {
                
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }
            if (isLower && isNumber && isUpper == true)
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
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            {
                return (dividend / divisor);
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int first = nums[0];
            int last = (nums[nums.Length - 1]);

            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var newArray = new List<int>();
            for (int i = 0; i < 100; i++)
                if (i % 2 != 0)
                {
                newArray.Add(i); 
                }
            return newArray.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
