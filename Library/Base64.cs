using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoLyze.Library
{
    static class Base64
    {
        public static string EncodeToBase64(string text)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string DecodeBase64(string text)
        {
            byte[] plainTextBytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(plainTextBytes);
        }

    }
}
