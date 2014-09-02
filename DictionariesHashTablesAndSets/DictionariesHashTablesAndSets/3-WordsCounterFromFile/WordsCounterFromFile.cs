using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_WordsCounterFromFile
{
    class WordsCounterFromFile
    {
        static void Main()
        {
            string text = File.ReadAllText("../../words.txt");

            StringBuilder textWithoutNonWords = new StringBuilder();
            Dictionary<string, int> countOccurrenceOfEachWord = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetterOrDigit(text[i]))
                {
                    textWithoutNonWords.Append(" ");
                }
                else
                {
                    textWithoutNonWords.Append(char.ToLower(text[i]));
                }
            }

            string[] allWords = textWithoutNonWords.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            countOccurrenceOfEachWord =  FindOccurrences(countOccurrenceOfEachWord, allWords);

            var sortedCountOccurrenceOfEachWord = from pair in countOccurrenceOfEachWord
                        orderby pair.Value ascending
                        select pair;

            foreach (var occurrence in sortedCountOccurrenceOfEachWord)
            {
                Console.WriteLine("{0} -> {1}", occurrence.Key, occurrence.Value);
            }
        }

        private static Dictionary<string, int> FindOccurrences(Dictionary<string, int> countOccurrenceOfEachWord, string[] allWords)
        {
            for (int i = 0; i < allWords.Length; i++)
            {
                if (!countOccurrenceOfEachWord.ContainsKey(allWords[i]))
                {
                    countOccurrenceOfEachWord.Add(allWords[i], 1);
                }
                else
                {
                    countOccurrenceOfEachWord[allWords[i]]++;
                }
            }

            return countOccurrenceOfEachWord;
        }
    }
}
