using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace RendRealm
{

    class Program
    {
        static void Main(string[] args)
        {
            Game.StartGame();
            Console.ReadKey();

        }

    }
    public static class Game
    {
        public static string charName = "???";
        public static string charlocatknow = "no";



        public static void StartGame()
        {
            Console.WriteLine("Hello...");
            Console.WriteLine("(Press any key...)");

            Console.ReadKey();

            NameChar();

            Console.WriteLine("Ah... " + charName + ", is it?\nWell, it's good to meet you, " + charName + ".");
            Console.ReadLine();
            Console.WriteLine("Pardon me asking, " + charName + ", but do you know where you are?\n(YES / NO)");
            charlocatknow = Console.ReadLine();

                bool dec = false;
                while (dec == false)
                {
                    if (charlocatknow.ToUpper() == "NO")
                    {
                        Startlocatdetail();
                        dec = true;
                    }
                    else if (charlocatknow.ToUpper() == "YES")
                    {
                        Console.WriteLine("Alright, that's good.");
                        dec = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, what was that?");
                        Console.ReadLine();
                        Console.WriteLine("I'm just going to assume you said... no.");
                        Console.ReadLine();
                        Startlocatdetail();
                        dec = true;
                    }

                }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("Oh! I just realized you haven't asked anything about me yet.");
            if (charlocatknow == "YES")
            {
                Console.WriteLine("I bet you're wondering why you can't, y'know, see me.");
            }
            else
            {
                Console.WriteLine("I bet you're wondering why you can't, y'know, see me. Frankly, I'm surprised you didn't ask sooner.");
            }
            Console.ReadLine();
        }



        public static void NameChar()
        {
            Console.WriteLine("Who are you? \n(Type in your desired name)");

            charName = Console.ReadLine();
        }



        public static void Startlocatdetail()
        {
            Console.WriteLine("Right... okay, let me get you up to speed.");
            Console.ReadLine();
            Console.WriteLine("You're in Rendinia, a tiny country on the coast of the vast Ytterber Sea. \nHmmm... let's see, " +
                "what else...");
            Console.ReadLine();
            Console.WriteLine("I guess there's the weather? Rendinia's climate can be quite harsh, with\ntemperatures sometimes " +
                "sinking down to paralyzing temperatures.");
            Console.ReadLine();
            Console.WriteLine("Then there's our economy. It hasn't been doing... fantastic, exactly, since our primary export, ren orbs," +
                "have slowly fallen out of fashion...");
            Console.ReadLine();
            Console.WriteLine("Oh, and then there's our queen: Queen Esthafiria Moransius Trindelio IV.\n'Course, us 'ahem' " +
                "dissenters just call her the Ice Queen.");
        }

        
    }

    public static class CharStats
    {
        public static int Strength()
        {
            int strengthCheck = 5;
            return strengthCheck;
        }
    }
}
