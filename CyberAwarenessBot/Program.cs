using System;
using System.Media;

namespace CyberAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayVoiceGreeting();
            DisplayASCIIBanner();
            UserGreeting();

            Console.WriteLine("Ask me anything you want to know. Type 'exit' to close the app.");

            while (true)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                ResponseSystem(userInput);
            }
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }

        static void DisplayASCIIBanner()
        {
            string logo = @"
 ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓████████▓▒░▒▓███████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░▒▓████████▓▒░ 
░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
░▒▓█▓▒░       ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓██████▓▒░ ░▒▓███████▓▒░░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░     
 ░▒▓██████▓▒░   ░▒▓█▓▒░   ░▒▓███████▓▒░░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░  ░▒▓█▓▒░     
                                                                                                         
                                                                                                         ";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(logo);
            Console.ResetColor();

        }

        static void UserGreeting()
        {
            Console.WriteLine("\nPlease Enter Your Name: ");
            string username = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nHello {username}! Welcome to the Cybersecurity Awareness Chatbot.");
            Console.ResetColor();
        }

        static void ResponseSystem(string input)
        {
            switch (input)
            {
                case "how are you?":
                    Console.WriteLine("I’m doing great, thanks for asking! Are you ready to talk about cybersecurity.");
                    break;

                case "what's your purpose?":
                case "what is your purpose?":
                    Console.WriteLine("My purpose is to help you stay safe online by sharing cybersecurity tips.");
                    break;

                case "what can i ask you about?":
                    Console.WriteLine("You can ask me about: \npassword safety\nphishing\nsafe browsing habits you should adapt.");
                    break;

                case "password safety":
                    Console.WriteLine("Tip: Use long, unique passwords and enable two-factor authentication.");
                    break;

                case "phishing":
                    Console.WriteLine("Tip: Be cautious of emails or messages asking for personal info. Check the sender carefully.");
                    break;

                case "safe browsing":
                    Console.WriteLine("Tip: Always keep your browser updated and avoid clicking suspicious links.");
                    break;

                default:
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                    break;
            }

        }
    }
}