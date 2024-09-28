using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SimonovMA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');

            string[] ModifiedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 1)
                {
                    ModifiedWords[i] = word.Substring(1) + word[0];
                }
                else
                {
                    ModifiedWords[i] = word;
                }
            }

            return string.Join(" ", ModifiedWords);
        }
    }
}




// НАДУМАЛ ВСЯКОГО
//public string[] MoveLetterToEnd(string value)
//{
//    string[] words = value.Split(' ');

//    string[] ModifiedWords = new string[words.Length];

//    for (int i = 0; i < words.Length; i++)
//    {
//        string word = words[i];
//        if (word.Length > 1)
//        {
//            ModifiedWords[i] = word.Substring(1) + word[0];
//        }
//        else
//        {
//            ModifiedWords[i] = word;
//        }
//    }

//    return ModifiedWords;
//}