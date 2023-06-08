using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace lab4
{
    public class RealDictionary : IDictionary
    {
        private static readonly string basePath = Regex.Replace(AppContext.BaseDirectory, @"bin.*", "");// not here 
        private readonly string filename;
        private readonly string filePath;

        public RealDictionary(string filename)
        {
            this.filename = filename;
            filePath = $"{basePath}Resourses\\{filename}"; //Path.Combine
        }

        public Dictionary<string, string> LoadDictionary()
        {
            string json = File.ReadAllText(filePath);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return dictionary;
        }

        public void AddNewWord(string ukrainianTranslation, string englishTranslation)
        {
            Dictionary<string, string> dictionary = this.LoadDictionary();
            dictionary.Add(ukrainianTranslation, englishTranslation);
            this.SaveDictionatyFile(dictionary);
        }

        public string FindUkrainianTranslation(string englishTranslation)
        {
            Dictionary<string, string> dictionary = this.LoadDictionary();
            foreach (var dictEntry in dictionary)
                if (dictEntry.Key == englishTranslation)
                    return dictEntry.Value;
            
            return null;
        }

        private void SaveDictionatyFile(Dictionary<string, string> dictionary)
        {
            string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
