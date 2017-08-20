using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher {
    class Program {

        private static char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        static int shift; //the shift amount for the message

        static void Main(string[] args) {

            string message; //the message entered by the user
            
            //the user entered message
            Console.WriteLine("Please enter the message that you'd like to encrypt:");
            message = Console.ReadLine();

            Console.WriteLine();

            //the shift value
            Console.WriteLine("Please enter the amount that you'd like the message to shift by: ");
            shift = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();

            string encrypted = ""; //encrypted version of the message
            string decrypted = ""; //decrypted version of the message

            encrypted = Encrypt(shift, message).ToString();

            Console.WriteLine("The encrypted version of your message is: ");
            Console.WriteLine(encrypted);

        }
        
        //encrypts the message; shift is the amount of letters that the characters shift by, and message is the message that the user inputs
        public static StringBuilder Encrypt(int shift, string message) {

            StringBuilder encryption = new StringBuilder(); //the encrypted message
            char[] messageArray = message.ToCharArray(); //the message with each character in its own array element
            char shiftedLetter = ' '; //the shifted letter

            for (int i = 0; i < messageArray.Length; i++) {

                for (int a = 0; a < alphabet.Length; a++) {

                    if (messageArray[i].Equals(alphabet[a])) {

                        //takes the letter in the alphabet array which is equal to the current letter in the message array
                        //it adds the shift value to the index value of the alphabet array's current index value and then performs 
                        //mod 26 on it to ensure that it's always in the alphabet and there's no array out of bounds error
                        shiftedLetter = alphabet[(a + shift) % 26];
                        encryption.Append(shiftedLetter);

                    }
                }
            } 

            return encryption;
        }
        public static StringBuilder Decrypt(int shift, string message) {

        }
    }
}
