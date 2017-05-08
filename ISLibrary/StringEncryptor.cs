using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ISLibrary
{
    public static class StringEncryptor
    {
        // Change the two values below to be something other than the example.
        // Once changed and in use, do not change the value below again or you
        // won't be able to decrypt previously stored passwords.
        private static string ByteArray = "l)URa0$!@%$#>#%232s+as#";
        private static byte[] InitializationVector = { 0x02, 0x33, 0x55, 0x77, 0x90, 0xAC, 0xf8, 0xCF };
        public static string EncryptWithByteArray(string stringToEncrypt)
        {
            return EncryptWithByteArray(stringToEncrypt, ByteArray);
        }
        private static string EncryptWithByteArray(string stringToEncrypt, string inByteArray)
        {
            try
            {
                byte[] tmpKey = new byte[20];
                tmpKey = System.Text.Encoding.UTF8.GetBytes(inByteArray.Substring(0, 8));
                byte[] inputArray = System.Text.Encoding.UTF8.GetBytes(stringToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(tmpKey, InitializationVector), CryptoStreamMode.Write))
                {
                    cs.Write(inputArray, 0, inputArray.Length);
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка при кодувані" + Environment.NewLine + ex.Message);
            }
        }
        public static string DecryptWithByteArray(string stringToDecrypt)
        {
            return DecryptWithByteArray(stringToDecrypt, ByteArray);
        }
        private static string DecryptWithByteArray(string stringToDecrypt, string strEncrypt)
        {
            try
            {
                byte[] tmpKey = new byte[20];
                tmpKey = System.Text.Encoding.UTF8.GetBytes(strEncrypt.Substring(0, 8));

                Byte[] inputByteArray = Convert.FromBase64String(stringToDecrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(tmpKey, InitializationVector), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    return System.Text.Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка при декодувані" + Environment.NewLine + ex.Message);
            }
        }
    }
}

