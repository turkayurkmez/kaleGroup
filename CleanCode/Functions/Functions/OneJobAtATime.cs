using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class OneJobAtATime
    {
        List<string> getWordsStartWithInCollection(string letter, List<string> words)
        {
            List<string> wordWithStartingA = new List<string>();
            foreach (var word in words)
            {
                checkFirstLetter(wordWithStartingA, word);
            }

            return wordWithStartingA;

        }
        private static void checkFirstLetter(List<string> wordWithStartingA, string word)
        {
            if (word.StartsWith("A"))
            {
                wordWithStartingA.Add(word);
            }
        }
    }
}
