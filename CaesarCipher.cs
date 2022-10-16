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

/*

Caesar Cipher
By 6 a.m. on Sunday, your team’s project is nearly finished. The Object of Your Affection (the name’s a work in progress) is getting attention from other teams in the hackathon. With one day left, they’re getting desperate. To steal your project idea, your competitors have been reading your team’s emails!

As the team’s C# expert, you have been asked to write a cipher: a tool to encrypt text, making it unreadable to other teams. You’ve decided to implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.

To use the cipher, draw the alphabet in a circle like so:

Alphabet with letters arranged in a circle
Take every letter of your message and shift it three places to the right. For example, A becomes D, B becomes E, C becomes F, and “attack” becomes “dwwdfn”.

Shift 3 places to turn A to D
Your teammates can decrypt your message by reversing the process: shift each letter three places to the left.

For this project you’ll need to convert strings to arrays of characters with ToCharArray():

string msgString = "brutus";
char[] msgArray = msgString.ToCharArray();
You’ll also need to convert arrays of characters to strings with Join():

char[] msgArray = new char[] {'b', 'r', 'u', 't', 'u', 's'};
string msgString = String.Join("", msgArray);
The team is counting on you. Let’s get started!

Tasks
5/14 Complete
Mark the tasks as complete by checking them off
Prepare for Encryption
1.
You’ll build the encryption tool as an interactive console app.

First, ask the user for a secret message and store the result in a variable.


Stuck? Get a hint
2.
Convert the captured string to an array of characters. Store the result in a new variable called secretMessage.


Stuck? Get a hint
3.
Create a new, empty array of characters to hold the encrypted message. It should be named encryptedMessage and have a length equal to the length of secretMessage.


Stuck? Get a hint
Encrypt
4.
We’ll need to perform encryption for every letter in the message.

Create an empty for loop that loops through each character of secretMessage.

The iterator variable should be called i and start at 0
It should continue as long as it is less than secretMessage.Length
Each iteration it should increment by 1

Stuck? Get a hint
5.
Within the loop, access the character at position i in the secretMessage array and store it in a variable.


Stuck? Get a hint
6.
Find the position of the character in the alphabet array using the method Array.IndexOf(). Store the value in a variable.


Stuck? Get a hint
7.
Add 3 to the letter position and store the value in a variable.


Stuck? Get a hint
8.
Find the new encrypted character by getting the character in the alphabet array with that new position.


Stuck? Get a hint
9.
Add the encrypted character to the array encryptedMessage.

Store the character at the index i (the iterator variable).


Stuck? Get a hint
Test and Improve
10.
Your loop is finished! Now we need to convert our array of encrypted characters back into a readable string that we can print to the console.

Convert the character array to a string using String.Join() and print it to the console.


Stuck? Get a hint
11.
Run your app and try these messages (not all of them may work yet!):

hello converts to khoor
citizen converts to flwlchq

Stuck? Get a hint
12.
What went wrong? When the program tried to encrypt the z in citizen, it found its index in the alphabet, 25. It looked up the letter 3 spaces to the right, which would be alphabet[28].

This threw an error because the alphabet is only 26 letters!

We can “wrap around” by using the modulo operator: %. On the line where you add 3 to the letter position, surround the expression letterPosition + 3 with parentheses and take the modulo of 26.

Now the new letter position will never go past 26.


Stuck? Get a hint
13.
Test the code again with citizen, which converts to flwlchq.


Stuck? Get a hint
Extensions
14.
Well done! You built an automated encryption engine that your team can use to communicate in secrecy. The hackathon is all but won!

If you’d like, you can keep building on your app:

The app doesn’t work with uppercase letters. Fix that by converting any message to lowercase.
The app doesn’t work with symbols, like ! or ?. Skip any symbols in your loop so that they are not encrypted.
Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array .
Write a Decrypt() method which takes a character array and key and returns a decrypted character array.
char[] secretMessage = {'h', 'e', 'l', 'l', 'o'};
 
// encrypted should equal  {'k', 'h', 'o', 'o', 'r'}
string encrypted = Encrypt(secretMessage, 3);
 
// decrypted should equal {'h', 'e', 'l', 'l', 'o'}
string decrypted = Decrypt(encrypted, 3);

*/