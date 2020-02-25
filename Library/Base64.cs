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
            byte[] plainTextBytes = Encolib.Encode.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string DecodeBase64(string text)
        {
            byte[] plainTextBytes = Convert.FromBase64String(text);
            return Encolib.Encode.GetString(plainTextBytes);
        }

    }
}
