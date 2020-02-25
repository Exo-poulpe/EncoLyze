using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoLyze.Library
{
    class Encolib
    {
        private string _textValue = string.Empty;
        private static Encoding encode = Encoding.UTF8;
        
        public string TextValue { get => _textValue; set => _textValue = value; }
        public static Encoding Encode { get => encode;}

        public Encolib(string value)
        {
            this.TextValue = value;
        }

        public void SetEncoding(Encoding Newencode)
        {
            encode = Newencode;
        }

        public void UpdateValue(string value)
        {
            this.TextValue = value;
        }

        public string B64Encode()
        {
            return Base64.EncodeToBase64(this.TextValue);
        }

        public string B64Decode()
        {
            return Base64.DecodeBase64(this.TextValue);
        }

        public string HexEncode()
        {
            return Hexa.EncodeHex(this.TextValue);
        }

        public string HexDecode()
        {
            return Hexa.DecodeHex(this.TextValue);
        }

        public string StringToCharCode()
        {
            return TextEditor.StringToCharCode(this.TextValue);
        }

        public string CharCodeToString()
        {
            return TextEditor.CharCodeToString(this.TextValue);
        }

    }
}
