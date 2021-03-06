using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCsvApp.Events
{
    public class BadWordsEvents<T> where T: new()
    {

        public event EventHandler<T> BadWordDetected;
        public delegate void MyDelegate(string a) ;
         List<string> badWords = new List<string>() { "Darn", "Shit", "Damn" };
        public bool BadWordDetector(string values)
        {
            
            bool hasBadWord = false;
            foreach (var badword in badWords)
            {
                if (values.ToLower().Contains(badword.ToLower()))
                {
                    hasBadWord = true;
                    T item = new T();
                    BadWordDetected?.Invoke(this, item);
                   


                    break;
                }
            }

            

            return hasBadWord;

        }
        public static void Checker_BadWordDetected(object sender, T e)
        {
            Console.WriteLine($"Bad word was detected while adding {e.GetType().Name}");
        }

    }
}
