using System;
using System.ComponentModel.Design;
using static System.Console;

namespace Ticu
{
    class Program
    {
        public class Ticu
        {
            private string _name;
            private int _age;
            private double _hunger;
            private string _species;

            public Ticu(string name, int age, double hunger, string species)
            {
                _name = name;
                _age = age;
                _hunger = hunger;
                _species = species;
            }

            public void Feed(double foodAmount)
            {
                // feed
            }
            public void Play()
            {
                // play
            }
            public void Sleep()
            {
                // sleep
            }
            public string PrintInfo()
            {
                return $"Name: {_name}, Age: {_age}, Hunger: {_hunger}, Species: {_species}";
            }
        }

        static void StartUp()
        {
            string title = "╔═══════════════════════════════════════════════════╗\n" +
                           "║                                                   ║\n" +
                           "║  █████   ███   ▄███▄   █   █   VIRTUAL            ║\n" +
                           "║   ▀█▀     █    █   █   █   █   PET                ║\n" +
                           "║    █      █    █       █   █   SIMULATOR          ║\n" +
                           "║    █      █    █▄ ▄█   █▄ ▄█  ┌───────────┐       ║\n" +
                           "║    █     ███   ▀███▀   ▀███▀  │ LhieXhian │       ║\n" +
                           "║                               ╘═══════════╛       ║\n" +
                           "╚═══════════════════════════════════════════════════╝\n";
            WriteLine(title);
        }

        static void Menu()
        {
            CursorVisible = false;
            bool pos = true;
            WriteLine("> START");
            WriteLine("  EXIT");
            SetCursorPosition(0, 15);
            WriteLine("Use the UP and DOWN keys to navigate and ENTER to select.");
            while (true)
            {
                var key = ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    pos = true;
                    SetCursorPosition(0, 10);
                    WriteLine(">");
                    SetCursorPosition(0, 11);
                    WriteLine(" ");
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    pos = false;
                    SetCursorPosition(0, 10);
                    WriteLine(" ");
                    SetCursorPosition(0, 11);
                    WriteLine(">");
                }

                if (key == ConsoleKey.Enter)
                {
                    if (pos)
                    {
                        // Start the game
                        SetCursorPosition(0, 16);
                        WriteLine("Starting...");
                        // Here you can initialize your game logic
                        return;
                    }
                    else
                    {
                        // Exit the application
                        SetCursorPosition(0, 16);
                        WriteLine("Exiting the application...");
                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            StartUp();
            Menu();
            // Main arguments
        }
    }
}