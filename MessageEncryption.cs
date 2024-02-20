using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This program will hide a encrypt a message by using a random number generator to generate random values into a 22 string array
//After generating the random array it will then hide five characters of a hidden message on each line of the 22 string array.
namespace MessageEncryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] encryption = new String[22];
            StringBuilder currentline = new StringBuilder();
            String[] hiddenmessage = new String[22];
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+|]}[{:;'?/.>,<`~";     //characters to generate the random array
            string classified = "The question of whether computers can think is like the question of whether submarines can swim. - E. Dijkstra"; //message to hide
            Random rnd = new Random(1);
            Random rng = new Random(243);

            GenerateLines(encryption, currentline, characters, rnd);
            SeperateMessage(encryption, classified, hiddenmessage);
            HideMessage(encryption, rng, classified, hiddenmessage);
            Console.ReadLine();
        }


        //Using for embeded for loop statements to generate the random string array each with 60 random characters from the character array.
        static void GenerateLines(string[] encryption, StringBuilder currentline, string characters, Random rnd)
        {

            for (int e = 0; e < encryption.Length; e++) 
            {

                for (int i = 0; i < 60; i++)
                {
                    currentline.Append(characters[rnd.Next(characters.Length)]);
                }

                encryption[e] = currentline.ToString();
                currentline.Clear();
            }
        }



        //Breaking up the individual string into smaller 5 character strings using a for loop and storing them within the hiddenmessage string array.
        static void SeperateMessage(string[] encryption, string classified, string [] hiddenmessage)
        {
            int e = 0;

            for (int i = 0; i < classified.Length; i+=5)                
                {

                    hiddenmessage[e] = (classified.Substring(i, 5));
                    e++;

                }

        }



        //Hiding the message with embeded for loops and using them to modify randomly generated characters in each string with 5 of the characters from the hidden message per line.
        static void HideMessage(String[] encryption, Random rng, string classified, string[] hiddenmessage)
        {

            for (int i = 0; i < encryption.Length; i++)     //breaking down each string array into current line forms for processing line by line.
            {

                StringBuilder hideline = new StringBuilder();
                StringBuilder currentline = new StringBuilder();
                hideline.Append (hiddenmessage[i]);
                currentline.Append(encryption[i]);

                for (int e = 0; e < hideline.Length; e++)       //replacing 5 randomly selected characters in each string with a character from the hidden message.
                {
                    currentline[rng.Next(currentline.Length)] = hideline[e];
                    
                }

                encryption[i] = currentline.ToString();     //storing the newly encoded line within the encryption array.
                hideline.Clear();
                currentline.Clear();

            }

            for (int s = 0; s < encryption.Length; s++)     //writing the encypted message to the console.
            {

                Console.WriteLine(encryption[s]);

            }
        }



    }
}
    