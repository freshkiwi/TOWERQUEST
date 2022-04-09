using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    public class Goon
    {
        public string Name { get; set; } = "Goon";
        public int GoonMaxHP { get; set; }
        public int GoonHealth { get; set; } = 0;
        public int GoonAttack1 { get; set; } = 0;
        public int GoonAttack2 { get; set; } = 0;
        public int GoonAttack3 { get; set; } = 0;
        public int GoonSpecial { get; set; } = 0;
        public bool Status { get; set; } = false;

        public void HP()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("HP:");
            Console.ResetColor();
        }
        public void GoonDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{Name}    ");
            Console.ResetColor();
            HP();
            Console.Write($": {GoonHealth}/{GoonMaxHP}");
        }
        /*public string GoonName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return Name;
        }*/
    }
}
