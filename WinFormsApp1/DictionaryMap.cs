
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.IO;
namespace FirstApp
{

    public class DictionaryBook
    {
        private string Eng_Ukr_dictionaryFile = "Eng_Ukr_File";
        private string Ukr_Eng_dictionareFile = "Ukr_Eng_File";
        private Dictionary<string, string> Eng_Ukr;
        private Dictionary<string, string> Ukr_Eng;

        public DictionaryBook()
        {
            Eng_Ukr = new Dictionary<string, string>();
            Ukr_Eng = new Dictionary<string, string>();
            downloadDictionaries();
        }
        public bool isWordExist(string key, string value, bool engDictionary)
        {
            if(engDictionary)
            {
                if(Eng_Ukr.ContainsKey(key))
                {
                    if (Eng_Ukr[key] == value) return true;
                }
                return false;
            }
            if(Ukr_Eng.ContainsKey(key))
            {
                if (Ukr_Eng[key] == value) return true;
            }
            return false;
        }
        public void addWordEng_Ukr(string key, string value)
        {
            Eng_Ukr.Add(key, value);
        }
        public void addWordUkr_Eng(string key, string value)
        {
            Ukr_Eng.Add(key, value);
        }
        private void uploadDictionaries()
        {
           uploadEngUkrDictionary();
           uploadUkrEngdictionary();
        }
        private void uploadEngUkrDictionary()
        {
            string json= JsonConvert.SerializeObject(Eng_Ukr);
            File.WriteAllText(Eng_Ukr_dictionaryFile,json);
        }
        private void uploadUkrEngdictionary()
        {
            string json = JsonConvert.SerializeObject(Ukr_Eng);
            File.WriteAllText(Ukr_Eng_dictionareFile,json); 
        }
        private void downloadDictionaries()
        {
            if (File.Exists(Eng_Ukr_dictionaryFile))
            {
                string json = File.ReadAllText(Eng_Ukr_dictionaryFile);
                Eng_Ukr = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            if (File.Exists(Ukr_Eng_dictionareFile))
            {
                string json = File.ReadAllText(Ukr_Eng_dictionareFile);
                Ukr_Eng = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }

        }
    }
}
