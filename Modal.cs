using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EncoLyze.Structs;
using EncoLyze.Library;

namespace EncoLyze
{
    static class Modal
    {

        public static EncodingData TextToBase64(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.B64Encode();
            return StringToValue(value);
        }

        public static EncodingData Base64ToText(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.B64Decode();
            return StringToValue(value);
        }

        public static EncodingData HexEncode(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.HexEncode();
            return StringToValue(value);
        }

        public static EncodingData HexDecode(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.HexDecode();
            return StringToValue(value);
        }

        public static EncodingData CharCodeToString(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.CharCodeToString();
            return StringToValue(value);
        }

        public static EncodingData StringToCharCode(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.StringToCharCode();
            return StringToValue(value);
        }

        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string ToLowercase(string text)
        {
            return text.ToLower();
        }

        public static string InverseCase(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsUpper(sb[i]))
                {
                    sb[i] = Char.ToLower(sb[i]);
                }
                else if (Char.IsLower(sb[i]))
                {
                    sb[i] = Char.ToUpper(sb[i]);
                }
            }

            return sb.ToString();
        }


        public static EncodingData StringToValue(string text)
        {
            long length = (long)text.Length;
            long numberNum = 0;
            text.ToCharArray().ToList().ForEach((char c) => { if (Char.IsDigit(c)) { numberNum += 1; } });
            long lineNumber = 1;
            text.ToCharArray().ToList().ForEach((char c) => { if (c.ToString() == Environment.NewLine) { lineNumber += 1; } });
            long wordNumber = 1;
            text.ToCharArray().ToList().ForEach((char c) => { if (Char.IsWhiteSpace(c)) { wordNumber += 1; } });

            return new EncodingData(text, length, numberNum, lineNumber, wordNumber);
        }



    }
}
