using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4.DZZ4
{
    public enum Grumpiness
    {
        Low,
        Medium,
        High
    }

    public struct Grandfather
    {
        public string Name;
        public Grumpiness GrumpinessLevel;
        public string[] Phrases;
        public int Bruises;

        public Grandfather(string name, Grumpiness grumpinessLevel, string[] phrases)
        {
            Name = name;
            GrumpinessLevel = grumpinessLevel;
            Phrases = phrases;
            Bruises = 0;
        }

        public int GetBruises(params string[] badWords)
        {
            foreach (string phrase in Phrases)
            {
                foreach (string word in badWords)
                {
                    if (phrase.ToLower().Contains(word.ToLower()))
                    {
                        Bruises++;
                    }
                }
            }

            return Bruises;
        }
    }
}
