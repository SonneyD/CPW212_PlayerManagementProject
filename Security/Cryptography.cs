using System;
using System.Security.Cryptography;
using System.IO;

namespace PlayerDatabaseModule.Security
{
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

        public static void GeneratedSaltedHash(string password, out string hash, out string salt)
        {
            var saltBytes = new byte[64];
            var pro = new RNGCryptoServiceProvider();
            pro.GetNonZeroBytes(saltBytes);
            salt = Convert.ToBase64String(saltBytes);

            var rfc = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            hash = Convert.ToBase64String(rfc.GetBytes(256));
        }

        public static bool VerifyPassword(string password, string hash, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var rfc = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            return Convert.ToBase64String(rfc.GetBytes(256)) == hash;

        }

        public static void TestFN()
        {
            string password = "tester123";
            string hash; string salt;

            GeneratedSaltedHash(password, out hash, out salt); // I'm so sad, I assumed objects were passed by reference... then I learned about the out keyword
            Console.WriteLine("Password(before hash): " + password);
            Console.WriteLine("Password(after hash): " + hash + "\n");

            Console.WriteLine("Result of password comparision: " + VerifyPassword(password, hash, salt).ToString());


        }

        /****************************************************/
        public static string EncryptString( string txt, string password )
        {
            return "";
        }
    }
}
