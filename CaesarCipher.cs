using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Ask user
            Console.WriteLine("Enter a secret message");
            string secret = Console.ReadLine();

            // Convert user input to string of characters
            char[] secretMessage = secret.ToCharArray();

            // Empty array
            char[] encryptedMessage = new char[secretMessage.Length];

            // For loop
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMesage[i];
            }

        }
    }
}