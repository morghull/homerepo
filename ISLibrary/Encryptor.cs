using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ISLibrary
{
    class Encryptor
    {
        private byte[] entr;
        public Encryptor()
        {

        }
        public string Encrypt(string str)
        {
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
            byte[] plaintext = Encoding.Default.GetBytes(str);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            entr = entropy;
            byte[] ciphertext = ProtectedData.Protect(plaintext, entropy, DataProtectionScope.CurrentUser);
            return Encoding.Default.GetString(ciphertext);
        }
        public string Decrypt(string ciphertext)
        {
            byte[] plaintext = ProtectedData.Unprotect(Encoding.Default.GetBytes(ciphertext), entr, DataProtectionScope.CurrentUser);
            return Encoding.Default.GetString(plaintext);
        }
    }
}
