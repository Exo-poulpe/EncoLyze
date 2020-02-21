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

        public static Value TextToBase64(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.B64Encode();
            return StringToValue(value);
        }

        public static Value Base64ToText(string text)
        {
            Encolib enco = new Encolib(text);
            string value = enco.B64Decode();
            return StringToValue(value);
        }


        private static Value StringToValue(string text)
        {
            long length = (long)text.Length;
            long numberNum = 0;
            text.ToCharArray().ToList().ForEach((char c) => { if (Char.IsDigit(c)) { numberNum += 1; } });
            long lineNumber = 1;
            text.ToCharArray().ToList().ForEach((char c) => { if (c.ToString() == Environment.NewLine) { lineNumber += 1; } });
            long wordNumber = 1;
            text.ToCharArray().ToList().ForEach((char c) => { if (Char.IsWhiteSpace(c)) { wordNumber += 1; } });

            return new Value(text, length, numberNum, lineNumber, wordNumber);
            

        }

    }
}
