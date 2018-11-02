using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atbash_cipher
{
    class Atbash
    {
        private char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[] atbash_alpha = { 'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' };

        public string Encode(string plaintext)
        {
            string output = "";
            
            for (int i = 0; i < plaintext.Length; i++)
            {
                output += atbash_alpha[Array.IndexOf(alphabet, plaintext[i])];
            }

            return output;
        }

        public string Decode(string ciphertext)
        {
            Console.WriteLine();
            return ciphertext;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Atbash atbash = new Atbash();
            Console.WriteLine(atbash.Decode("SVOOL GSVIV UIRVMW"));
            Console.ReadKey();
        }
    }
}
