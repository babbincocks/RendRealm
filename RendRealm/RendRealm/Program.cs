using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Text.RegularExpressions;
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
            Console.WriteLine("... ...");
            Console.ReadLine();
            Console.WriteLine("Oh! I just realized you haven't asked anything about me yet.");
            Console.ReadLine();
            if (charlocatknow.ToUpper() == "YES")
            {
                Console.WriteLine("I bet you're wondering why you can't, y'know, see me.");
            }
            else
            {
                Console.WriteLine("I bet you're wondering why you can't, y'know, see me. Frankly, I'm surprised you didn't ask sooner.");
            }
            Console.ReadLine();

            Console.WriteLine("Let me start off with introducing myself.");

            Console.ReadLine();

            Console.WriteLine("I'm Traducy.");

            Console.ReadLine();

            Console.WriteLine("I'm a Fylgja. If I'm not mistaken, you don't have those back where \nyou're from, correct?");

            Console.ReadLine();
        }



        public static void NameChar()
        {
            Console.WriteLine("Who are you? \n(Type in your desired name)");
            
            charName = Console.ReadLine();
            bool a = charName.All(char.IsLetter);

            if (charName == "")
            {
                Random rng = new Random();
                int seedy = rng.Next(15);
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine("...it's okay.");
                Console.ReadLine();
                Console.WriteLine("You're in a new environment.");
                Console.ReadLine();
                Console.WriteLine("...or, well... lack thereof.");
                Console.ReadLine();
                Console.WriteLine("Point is, I understand if you're nervous.");
                Console.ReadLine();
                Console.WriteLine("How about I just call you...");
                Console.ReadLine();
                charName = namePool(seedy);
                Console.WriteLine(charName + "?");
                Console.ReadLine();
                Console.WriteLine("Hope you like your new name, " + charName + ".");
                Console.ReadLine();
            }

            //else if (charName.Contains("!") || charName.Contains("?") || charName.Contains("!?") || charName.Contains("?!"))
            //{
            //    Console.WriteLine("Yes, let the world know of your confusion.");
            //    charName = Regex.Replace(charName, "!?", "");
            //}

            else if (charName.Contains("!"))
            {
                Console.WriteLine("Now now, there's no need to shout.");
                charName = Regex.Replace(charName, "!", "");
                Console.ReadLine();
            }

            else if (charName.EndsWith("?"))
            {
                Console.WriteLine("Hey, I asked you.");
                charName = Regex.Replace(charName, "?", "");
                Console.ReadLine();
            }

            else if (a == false && !charName.Contains("!") && !charName.Contains("?"))
            {
                Console.WriteLine("That's an odd name.");
                Console.ReadLine();
                Console.WriteLine("I like it.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ah... " + charName + ", is it?\nWell, it's good to meet you, " + charName + ".");
                Console.ReadLine();
            }
        }

        public static string namePool(int seed)
        {
            string name = "Cupcake";

            if (seed == 0)
            {
                name = "Cupcake";
            }
            else if (seed == 1)
            {
                name = "Sam";
            }
            else if (seed == 2)
            {
                name = "Cranbo";
            }
            else if (seed == 3)
            {
                name = "Trimby";
            }
            else if (seed == 4)
            {
                name = "Ziploc";
            }
            else if (seed == 5)
            {
                name = "Wawa";
            }
            else if (seed == 6)
            {
                name = "Shoobie";
            }
            else if (seed == 7)
            {
                name = "Scout";
            }
            else if (seed == 8)
            {
                name = "Dude";
            }
            else if (seed == 9)
            {
                name = "Stinky";
            }
            else if (seed == 10)
            {
                name = "Strombolius";
            }
            else if (seed == 11)
            {
                name = "Wimbly Pembleton III";
            }
            else if (seed == 12)
            {
                name = "Devon";
            }
            else if (seed == 13)
            {
                name = "Dingalinga";
            }
            else if (seed == 14)
            {
                name = "Peebub Bubber";
            }
            else if (seed == 15)
            {
                name = "Angel";
            }

            return name;
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
            Console.ReadLine();
            Console.WriteLine("If you're looking for someone to blame for most of this country's problems, it's her.");
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
