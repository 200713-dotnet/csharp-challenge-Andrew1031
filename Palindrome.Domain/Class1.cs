using System;

namespace Palindrome.Domain
{
    public class Class1
    {
        public Boolean checkPalindrome(String s)
        {
          if (s.Length == 1 || s.Length == 0)
          {
            return true;
          }
            int firstIndex = 0;
            int secondIndex  = s.Length - 1;

            while (firstIndex < secondIndex)
            {
                if  (firstIndex < secondIndex && s.charAt(firstIndex) != s.charAt(secondIndex))
                {
                    return false;
                }

                firstIndex++;
                secondIndex--;
            }

            return true;

        }
    }
}
