using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace GSN
{
    public class LegacyCryptoKey
    {
        private byte[] key = new byte[8];
        private byte[] iv = new byte[8];
        public byte[] Key
        {
            get { return key; }
            set { key = value; }
        }

        public byte[] IV
        {
            get { return iv; }
            set { iv = value; }
        }
        public void BuildKey(string newkey)
        {
            int start = 0;
            ASCIIEncoding asciiencoding = new ASCIIEncoding();
            //Convert the first 8 to chars to bytes and the last 
            //8 chars to bytes ignore the middle
            asciiencoding.GetBytes(newkey, start, key.Length, key, 0);
            start = newkey.Length - iv.Length;
            asciiencoding.GetBytes(newkey, start, iv.Length, iv, 0);
        }
    }
}
