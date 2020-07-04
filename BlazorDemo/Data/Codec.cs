using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data
{
    public class Codec
    {
        // Encodes a list of strings to a single string.
        public String encode(String text)
        {
            byte[] byteConverted = System.Text.Encoding.UTF8.GetBytes(text);
            string strEncoded = Convert.ToBase64String(byteConverted);
            return strEncoded;
        }

        // Decodes a single string to a list of strings.
        public String decode(String text)
        {
            byte[] byteConverted = Convert.FromBase64String(text);
            string strDecoded = System.Text.Encoding.UTF8.GetString(byteConverted);
            return strDecoded;
        }
    }
}