using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> letters = new List<string>();
            foreach (string word  in strings)
            {
                if (word.Length == 4 )
                {
                    letters.Add(word);
                }
            }
            return  letters.ToArray();
        }
    }
}
