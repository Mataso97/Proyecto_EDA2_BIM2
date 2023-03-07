using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EDA2_BIM2.Clases
{
    public class GedaEncryption
    {
        private const string alphabet = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789áéíóúÁÉÍÓÚ:;,.-?¿!¡\"\"''(){}[]<>|@#$%&/=+*^`~_ ";
        private static string Encrypt(string plainText, long shift, int[] permutation)
        {
            char[] chars = plainText.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int position = alphabet.IndexOf(chars[i]);
                if (position >= 0)
                {
                    int newPosition = (int)(position + shift) % alphabet.Length;
                    chars[i] = alphabet[newPosition];
                }
            }

            for (int i = 0; i < permutation.Length; i++)
            {
                int j = permutation[i];
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            return new string(chars);
        }

        private static string Decrypt(string cipherText, long shift, int[] permutation)
        {
            char[] chars = cipherText.ToCharArray();
            for (int i = permutation.Length - 1; i >= 0; i--)
            {
                int j = permutation[i];
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                long position = alphabet.IndexOf(chars[i]);
                if (position >= 0)
                {
                    int newPosition = (int)((position - shift + alphabet.Length) % alphabet.Length);
                    chars[i] = (alphabet[newPosition]);
                }
            }
            return new string(chars);
        }

        public static string Encrypt(string plainText, string key)
        {
            long shift = key.GetHashCode() % alphabet.Length;
            if (shift < 0)
            {
                shift = -shift;
            }
            Random rand = new Random(key.GetHashCode());
            int[] permutation = Enumerable.Range(0, plainText.Length).ToArray();
            permutation = Shuffle(permutation, rand);
            return Encrypt(plainText, shift, permutation);
        }

        public static string Decrypt(string cipherText, string key)
        {
            long shift = key.GetHashCode() % alphabet.Length;
            if (shift < 0)
            {
                shift = -shift;
            }
            Random rand = new Random(key.GetHashCode() % );
            int[] permutation = Enumerable.Range(0, cipherText.Length).ToArray();
            permutation = Shuffle(permutation, rand);
            return Decrypt(cipherText, shift, permutation);
        }

        public static int[] Shuffle(int[] array, Random seed)
        {
            Random random = seed;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int j = i + random.Next(n - i);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
            return array;
        }

    }
}
