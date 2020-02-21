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
        private Value _implement = new Value("Not implemented");
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
            ValueToData(_implement);
        }
        public void FromHex(string value)
        {
            ValueToData(_implement);
        }

        private void ValueToData(Value data)
        {
            (this.Parent as Form1).SetRtbText(data.text);
            (this.Parent as Form1).SetLength(data.length);
            (this.Parent as Form1).SetNumberNum(data.numberNum);
            (this.Parent as Form1).SetLineNumber(data.lineNumber);
            (this.Parent as Form1).SetWordNumber(data.wordNumber);
        }

    }
}
