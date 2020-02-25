using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EncoLyze.Structs;

namespace EncoLyze
{
    class Controler
    {
        private object _parent = null;
        private EncodingData _implement = new EncodingData("Not implemented");
        public object Parent { get => _parent; set => _parent = value; }

        public Controler(object parent)
        {
            this.Parent = parent;
        }

        public void TextToBase64(string value)
        {
            ValueToData(Modal.TextToBase64(value));
        }

        public void Base64ToText(string value)
        {
            ValueToData(Modal.Base64ToText(value));
        }
        public void ToHex(string value)
        {
            ValueToData(Modal.HexEncode(value));
        }
        public void FromHex(string value)
        {
            ValueToData(Modal.HexDecode(value));
        }

        public void StringToCharCode(string value)
        {
            ValueToData(Modal.StringToCharCode(value));
        }

        public void CharCodeToString(string value)
        {
            ValueToData(Modal.CharCodeToString(value));
        }

        // Rigth click //
        public string ToUpperCase(string text)
        {
            return Modal.ToUpperCase(text);
        }

        public string ToLowercase(string text)
        {
            return Modal.ToLowercase(text);
        }

        public string InverseCase(string text)
        {
            return Modal.InverseCase(text);
        }

        public void UpdateText(string text)
        {
            ValueToData(Modal.StringToValue(text));
        }

        private void ValueToData(EncodingData data)
        {
            (this.Parent as Form1).SetRtbText(data.text);
            (this.Parent as Form1).SetLength(data.length);
            (this.Parent as Form1).SetNumberNum(data.numberNum);
            (this.Parent as Form1).SetLineNumber(data.lineNumber);
            (this.Parent as Form1).SetWordNumber(data.wordNumber);
        }

    }
}
