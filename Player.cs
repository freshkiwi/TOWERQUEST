using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Player
    {
        public static string CharacterName = "bababooey";

        public int MaxHealth { get; set; } = 0;
        public int Health { get; set; } = 0;
        public int Damage { get; set; } = 0;
        public int Defend { get; set; } = 0;
        public int DefHeal { get; set; } = 0;
        public int Magic { get; set; } = 0;
        public bool Status { get; set; } = false;

        public static void Name() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Utility.Typewrite($"{CharacterName}");
            Console.ResetColor();
        }
        public void HP()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("HP:");
            Console.ResetColor();
        }
        public void DEF()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("DEF:");
            Console.ResetColor();
        }
        public void MANA()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("MANA:");
            Console.ResetColor();
        }

        public void KnightStats()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{CharacterName}    ");
            Console.ResetColor();
            HP();
            Console.Write($": {Health}/{MaxHealth}    ");
            DEF();
            Console.Write($": {Defend}");
        }
        public void MageStats()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{CharacterName}    ");
            Console.ResetColor();
            HP();
            Console.Write($": {Health}/{MaxHealth}    ");
            MANA();
            Console.Write($": {Magic}");
        }
        /*public string BlueName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return CharacterName;
        }*/

    }
}
