using System.Collections.Generic;

namespace lab4
{
    public interface IDictionary
    {
        Dictionary<string, string> LoadDictionary();
        void AddNewWord(string ukrainianTranslation, string englishTranslation);
        string FindUkrainianTranslation(string englishTranslation);
    }
}
