using System;

namespace lab4
{
    public class MenuManager
    {
        private IDictionary proxyDictionary;

        public MenuManager(IDictionary proxyDictionary)
        {
            this.proxyDictionary = proxyDictionary;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1 - View dictionary content\n" +
                "2 - Find Ukrainian translation for the English word\n" +
                "3 - Add new word");
        }

        public void ProcessOptions()
        {
            while (true)
            {
                Console.Write("\nChoose option:\t");

                switch (Console.ReadLine())
                {
                    case "1":
                        var dictionaryData = proxyDictionary.LoadDictionary();
                        foreach (var dictEntry in dictionaryData)
                        {
                            Console.WriteLine(dictEntry.Key + " = " + dictEntry.Value);
                        }
                        break;
                    case "2":
                        Console.Write("\nEnter english word:\t");
                        string englishWord = Console.ReadLine();
                        proxyDictionary.FindUkrainianTranslation(englishWord);
                        break;
                    case "3":
                        Console.Write("\nEnter English translation:\t");
                        string englishTranslation = Console.ReadLine();
                        Console.Write("Enter Ukrainian translation:\t");
                        string ukranianTranslation = Console.ReadLine();
                        proxyDictionary.AddNewWord(ukranianTranslation, englishTranslation);
                        break;
                    default:
                        Console.WriteLine("Unexcisting option input. Try again.");
                        break;
                }
            }
        }
    }
}
