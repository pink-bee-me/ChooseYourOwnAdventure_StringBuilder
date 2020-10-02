using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo concatination and ToUpper() method on Type String
            string konCatString = "i." + "o." + "u.\n";
            Console.WriteLine(konCatString);
            Console.WriteLine(konCatString.ToUpper());

            //Using StringBuilder
            string part1 = " Choose Your Own Adventure!..well, NOT really ( you just get to press <Enter>... wah-wah!\n";

            string part2 = "As the police began to question the witness, she couldn't supress the tale-tell signs of someone that was being deceptive...\n\"What did you hear?\"\n ";

            string part3 = "The woman began to squirm in the chair as she began to explain... \" I remember I heard a commotion outside my door, so I went to see what was going on.  My door has a new dead bolt and is hard to open. When I finally got the door open....\n\"";

            string part4 = "I saw a man running down the hallway...He was yelling, \"  " + konCatString + " ! " + konCatString.ToUpper() + " !!! I'm sorry , but that's all I can remeber, officer.\"";

            StringBuilder sb = new StringBuilder(part1);
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(part2);
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(part3);
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append(part4);
            Console.WriteLine(sb);
            Console.ReadLine();
            Console.WriteLine("The End.");
            Console.ReadLine();
            Console.WriteLine("NOTE: That did NOT work How I envisioned it to work out in my mind...BUT I do understand how it DOES work... now.");
            Console.ReadLine();
            }
        }
    }
