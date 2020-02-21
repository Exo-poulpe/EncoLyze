using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoLyze.Structs
{
    struct Value
    {
        public string text;
        public long length;
        public long numberNum;
        public long lineNumber;
        public long wordNumber;

        public Value(string _text, long _length = 0, long _numberNum = 0, long _lineNumber = 0, long _wordNumber = 0)
        {
            text = _text;
            length = _length;
            numberNum = _numberNum;
            lineNumber = _lineNumber;
            wordNumber = _wordNumber;
        }
    }
}
