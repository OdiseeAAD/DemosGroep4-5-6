﻿namespace TextEncrypter
{
    internal class ShiftOneEncryptor : IEncryptor
    {
        public string Decrypt(string toDecrypt)
        {
            string encrypted = "";
            foreach (char c in toDecrypt)
            {
                if (c == 'z')
                {
                    encrypted += 'a';
                }
                else if (c == 'Z')
                {
                    encrypted += 'A';
                }
                else
                {

                    encrypted += (char)(c + 1);
                }
            }

            return encrypted;
        }

        public string Encrypt(string toEncrypt)
        {
            string decrypted = "";
            foreach (char c in toEncrypt)
            {
                if (c == 'a')
                {
                    decrypted += 'z';
                }
                else if (c == 'A')
                {
                    decrypted += 'Z';
                }
                else
                {

                    decrypted += c - 1;
                }
            }
            return decrypted;
        }
    }
}
