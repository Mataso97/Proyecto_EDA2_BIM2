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

        private static string Encrypt(string plainText, int shift, int[] permutation)
        {
            char[] chars = plainText.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (c >= 'a' && c <= 'z')
                {
                    c = (char)(((c - 'a' + shift) % 26) + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(((c - 'A' + shift) % 26) + 'A');
                }
                chars[i] = c;
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
                char c = chars[i];
                if (c >= 'a' && c <= 'z')
                {
                    c = (char)(((c - 'a' - shift + 26) % 26) + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(((c - 'A' - shift + 26) % 26) + 'A');
                }
                chars[i] = c;
            }
            return new string(chars);
        }

        public static string Encrypt(string plainText, string key)
        {
            int shift = key.GetHashCode() % 26;
            Random rand = new Random(key.GetHashCode());
            var y = rand.Next();
            int[] permutation = Enumerable.Range(0, plainText.Length).OrderBy(x => y).ToArray();
            MessageBox.Show(key.GetHashCode().ToString());
            return Encrypt(plainText, shift, permutation);
        }

        public static string Decrypt(string cipherText, string key)
        {
            int shift = key.GetHashCode() % 26;
            Random rand = new Random(key.GetHashCode());
            var y = rand.Next();
            int[] permutation = Enumerable.Range(0, cipherText.Length).OrderBy(x => y).ToArray();
            MessageBox.Show(key.GetHashCode().ToString());
            return Decrypt(cipherText, shift, permutation);
        }


    }
}
