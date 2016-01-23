using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BackupScheduler.Helpers
{
    public static class FrequencyHelper
    {
        private static string minRegex = @"^([0-5]?\d)$";
        private static string hourRegex = @"^([01]?\d|2[0-3])$";
        private static string dayRegex = @"^(0?[1-9]|[12]\d|3[01])$";
        private static string monthRegex = @"^([1-9]|1[012])$";
        private static string dowRegex = @"^([0-7])$";

        public static bool FrequencyIsValid(string frequency)
        {
            var fields = frequency.Split(' ');

            if (fields.Length == 5)
            {
                bool isValid = true;

                // Fields must past every test to be a valid frequency
                isValid &= TestField(fields[0], minRegex);
                isValid &= TestField(fields[1], hourRegex);
                isValid &= TestField(fields[2], dayRegex);
                isValid &= TestField(fields[3], monthRegex);
                isValid &= TestField(fields[4], dowRegex);

                return isValid;
            }

            return false;
        }

        private static bool TestField(string field, string pattern)
        {
            if (field != "*")
            {
                var regex = new Regex(pattern);

                return regex.IsMatch(field);
            }

            return true;
        }
    }
}
