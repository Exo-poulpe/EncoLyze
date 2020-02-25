using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoLyze.Library
{
    static class Hexa
    {

        public static string EncodeHex(string value)
        {
            byte[] ba = Encoding.UTF8.GetBytes(value);
            string hexString = BitConverter.ToString(ba).Replace("-","");
            return hexString;
        }

        public static string DecodeHex(string value)
        {
            byte[] raw = new byte[value.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(value.Substring(i * 2, 2), 16);
            }
            return Encolib.Encode.GetString(raw);
        }
    }
}
