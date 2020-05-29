using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesProject
{
    public static class Validator
    {
        public static bool IsNullOrEmpty (string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNumeric(string value)
        {
            return int.TryParse(value, out int a);
        }
    }
}
