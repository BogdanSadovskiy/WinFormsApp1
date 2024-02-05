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
        public static bool calculatorRegexNumber(string str)
        {
            if (str == null) return false;
            regex = new Regex(calculatorNumber);
            return regex.IsMatch(str);
        }
    }
}
