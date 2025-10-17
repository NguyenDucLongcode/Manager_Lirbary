using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlDsSinhVien
{
    internal class FucString
    {
        // 5. Xóa khoảng trắng dư thừa trong chuỗi
        static public string Standard(string s)
        {
            // Xóa khoảng trắng đầu và cuối chuỗi
            s = s.Trim();
            string s1 = " ";    // 1 khoảng trắng
            string s2 = "  ";   // 2 khoảng trắng
            // Tìm chuỗi s2 trong s
            int index = s.IndexOf(s2);
            while (index != -1)
            {
                s = s.Replace(s2, s1);
                index = s.IndexOf(s2);
            }
            return s;
        }
        // 6. Trả về n kí tự bên trái của chuỗi
        static public string Left(string s, int n)
        {
            return s.Substring(0, n); ;
        }
        // 7. Trả về n kí tự bên phải của chuỗi
        static public string Right(string s, int n)
        {
            return s.Substring(s.Length - n, n);
        }
        // 8. Trả về n kí tự bên phải của chuỗi
        static public string Mid(string s, int index, int n)
        {
            return s.Substring(index, n);
        }

        // 9. Proper(s) Chuỗi có kí tự đầu HOA, các kí tự còn lại thường
        static public string Proper(string s)
        {
            // Xóa khoảng trắng dư thừa và chuyển chuỗi --> chữ thường
            s = Standard(s); s = s.ToLower();

            // Đổi kiểu chuỗi (string) --> mảng kí tự (char array)
            char[] charArr = s.ToCharArray();
            // Xử lý ký tự đầu tiên
            if (char.IsLetter(charArr[0]))
                charArr[0] = char.ToUpper(charArr[0]);

            // Upper kí tự sau khoảng trắng
            for (int i = charArr.Length - 1; i > 0; i--)
            {
                if (charArr[i - 1] == ' ' && char.IsLetter(charArr[i]))
                    charArr[i] = char.ToUpper(charArr[i]);
            }
            //chuyển đổi kiểu mảng kí tự (char array) --> chuỗi (string)
            s = new string(charArr);
            return s;
        }

        public static string FirstCapitalLetter(string s)
        {
            // Xóa khoảng trắng dư thừa và chuyển chuỗi --> chữ thường
            s = Standard(s); s = s.ToLower();

            //Chuyển chuỗi thành mảng chuỗi dựa vào kí tự khoảng trắng ' '
            string[] Words = s.Split(' ');
            s = "";
            foreach (string st in Words)
            {
                if (st.Length > 1)
                    s += st.Substring(0, 1).ToUpper() + st.Substring(1) + " ";
                else
                    s += st.ToUpper() + " ";
            }
            // Xóa khoảng trắng đầu và cuối chuỗi
            return s.Trim();
        }

        // Hàm mới: Kiểm tra chuỗi có chứa ký tự đặc biệt không
        // Return: true = có ký tự đặc biệt, false = không có ký tự đặc biệt
        static public bool ContainsSpecialCharacters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            foreach (char c in s)
            {
                // Chỉ cho phép: chữ cái, số, khoảng trắng, và ký tự tiếng Việt
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c) &&
                    !"ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ".Contains(c))
                {
                    return true; // Có ký tự đặc biệt
                }
            }
            return false; // Không có ký tự đặc biệt
        }

        // Hàm mới: Loại bỏ ký tự đặc biệt
        static public string RemoveSpecialCharacters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) ||
                    "ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ".Contains(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        // Hàm mới: Chuẩn hóa và loại bỏ ký tự đặc biệt
        static public string StandardAndRemoveSpecialChars(string s)
        {
            s = RemoveSpecialCharacters(s);
            return Standard(s);
        }
    }
}
