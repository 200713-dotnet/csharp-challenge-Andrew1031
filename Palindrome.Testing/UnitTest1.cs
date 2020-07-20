using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            String palindrome = "racecar";
            String notPalindrome = "aaz";
            String notPalindrome2 = "zaaf";
            String palindrome2 = "lool";
            Assert.AreEqual(true, isPalindrome(palindrome));
            Assert.AreEqual(false, isPalindrome(notPalindrome));
            Assert.AreEqual(false, isPalindrome(notPalindrome2));
            Assert.AreEqual(true, isPalindrome(palindrome2));
        }
    }
}
