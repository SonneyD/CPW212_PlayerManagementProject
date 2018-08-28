using System;
using System.Security.Cryptography;
using System.IO;

namespace PlayerDatabaseModule.Security
{
    // I'm re-using my code from my FileIO assignment. Source: https://ourcodeworld.com/articles/read/471/how-to-encrypt-and-decrypt-files-using-the-aes-encryption-algorithm-in-c-sharp
    public static class Cryptography
    {
        public static byte[] GenerateRandomSalt(int saltSize)
        {
            if (saltSize <= 0)
                throw new ArgumentException("size of salt must be > 0 | Security->Cryptography->GenerateRandomSalt()");

            RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();

            byte[] data = new byte[saltSize];
            saltGenerator.GetBytes(data);

            return data;
        }



        /****************************************************/
        public static string EncryptString( string txt, string password )
        {
            return "";
        }
    }
}
