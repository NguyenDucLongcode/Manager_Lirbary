using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class FucString
    {
        public static string Standard(string input)
        {
            return input.Trim();
        }

        public static string FirstCapitalLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.Trim().ToLower();
        }

        public static bool ContainsSpecialCharacters(string input)
        {
            // Logic kiểm tra ký tự đặc biệt
            return false;
        }
    }
}
