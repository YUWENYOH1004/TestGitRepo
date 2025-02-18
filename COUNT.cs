// ANKINIMBOM YUWENYOH
// 02/16/2025

using System;
namespace STRINGS
{
    class Program
    {
        public static int countWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' });
            return words.Length;
        }

        public static void Main()
        {
            // 1. counting words in a sentence.
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int value = Program.countWords(sentence);
            Console.WriteLine(value);
            // 2. flipping values.
            string value2 = flipping.flipEnd(sentence);
            Console.WriteLine(value2);
            // 3. checking order of words.
            Console.Write("enter a word: ");
            string word = Console.ReadLine();
            string output = Order.IsInOrder(word);
            Console.WriteLine(output);
            // 4. checking for vowels.
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            string value3 = Vowels.CountVowel(sentence, n);
            Console.WriteLine(value3);
            // 5. alphabet switch.
            string value4 = Alphabet.Move(word);
            Console.WriteLine(value4);
        }
    }

}
