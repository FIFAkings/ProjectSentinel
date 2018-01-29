using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjectSentinel
{
    public static class SimpleCrypto
    {

        public static byte[] Salt = Encoding.ASCII.GetBytes("p_aScMb/Tthul");

        // code copied from:
        // Dorrans, B.: Beginning ASP.NET Security

        public static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }


        // Currently unused as direct comparison of the strings in the LoginActivity seemed as a more pragmatic, albeit slightly less secure solution at the time of development.
        // For this project's purposes, high security is not a top priority.
        // We'll leave the method definition here in case we want to use it in the later development stages.
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
