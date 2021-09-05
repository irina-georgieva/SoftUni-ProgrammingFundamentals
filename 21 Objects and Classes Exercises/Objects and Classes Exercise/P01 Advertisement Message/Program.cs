﻿using System;
using System.Collections.Generic;

namespace P01_Advertisement_Message
{
    class RandomGenerator
    {
        public RandomGenerator(List<string> phrases)
        {
            Phrases = phrases;
        }

        public List<string> Phrases { get; set; }

        public string GetRandomPhrase()
        {
            Random random = new Random();
            return Phrases[random.Next(Phrases.Count)];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator phrases = new RandomGenerator(new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." });

            RandomGenerator events = new RandomGenerator(new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });
            
            RandomGenerator authors = new RandomGenerator(new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });
            
            RandomGenerator cities = new RandomGenerator(new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });

            Console.WriteLine($"{phrases.GetRandomPhrase()} {events.GetRandomPhrase()} {authors.GetRandomPhrase()} – {cities.GetRandomPhrase()}");
        }
    }
}
