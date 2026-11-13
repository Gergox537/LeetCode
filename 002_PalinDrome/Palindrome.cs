using System;
using System.Linq;

namespace PalindromeNumber
{
    public class Solution 
    {
        public bool IsPalindrome(int x) 
        {
            string szoveg = x.ToString();
            string forditott = new string(szoveg.Reverse().ToArray());

            return szoveg == forditott; // Rövidített, letisztult if-else
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Tesztesetek a kód működésének bemutatására
            int[] testCases = { 121, -121, 10, 1221 };

            Console.WriteLine("--- Palindrome Number Megoldás ---");
            
            foreach (int test in testCases)
            {
                bool isPal = solution.IsPalindrome(test);
                Console.WriteLine($"A(z) {test, 5} palindrom? : {isPal}");
            }

            // Várakozás, hogy a konzolablak ne záródjon be azonnal
            Console.WriteLine("\nNyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
