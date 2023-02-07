using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    public class Strings
    {
        public void Run()
        {
            string text = "The brown fox jumped over the white dog";
            string startWord = "brown";
            string endWord = "white";
            string replaceWith = " wolf laughed at the ";

            Console.WriteLine(text);
            var Strings = new Strings();
            Console.WriteLine(Strings.GetSubStringBetweenWords(text, startWord, endWord));
            Console.WriteLine(Strings.ReplaceSubStringBetweenWords(text, startWord, endWord, replaceWith));

        }
        public string GetSubStringBetweenWords(string text, string startWord, string endWord)
        {
            int indexStart = text.IndexOf(startWord) + startWord.Length;
            int indexEnd = text.IndexOf(value: endWord, startIndex: indexStart);
            string result = text.Substring(indexStart, indexEnd - indexStart);
            return result;
        }

        public string ReplaceSubStringBetweenWords(string text, string startWord, string endWord, string replaceWith)
        {

            int indexStart = text.IndexOf(startWord) + startWord.Length;
            int indexEnd = text.IndexOf(endWord, indexStart);
            string textBetween = text.Substring(indexStart, indexEnd - indexStart);
            string result = text.Replace(textBetween, replaceWith);
            return result;
        }
    }
}
