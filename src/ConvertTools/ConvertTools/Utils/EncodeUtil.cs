using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ConvertTools.Utils
{
    internal class EncodeUtil
    {
        private static MD5 _MD5 = new MD5CryptoServiceProvider();
        private static SHA1 _SHA1 = new SHA1CryptoServiceProvider();

        public static string UrlEncode(string text, Encoding encoding)
        {
            return HttpUtility.UrlEncode(text, encoding);
        }

        public static string UrlDecode(string text, Encoding encoding)
        {
            return HttpUtility.UrlDecode(text, encoding);
        }

        public static string UnicodeEncode(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append("\\u");
                sb.Append(((int)text[i]).ToString("x"));
            }
            return sb.ToString();
        }

        public static string UnicodeDecode(string text)
        {
            StringBuilder sb = new StringBuilder();
            string[] split = text.Split("\\u");
            for (int i = 1; i < split.Length; i++)
            {
                int charCode = Convert.ToInt32(split[i], 16);
                sb.Append((char)charCode);
            }
            return sb.ToString();
        }

        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(text));
        }

        public static string Base64Decode(string text)
        {
            return Encoding.Default.GetString(Convert.FromBase64String(text));
        }

        public static string MD5Encrypt(string text)
        {
            byte[] result = _MD5.ComputeHash(Encoding.Default.GetBytes(text));
            return BitConverter.ToString(result).Replace("-", "");
        }

        public static string SHA1Encrypt(string text)
        {
            byte[] result = _SHA1.ComputeHash(Encoding.Default.GetBytes(text));
            return BitConverter.ToString(result).Replace("-", "");
        }
    }
}
