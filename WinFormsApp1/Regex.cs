using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class RegexExpr
    {
        private static Regex regex;
        private static string calculatorNumber = "^-?\\d*(\\.\\d*)?$";
        private static string englishWord = "^([A-Za-z])+$";
        private static string ukrainianWord = "^[а-яА-ЯіїґҐІЇ]+$";
        public static bool calculatorRegexNumber(string str)
        {
            if (str == null) return false;
            regex = new Regex(calculatorNumber);
            return regex.IsMatch(str);
        }
        public static bool onlyEnglishWord(string str)
        {
            if (str == null) return false;
            regex = new Regex(englishWord);
            return regex.IsMatch(str);
        }
        public static bool onlyUkrainianWord(string str)
        {
            if (str == null) return false;
            regex = new Regex(ukrainianWord);
            return regex.IsMatch(str);
        }
    }
}
