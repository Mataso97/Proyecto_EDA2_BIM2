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
        private static string Encrypt(string plainText, int shift, int[] permutation)
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

        private static string Decrypt(string cipherText, int shift, int[] permutation)
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
                int position = alphabet.IndexOf(chars[i]);
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
            int shift = key.GetHashCode() % alphabet.Length;
            if (shift < 0) 
            {
                shift = -shift;
            }
            Random rand = new Random(key.GetHashCode());
            int[] permutation = Enumerable.Range(0, plainText.Length).OrderBy(x => rand.Next()).ToArray();
            return Encrypt(plainText, shift, permutation);
        }

        public static string Decrypt(string cipherText, string key)
        {
            int shift = key.GetHashCode() % alphabet.Length;
            if (shift < 0)
            {
                shift = -shift;
            }
            Random rand = new Random(key.GetHashCode());
            int[] permutation = Enumerable.Range(0, cipherText.Length).OrderBy(x => rand.Next()).ToArray();
            return Decrypt(cipherText, shift, permutation);
        }
    }
}
