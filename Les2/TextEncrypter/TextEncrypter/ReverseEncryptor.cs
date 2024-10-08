﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncrypter
{
    internal class ReverseEncryptor : IEncryptor
    {
        public string Decrypt(string toDecrypt)
        {
            return new string(toDecrypt.Reverse().ToArray());
        }

        public string Encrypt(string toEncrypt)
        {
            return Decrypt(toEncrypt);
        }
    }
}
