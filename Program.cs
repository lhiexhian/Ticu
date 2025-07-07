using System;

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

        static void Main(string[] args)
        {
            // Main arguments
            var micu = new Ticu("Micu", 2, 0.5, "Cat");
            Console.WriteLine(micu.PrintInfo());

        }
    }
}