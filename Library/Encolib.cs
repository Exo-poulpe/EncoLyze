using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoLyze.Library
{
    class Encolib
    {
        private string _textValue = string.Empty;
        
        public string TextValue { get => _textValue; set => _textValue = value; }
        public Encolib(string value)
        {
            this.TextValue = value;
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

    }
}
