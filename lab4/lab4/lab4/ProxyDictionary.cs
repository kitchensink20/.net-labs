using System;
using System.Collections.Generic;

namespace lab4
{
    public class ProxyDictionary : IDictionary
    {
        private RealDictionary dictionary;
        private Dictionary<string, string> cachedDictionary;

        public ProxyDictionary(string filename)
        {
            this.dictionary = new RealDictionary(filename);
            cachedDictionary = this.LoadDictionary();
        }

        public Dictionary<string, string> LoadDictionary()
        {
            if (cachedDictionary == null)
            {
                cachedDictionary = dictionary.LoadDictionary();
                Console.WriteLine("Loading dictionary data from file..");
            } else
                Console.WriteLine("Loading dictionary data from cache..");


            return cachedDictionary;
        }

        public string FindUkrainianTranslation(string englishTranslation)
        {
            string ukrainianTranslation = null;
            if(cachedDictionary != null)
            {
                Console.WriteLine("Searching for translation in cache..");
                foreach(var dictEntry in cachedDictionary)
                {
                    if(dictEntry.Key == englishTranslation)
                    {
                        Console.WriteLine($"The translation is {dictEntry.Value}.");
                        ukrainianTranslation = dictEntry.Value;
                        return ukrainianTranslation;
                    }
                }
                Console.WriteLine("Nothing found.");
                return ukrainianTranslation;
            }
            Console.WriteLine("Searching for translation in file..");
            ukrainianTranslation = dictionary.FindUkrainianTranslation(englishTranslation);
            if (ukrainianTranslation == null)
                Console.WriteLine("Nothing found."); // exceptiuon or return null or return wrapper instance 
            else 
                Console.WriteLine($"The translation is {ukrainianTranslation}.");

            return ukrainianTranslation;
        }

        public void AddNewWord(string ukrainianTranslation, string englishTranslation)
        {
            if (cachedDictionary != null)
            {
                Console.WriteLine("Adding new word to cache dictionary..");
                cachedDictionary.Add(englishTranslation, ukrainianTranslation);
            }
            Console.WriteLine("Adding new word to file dictionary..");
            dictionary.AddNewWord(englishTranslation, ukrainianTranslation);
        }

    }
}
