using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoLyze.Library
{
    class TextEditor
    {

        public static string StringToCharCode(string text)
        {
            char[] arr = text.ToCharArray();
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!Char.IsWhiteSpace(arr[i]))
                {
                    result += Convert.ToInt32(arr[i]).ToString();
                    if (i + 1 != arr.Length)
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }


        public static string CharCodeToString(string text)
        {
            string result = string.Empty;
            List<char> lstChar = new List<char>();
            text.Split(' ').ToList().ForEach((string s) => { lstChar.Add((char)int.Parse(s)); });
            for (int i = 0; i < lstChar.Count; i += 1)
            {
                result += lstChar[i].ToString();
                if (i + 1 != lstChar.Count)
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
