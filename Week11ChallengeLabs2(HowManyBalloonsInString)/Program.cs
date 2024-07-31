
namespace Week11ChallengeLabs2_HowManyBalloonsInString_;
using System.Collections.Generic;

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
        Console.WriteLine(numOfWords("nlaebolkonlaebolkonlaebolkonlaebolkonlaebolkonlaebolko"));
    }
        static int numOfWords (string text)
        {
            int numOfWords = 0;
            Dictionary<char, int> lettersCount = new Dictionary<char, int>()
            {
                {'b' , 0 } , {'a' , 0 } , {'l' , 0 } , {'o' , 0 } , {'n' , 0 }
            };
      
            foreach (char letter in text)
            {
                 if (lettersCount.ContainsKey(letter))
                {
                    lettersCount[letter]++;
                }
                
            } 

            if (!(lettersCount.ContainsKey('b') && 
                lettersCount.ContainsKey('a') &&
                lettersCount.ContainsKey('l') &&
                lettersCount.ContainsKey('o') &&
                lettersCount.ContainsKey('n')))
            {
                return 0;
            }

            while (lettersCount['b'] >= 1 &&
            lettersCount['a'] >= 1 &&
            lettersCount['l'] >= 2 &&
            lettersCount['o'] >= 2 &&
            lettersCount['n'] >= 1) 
           
            {
                numOfWords++;
                lettersCount['b']--;
                lettersCount['a']--;
                lettersCount['l']-=2;
                lettersCount['o']-=2;
                lettersCount['n']--;         
            }

            return numOfWords;
           

        }
    }


