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
            char firstPointer = s.charAt(firstIndex);
            char secondPointer = s.charAt(secondIndex);

            while (firstIndex < secondIndex)
            {
              
            }

        }
    }
}
