using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCsvApp.Events
{
    public class BadWordsEvents<T>
    {

       
         List<string> badWords = new List<string>() { "Darn", "Shit", "Damn" };
        public bool BadWordDetector(string values, T item)
        {
            
            bool hasBadWord = false;
            foreach (var badword in badWords)
            {
                if (values.ToLower().Contains(badword.ToLower()))
                {
                    hasBadWord = true;
                    break;
                }
            }

            return hasBadWord;

        }
    }
}
