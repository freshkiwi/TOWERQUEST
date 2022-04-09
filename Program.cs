/*
 * Tower Quest
 * by Keanu M, 2/2/2022
 * 
 * This work is a derivative of
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 * 
 * Music by various franchises owned by Nintendo
 */
using System;
using System.IO;
using System.Media;

namespace AdventureGame
{
    class GameStart
    {
        public string input;
        static int choice;
        
        
        public static void PlayerMenu()
        {
            string Title = @"
=============================================================================
                 _____  _           __     ________ _____  
                |  __ \| |        /\\ \   / /  ____|  __ \ 
                | |__) | |       /  \\ \_/ /| |__  | |__) |
                |  ___/| |      / /\ \\   / |  __| |  _  / 
                | |    | |____ / ____ \| |  | |____| | \ \ 
                |_|    |______/_/    \_\_|  |______|_|  \_\

=============================================================================";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.ResetColor();
        }
        public void Title()
        {

            string title = @"
 _______ ______          ________ _____     ____  _    _ ______  _____ _______ 
|__   __/ __ \ \        / /  ____|  __ \   / __ \| |  | |  ____|/ ____|__   __|
   | | | |  | \ \  /\  / /| |__  | |__) | | |  | | |  | | |__  | (___    | |   
   | | | |  | |\ \/  \/ / |  __| |  _  /  | |  | | |  | |  __|  \___ \   | |   
   | | | |__| | \  /\  /  | |____| | \ \  | |__| | |__| | |____ ____) |  | |   
   |_|  \____/   \/  \/   |______|_|  \_\  \___\_\\____/|______|_____/   |_| ";
            string image = @"
                                                      @@@@@@@@@@@@@@@@@@@@@@
                                                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                                  @@@@@@@@@@@@@@@@       @@@@@
                                                        │      │    ###    │
                                                    ┌───┤   ┌──┘   #####  ┌┴─
                                                  ┌─┘   └┐  │      ###### │
                                                  │      │  │     #######
                                                          ┌─┘    ### #####
                                                          │      ### #####
                                                      ┌───┤      #########
                                                   ┌──┘   │      ###### ##
                                                   │      └┐     ###### ###
                                                   │       │    ###########
                                                               #### #######
                                                               #### #######
                                                              ##############
                                                              ##############
______________________________________________________________##############";

            SoundPlayer Opening = new SoundPlayer("Title Link to the Past.wav");
            Opening.Load();
            Opening.Play();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            Console.ResetColor();
            Utility.TypewriteFast(image);


            Console.Write(@"
========================== ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Utility.Typewrite("Press Enter to continue.");
            Console.ResetColor();
            Console.Write("==========================");
            Console.ReadKey();
            Opening.Stop();
            Console.Clear();
        }
        public void NameCharacter()
        {
            SoundPlayer Creation = new SoundPlayer("Beginning of the Journey.wav");
            Creation.Load();
            Creation.Play();
            PlayerMenu();

            Utility.Typewrite(@"
Welcome player to TOWER QUEST! Before we begin your grand adventure into the
the world of TOWER QUEST, we must create YOU!
Pray tell... what is your name traveler?
");
            Player.CharacterName = Console.ReadLine();

            Utility.Typewrite("The soon to be hero of legend: ");
            Player.Name();
            Utility.Typewrite(@"! A name truly fit for a hero!
Now that we have the name of the hero, you must decide on what kind of hero
you shall be!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public void ClassesIntro()
        {
            PlayerMenu();

            Player.Name();
            Utility.Typewrite(@", your journey is decided on two paths...
One is the path of the ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Utility.Typewrite("KNIGHT");
            Console.ResetColor();

            Utility.Typewrite(" and the other is the path of the ");

            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite("MAGE");
            Console.ResetColor();

            Utility.Typewrite(@".
These two paths determine how you handle the ");

            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("OVERLORD");
            Console.ResetColor();

            Utility.Typewrite(" and his ");

            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("GOONS");
            Console.ResetColor();
            Console.WriteLine(".");

            ClassDescription();
        }
        public void ClassDescription()
        {

            Utility.Typewrite(@"
Would you like to learn more about the classes?
1) Yes    2) No
");
            input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {

                if (choice >= 3)
                {
                    Utility.Typewrite("Not an option. Please select one of the numbers listed.");
                    Console.ReadKey();
                    Console.Clear();
                    PlayerMenu();
                    ClassDescription();
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            Utility.TypewriteFast("CLASS: ");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Utility.TypewriteFast("KNIGHT");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Red;
                            Utility.TypewriteFast("\nHEALTH: ");
                            Console.ResetColor();

                            Utility.TypewriteFast("150");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Utility.TypewriteFast(@"
Description: Attack with a SWORD and defend with a SHIELD. The KNIGHT class 
can restore its health with ITEMS and SHIELDING. KNIGHTS have a limited
amount of ITEMS, and SHIELDING success decreases in use.");
                            Console.ResetColor();

                            Utility.TypewriteFast("\n\nCLASS: ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Utility.TypewriteFast("MAGE");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Red;
                            Utility.TypewriteFast("\nHEALTH: ");
                            Console.ResetColor();

                            Utility.TypewriteFast("100");

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Utility.TypewriteFast("\nMANA: ");
                            Console.ResetColor();

                            Utility.TypewriteFast("100");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Utility.TypewriteFast(@"
Description: The MAGE class relies on MAGIC. Use MANA to HEAL and use SPELLS.
The MAGE cannot DEFEND or use ITEMS. Use CONCENTRATE to restore MANA.");
                            Console.ResetColor();

                            Utility.Typewrite(@"

Press ENTER to continue.");

                            Console.ReadKey();
                            Console.Clear();
                            PlayerMenu();
                            ClassDescription();
                            break;

                        case 2:
                            Console.Clear();
                            ClassChoice();
                            break;
                    }
                }
            }
            else
            {
                Utility.Typewrite("Not an option. Please select one of the numbers listed.");
                Console.ReadKey();
                Console.Clear();
                PlayerMenu();
                ClassDescription();
            }
        }
        public void ClassChoice()
        {

            PlayerMenu();
            Utility.Typewrite("Which class will you choose?\n1) ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Utility.Typewrite("KNIGHT");
            Console.ResetColor();

            Utility.Typewrite("   2) ");

            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite("MAGE\n");
            Console.ResetColor();

            input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {

                if (choice >= 3)
                {
                    Utility.Typewrite("Not an option. Please select one of the numbers listed.");
                    Console.ReadKey();
                    Console.Clear();
                    ClassChoice();
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            KnightGame knightGame = new KnightGame();
                            Utility.Typewrite("You have selected the ");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Utility.Typewrite("KNIGHT");
                            Console.ResetColor();

                            Utility.Typewrite(" class! The world of ");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Utility.Typewrite("TOWER QUEST");
                            Console.ResetColor();

                            Utility.Typewrite(" awaits you! ");
                            Utility.Typewrite(@"

Press ENTER to begin your journey!");
                            Console.ReadKey();
                            Console.Clear();
                            knightGame.Beginning();
                            break;

                        case 2:
                            MageGame mageGame = new MageGame();
                            Utility.Typewrite("You have selected the ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Utility.Typewrite("MAGE");
                            Console.ResetColor();

                            Utility.Typewrite(" class! The world of ");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Utility.Typewrite("TOWER QUEST");
                            Console.ResetColor();

                            Utility.Typewrite(" awaits you! ");
                            Utility.Typewrite(@"

Press ENTER to begin your journey!");
                            Console.ReadKey();
                            Console.Clear();
                            
                            mageGame.Part1();
                            break;
                    }
                }
            }
            else
            {
                Utility.Typewrite("Not an option. Please select one of the numbers listed.");
                Console.ReadKey();
                Console.Clear();
                ClassChoice();
            }
        }
    }
    class KnightGame
    {
        public string input;
        static int choice;
        public string Title { get; set; }
        public static void Divider()
        {
            Console.WriteLine(@"
============================================================================");
        }
        public void Beginning()
        {
            Console.WindowHeight = 35;
            SoundPlayer Legend = new SoundPlayer("The Legend.wav");
            Legend.Play();
            string image = @"
                                                      @@@@@@@@@@@@@@@@@@@@@@
                                                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                                  @@@@@@@@@@@@@@@@       @@@@@
                                                        │      │    ###    │
                                                    ┌───┤   ┌──┘   #####  ┌┴─
                                                  ┌─┘   └┐  │      ###### │
                                                  │      │  │     #######
                                                          ┌─┘    ### #####
                                                          │      ### #####
                                                      ┌───┤      #########
                                                   ┌──┘   │      ###### ##
                                                   │      └┐     ###### ###
                                                   │       │    ###########
                                                               #### #######
                                                               #### #######
                                                              ##############
                                                              ##############
______________________________________________________________##############";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(image);
            Console.ResetColor();
            Divider();
            Utility.Typewrite("In a land far far way,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" a long long time ago,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" a traveler, ");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("by the name of\n");
            Player.Name();
            Utility.Typewrite(",");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" wandered the lands in hope to aid those in need.\n");
            System.Threading.Thread.Sleep(5000);
            Utility.Typewrite("Upon their travel,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" they come across a village in ruin.");
            System.Threading.Thread.Sleep(3000);
            Utility.Typewrite(" Concerned,\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" asks the remaining survivors what happened to their village.\n");
            System.Threading.Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("\"");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("The Overlord...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("\"");
            System.Threading.Thread.Sleep(2000);
            Console.ResetColor();
            Utility.Typewrite(" they said, ");
            System.Threading.Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("\"");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("The Overlord...");
            System.Threading.Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(" they sent their ");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("GOONS ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("to destroy\n our village and raid us of our resources.\"\n");
            System.Threading.Thread.Sleep(4000);
            Console.ResetColor();
            Player.Name();
            Utility.Typewrite(" asks the villagers where ");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("The Overlord");
            Console.ResetColor();
            Utility.Typewrite(" was hiding.\n");
            System.Threading.Thread.Sleep(3000);
            Utility.Typewrite("The villagers responded with a point,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" a point in the direction of enourmous\ntower, surrounded by dark ominous clouds.\n");
            System.Threading.Thread.Sleep(4000);
            Player.Name();
            Utility.Typewrite(",");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" with determination in their eyes,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" sets forth to climb the tower to\ndefeat ");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("The Overlord");
            Console.ResetColor();
            Utility.Typewrite(" and free the land once and for all.");
            System.Threading.Thread.Sleep(8000);
            Console.Clear();
            KnightStart();
        }
        public void KnightStart()
        {
            Console.WindowHeight = 30;
            int Save = 0;

            Player knight = new Player
            {
                MaxHealth = 150,
                Health = 150,
                Damage = 10,
                Defend = 3,
                DefHeal = 10,
                Status = false
            };

            Item potion = new Item
            {
                Value = 20,
                Name = "Healing Potion",
                Inventory = 5,
                Description = $"A Potion. Heals 20 HP."
            };

            Item bigpotion = new Item
            {
                Value = 60,
                Name = "Big Potion",
                Inventory = 3,
                Description = $"A Stronger Potion. Heals 60 HP."
            };

            Item megapotion = new Item
            {
                Name = "Mega Potion",
                Description = "An even stronger potion. Heals 120 HP",
                Value = 120,
                Inventory = 3
            };

            Item potionMax = new Item
            {
                Name = "Max Potion",
                Description = "A potion that fully restores HP",
                Inventory = 3,
            };

            Item holywater = new Item
            {
                Value = 40,
                Name = "Blessed Water",
                Inventory = 2,
                Description = $"Blessed water. Does 40 damage to enemies."
            };

            Item dagger = new Item
            {
                Name = "Throwing Knife",
                Value = 25,
                Inventory = 5,
                Description = "A throwing knife. Does 25 damage."
            };

            Item axe = new Item
            {
                Name = "Hand Axe",
                Description = "A throwable hand axe. Does 80 damage.",
                Value = 80,
                Inventory = 2,
            };

            Item bomb = new Item
            {
                Name = "Bomb Ball",
                Description = "A ball shaped Bomb. Does 150 Damage",
                Value = 150,
                Inventory = 2,
            };

            Part1(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void GameOver(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            string GameOver = @"           
          _____          __  __ ______    ______      ________ _____  
         / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
        | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
        | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
        | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
         \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\";

            SoundPlayer Failure = new SoundPlayer("Failure.wav");
            Failure.Play();
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.TypewriteFast(GameOver);
            Console.ResetColor();
            Console.Write(@"
========================== ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //                       Continue?         
            Utility.Typewrite("      Continue?         ");
            Console.ResetColor();
            //                                              here
            Console.Write("==========================");
            Utility.Typewrite("\n                           1) Yes           2)No\n");

            input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                   if (Save == 0)
                    {
                        Console.Clear();
                        KnightStart();
                    }
                   else if (Save == 1)
                    {
                        Console.Clear();
                        KnightCheckpoint(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                    }
                   else if (Save == 2)
                    {
                        Console.Clear();
                        KnightFinalCheckpoint(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);

                    }
                }
                else
                {
                    Utility.Typewrite($"Thank you for playing ");
                    Player.Name();
                    Utility.Typewrite($"!");
                    System.Threading.Thread.Sleep(4000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Utility.Typewrite($"Thank you for playing ");
                Player.Name();
                Utility.Typewrite($"!");
                System.Threading.Thread.Sleep(4000);
                Environment.Exit(0);
            }

        }
        public void Part1(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            Goon goblin = new Goon
            {
                Name = "Crazy Goblin",
                GoonMaxHP = 100,
                GoonHealth = 100,
                GoonAttack1 = 10,
                GoonSpecial = 20
            };

            Titles.LevelOneTitle();
            SoundPlayer Battle1 = new SoundPlayer("Strike Attack.wav");
            Battle1.Load();
            Battle1.PlayLooping();
//goblin fight
            while (goblin.GoonHealth > 0)
            {
                if(knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend += 3;
                }
                Divider();
                goblin.GoonDisplay();
                Divider();
                knight.KnightStats();
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {goblin.Name}! attacks!", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
//attack
                        if (RNG > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            goblin.GoonHealth -= knight.Damage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                            Console.ResetColor();
                            goblin.GoonHealth -= (knight.Damage*2);
                        }
                        //Console.WriteLine($"{RNG}, {RNG2}, {RNG3}");
                        System.Threading.Thread.Sleep(2000);
                        if (goblin.GoonHealth > 0)
                        {
                            if (RNG2 >= 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {goblin.Name} attacks!");
                                Console.ResetColor();
                                knight.Health -= goblin.GoonAttack1;
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                                Console.ResetColor();
                                knight.Health -= goblin.GoonSpecial;
                                System.Threading.Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {goblin.Name} collapsed!");
                            Console.ResetColor();

                        }
                        
                        Console.Clear();
                        break;

                    case 1:
//defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                            }
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {goblin.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {goblin.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {goblin.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"The {goblin.Name} attacks!");
                                    knight.Health -= goblin.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                                    knight.Health -= goblin.GoonSpecial;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                Console.ResetColor();
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {goblin.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {goblin.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"The {goblin.Name} attacks!");
                                    knight.Health -= goblin.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                                    knight.Health -= goblin.GoonSpecial;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                Console.ResetColor();
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
//items                        
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{dagger.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length +1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
//potion
                            case 0:
                                string[] YesNo = new string[] {"Yes"};
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {goblin.Name} caught you off guard!");
                                                    knight.Health -= goblin.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {goblin.Name} is mocking {Player.CharacterName}!");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
//mega potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {goblin.Name} caught you off guard!");
                                                    knight.Health -= goblin.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {goblin.Name} is mocking {Player.CharacterName}!");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 2:
//dagger
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                           Console.ForegroundColor = ConsoleColor.Cyan;
                                           Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                           Console.ResetColor();
                                           System.Threading.Thread.Sleep(2000);
                                           goblin.GoonHealth -= dagger.Value;
                                           dagger.Inventory--;

                                            if (goblin.GoonHealth > 0)
                                            {
                                                if (RNG2 >= 3)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {goblin.Name} attacks!");
                                                    Console.ResetColor();
                                                    knight.Health -= goblin.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                                                    Console.ResetColor();
                                                    knight.Health -= goblin.GoonSpecial;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"The {goblin.Name} collapsed!");
                                                Console.ResetColor();

                                            }
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            Battle1.Stop();

            SoundPlayer Win = new SoundPlayer("Earthbound You Win.wav");
            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {goblin.Name}!\n");
                System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" has leveled up!\n");
                System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("MAX HP increased by 20!\n");
                System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("Damage increased by 5!\n");
                System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite(" found more items!\n");
                System.Threading.Thread.Sleep(1000);
            Console.WriteLine("+2 Healing Potions");
                System.Threading.Thread.Sleep(1000);
            Console.WriteLine("+1 Mega potion");
                System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("+2 Throwing Knives\n");
                System.Threading.Thread.Sleep(2000);
            knight.MaxHealth += 20;
            knight.Damage += 5;
            potion.Inventory += 2;
            bigpotion.Inventory += 1;
            dagger.Inventory += 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
//slime fight
            Titles.LevelTwoTitle();
            SoundPlayer Battle2 = new SoundPlayer("Weird Opponent.wav");
            Battle2.Load();
            Battle2.PlayLooping();           

            Goon slime = new Goon
            {
                Name = "Repulsive Slime",
                GoonMaxHP = 150,
                GoonHealth = 150,
                GoonAttack1 = 10,
                GoonAttack2 = 30,
                GoonSpecial = 40
            };

            if (knight.Health <= 0)
            {
                knight.Health += 50;
            }
            knight.Defend = 3;

            while (slime.GoonHealth > 0)
            {
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend += 3;
                }
                Divider();
                slime.GoonDisplay();
                Divider();
                knight.KnightStats();
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"{slime.Name} blocks your path!", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
//attack
                        if (RNG > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            slime.GoonHealth -= knight.Damage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                            Console.ResetColor();
                            slime.GoonHealth -= (knight.Damage * 2);
                        }

                        System.Threading.Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (slime.GoonHealth > 0)
                        {
                            if (RNG2 >= 3)
                            {
                                Console.WriteLine($"{slime.Name} spits at you!");
                                knight.Health -= slime.GoonAttack1;
                            }
                            else
                            {
                                if (RNG3 > 1)
                                {
                                    Console.WriteLine($"{slime.Name} vomits sludge!");
                                    knight.Health -= slime.GoonAttack2;
                                }
                                else
                                {

                                    Console.WriteLine($"{slime.Name} recovers with its acid!");
                                    if (slime.GoonHealth < slime.GoonMaxHP)
                                    {
                                        slime.GoonHealth += slime.GoonSpecial;
                                        if (slime.GoonHealth > slime.GoonMaxHP)
                                        {
                                            slime.GoonHealth = slime.GoonMaxHP;
                                        }
                                    }
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine($"{slime.Name} evaporated!");
                        }
                        
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case 1:
//defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                            }
                            knight.Defend--;
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {slime.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }
                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {slime.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {slime.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"{slime.Name} spits at you!");
                                    knight.Health -= slime.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"{slime.Name} vomits sludge!");
                                    knight.Health -= slime.GoonAttack2;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                Console.ResetColor();
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {slime.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {slime.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"{slime.Name} spits at you!");
                                    knight.Health -= slime.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"{slime.Name} vomits sludge!");
                                    knight.Health -= slime.GoonAttack2;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                Console.ResetColor();
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
//items                        
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{dagger.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
//potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG >= 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {slime.Name} caught you off guard!");
                                                    knight.Health -= slime.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{slime.Name} is watching carefully.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
//mega potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {slime.Name} caught you off guard!");
                                                    knight.Health -= slime.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{slime.Name} is watching carefully.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 2:
//dagger
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            slime.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;

                                            if (RNG >= 3)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"{slime.Name} spits at you!");
                                                Console.ResetColor();
                                                knight.Health -= slime.GoonAttack1;
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            else
                                            {
                                                if (RNG2 > 1)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{slime.Name} vomits sludge!");
                                                    Console.ResetColor();
                                                    knight.Health -= slime.GoonAttack2;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {

                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{slime.Name} recovers with its acid!");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                    if (slime.GoonHealth < slime.GoonMaxHP)
                                                    {
                                                        slime.GoonHealth += slime.GoonSpecial;
                                                        if (slime.GoonHealth > slime.GoonMaxHP)
                                                        {
                                                            slime.GoonHealth = slime.GoonMaxHP;
                                                        }
                                                    }
                                                }

                                            }
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }       
                                break;
                                
                        }
                        
                        break;
                    
                }
            }
            Battle2.Stop();

            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {slime.Name}!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" has leveled up!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("MAX HP increased by 30!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("Damage increased by 5!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite(" found more items!\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("+3 Healing Potions");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("+2 Throwing Knife");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("NEW: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("+2 Blessed Water");
            System.Threading.Thread.Sleep(1000);

            knight.MaxHealth += 30;
            knight.Damage += 5;
            potion.Inventory += 3;
            dagger.Inventory += 2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();

//skelton fight
            Titles.LevelThreeTitle();
            SoundPlayer Battle3 = new SoundPlayer("Revelations  Mitsuo.wav");
            Battle3.Load();
            Battle3.PlayLooping();

            Goon skeleton = new Goon
            {
                Name = "Reanimated Warrior",
                GoonMaxHP = 250,
                GoonHealth = 250,
                GoonAttack1 = 20,
                GoonSpecial = 40,
                Status = false
            };
            int turns = 3;
            knight.Defend = 3;
            if (knight.Health <= 0)
            {
                knight.Health += 50;
            }
//skeleton fight
            
            while (skeleton.GoonHealth > 0)
            {
                
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend += 3;
                }
                if (turns == 0)
                {
                    knight.Status = false;
                }
                Divider();
                skeleton.GoonDisplay();
                if (skeleton.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ATK X2");
                    Console.ResetColor();
                }
                Divider();
                knight.KnightStats();
                if (knight.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ATK/2:    ");
                    Console.ResetColor();
                    Console.Write($"{turns}");
                }
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {skeleton.Name} stops you!", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                int RNG4 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
                        //attack
                        if(knight.Status == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            skeleton.GoonHealth -= knight.Damage / 2;
                            turns--;
                        }
                        else
                        {
                            if (RNG > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacks!");
                                Console.ResetColor();
                                skeleton.GoonHealth -= knight.Damage;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                                Console.ResetColor();
                                skeleton.GoonHealth -= (knight.Damage * 2);
                            }
                        }
                        

                        System.Threading.Thread.Sleep(2000);
                        if (skeleton.Status == true)
                        {
                            if (RNG2 >= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                Console.ResetColor();
                                knight.Health -= skeleton.GoonAttack1 * 2;
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                Console.ResetColor();
                                knight.Health -= skeleton.GoonSpecial * 2;
                                System.Threading.Thread.Sleep(2000);
                            }
                            skeleton.Status = false;
                        }
                        else
                        {
                            if (RNG2 >= 3)
                            {
                                if (RNG3 >= 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                    Console.ResetColor();
                                    knight.Health -= skeleton.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                    Console.ResetColor();
                                    knight.Health -= skeleton.GoonSpecial;
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else
                            {
                                if (RNG4 >= 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"The {skeleton.Name} put a curse on you!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine($"Your attack is halved!");
                                    Console.ResetColor();
                                    System.Threading.Thread.Sleep(2000);
                                    knight.Status = true;
                                    if (turns == 0)
                                    {
                                        turns = 3;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"The {skeleton.Name} charges up!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine($"{skeleton.Name}'s next attack will be stronger!");
                                    Console.ResetColor();
                                    System.Threading.Thread.Sleep(2000);
                                    skeleton.Status = true;
                                }
                            }
                        }
                        
                        Console.Clear();
                        break;

                    case 1:
                        //defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                                if (knight.Health > knight.MaxHealth)
                                {
                                    knight.Health = knight.MaxHealth;
                                }
                            }

                            knight.Defend--;
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {skeleton.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            if(skeleton.Status == true)
                            {
                                skeleton.Status = false;
                            }
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {skeleton.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                if (skeleton.Status == true)
                                {
                                    skeleton.Status = false;
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {skeleton.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (skeleton.Status == true)
                                {
                                    if (RNG2 >= 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                        Console.ResetColor();
                                        knight.Health -= skeleton.GoonAttack1 * 2;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                        Console.ResetColor();
                                        knight.Health -= skeleton.GoonSpecial * 2;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                else
                                {
                                    if (RNG2 >= 2)
                                    {
                                        Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                        knight.Health -= skeleton.GoonAttack1;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                        knight.Health -= skeleton.GoonSpecial;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                if (skeleton.Status == true)
                                {
                                    skeleton.Status = false;
                                }
                                Console.ResetColor();
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {skeleton.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                if (skeleton.Status == true)
                                {
                                    skeleton.Status = false;
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {skeleton.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (skeleton.Status == true)
                                {
                                    if (RNG2 >= 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                        Console.ResetColor();
                                        knight.Health -= skeleton.GoonAttack1 * 2;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                        Console.ResetColor();
                                        knight.Health -= skeleton.GoonSpecial * 2;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                else
                                {
                                    if (RNG2 >= 2)
                                    {
                                        Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                        knight.Health -= skeleton.GoonAttack1;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                        knight.Health -= skeleton.GoonSpecial;
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                if (skeleton.Status == true)
                                {
                                    skeleton.Status = false;
                                }
                                Console.ResetColor();
                            }
                        }
                        if (knight.Status == true)
                        {
                            turns--;
                        }
                        Console.Clear();
                        break;
                    case 2:
                        //items                        
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{holywater.Name}", $"{dagger.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            //potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turns--;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    if (skeleton.Status == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} caught you off guard!");
                                                        knight.Health -= skeleton.GoonAttack1 * 2;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} caught you off guard!");
                                                        knight.Health -= skeleton.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {skeleton.Name} is watching {Player.CharacterName}.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                               
                                break;
                            case 1:
                                //big potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turns--;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    if (skeleton.Status == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} caught you off guard!");
                                                        knight.Health -= skeleton.GoonAttack1 * 2;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} caught you off guard!");
                                                        knight.Health -= skeleton.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {skeleton.Name} is watching {Player.CharacterName}.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                //holy water
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{holywater.Description} {holywater.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (holywater.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {holywater.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            skeleton.GoonHealth -= holywater.Value;
                                            holywater.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turns--;
                                            }

                                            if (skeleton.Status == true)
                                            {
                                                if (RNG >= 3)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                                    Console.ResetColor();
                                                    knight.Health -= skeleton.GoonAttack1 * 2;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                                    Console.ResetColor();
                                                    knight.Health -= skeleton.GoonSpecial * 2;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                skeleton.Status = false;
                                            }
                                            else
                                            {
                                                if (RNG >= 3)
                                                {
                                                    if (RNG2 >= 3)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                                        Console.ResetColor();
                                                        knight.Health -= skeleton.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                                        Console.ResetColor();
                                                        knight.Health -= skeleton.GoonSpecial;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 4)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} put a curse on you!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        Console.WriteLine($"Your attack is halved!");
                                                        Console.ResetColor();
                                                        System.Threading.Thread.Sleep(2000);
                                                        knight.Status = true;
                                                        if (turns == 0)
                                                        {
                                                            turns = 3;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} charges up!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        Console.WriteLine($"{skeleton.Name}'s next attack will be stronger!");
                                                        Console.ResetColor();
                                                        System.Threading.Thread.Sleep(2000);
                                                        skeleton.Status = true;
                                                    }
                                                }
                                            }
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {holywater.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                //dagger
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            skeleton.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turns--;
                                            }

                                            if (skeleton.Status == true)
                                            {
                                                if (RNG >= 3)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                                    Console.ResetColor();
                                                    knight.Health -= skeleton.GoonAttack1 * 2;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                                    Console.ResetColor();
                                                    knight.Health -= skeleton.GoonSpecial * 2;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                skeleton.Status = false;
                                            }
                                            else
                                            {
                                                if (RNG >= 3)
                                                {
                                                    if (RNG2 >= 3)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} uses a slash attack!");
                                                        Console.ResetColor();
                                                        knight.Health -= skeleton.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} made a powerful swing!");
                                                        Console.ResetColor();
                                                        knight.Health -= skeleton.GoonSpecial;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 4)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} put a curse on you!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        Console.WriteLine($"Your attack is halved!");
                                                        Console.ResetColor();
                                                        System.Threading.Thread.Sleep(2000);
                                                        knight.Status = true;
                                                        if (turns == 0)
                                                        {
                                                            turns = 3;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"The {skeleton.Name} charges up!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        Console.WriteLine($"{skeleton.Name}'s next attack will be stronger!");
                                                        Console.ResetColor();
                                                        System.Threading.Thread.Sleep(2000);
                                                        skeleton.Status = true;
                                                    }
                                                }
                                            }
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                
                                break;
                        }
                        break;
                }
            }
            knight.Status = false;
            Battle3.Stop();

            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {skeleton.Name}!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" has leveled up!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("MAX HP increased by 50!\n");
            knight.MaxHealth += 50;
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("Damage increased by 5!\n");
            knight.Damage += 5;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");


            Console.ReadKey();
            Console.Clear();
            Rest1(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void Rest1(int Save, Player knight, Item potion,Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            Titles.RestArea();

            SoundPlayer Rest = new SoundPlayer("Rest Area.wav");
            Rest.Load();
            Rest.PlayLooping();

            Titles.RestAreaTitle();
            Utility.Typewrite("You enter a room filled with unguarded supplies.");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(".");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(".");
            System.Threading.Thread.Sleep(2000);
          
            Utility.Typewrite("\nYou take this opporunity to heal your wounds and gather supplies.\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite($" restored to MAX HP!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Blue;
            Utility.Typewrite($" improved thier SHIELDING!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite($" grabbed some supplies!\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+5 {potion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+3 {bigpotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"NEW: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+3 {megapotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+3 {holywater.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+5 {dagger.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"NEW: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+2 {axe.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");

            knight.Health = knight.MaxHealth;
            knight.DefHeal += 10;
            potion.Inventory += 5;
            bigpotion.Inventory += 3;
            holywater.Inventory += 3;
            dagger.Inventory += 5;
            knight.Defend = 3;

            Console.ReadKey();
            Console.Clear();
            RestAreaChoice1(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void RestAreaChoice1(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            int value = 1;
            while (value > 0)
            {
                Titles.RestAreaTitle();
                Utility.Typewrite("There are no enemies nearby...\n");
                System.Threading.Thread.Sleep(1000);
                string[] Commands = new string[] { $"View {Player.CharacterName}'s Stats", "Inspect Items" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"What shall you do?", $"{Commands.Length + 1}) Venture Forth!", Commands);
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Utility.TypewriteFast($"{Player.CharacterName}'s Stats");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Utility.TypewriteFast($"\nMAX HP: {knight.MaxHealth}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Utility.TypewriteFast($"\nMAX DAMAGE: {knight.Damage}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Utility.TypewriteFast($"\nSHIELD: {knight.Defend}");
                        Utility.TypewriteFast($"\nSHIELD (HEAL): {knight.DefHeal}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Utility.Typewrite(@"


Press ENTER to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1:
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{megapotion.Name}", $"{holywater.Name}", $"{dagger.Name}", $"{axe.Name}" };
                        int userItems = Utility.ShowUserOptionsAndGetAValidResponse($"Which Item should you look at?", $"{Items.Length + 1}) Go back", Items);
                        switch (userItems)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{potion.Name}
{potion.Description}
Inventory: {potion.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{bigpotion.Name}
{bigpotion.Description}
Inventory: {bigpotion.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{megapotion.Name}
{megapotion.Description}
Inventory: {megapotion.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{holywater.Name}
{holywater.Description}
Inventory: {holywater.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{dagger.Name}
{dagger.Description}
Inventory: {dagger.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{axe.Name}
{axe.Description}
Inventory: {axe.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Player.Name();
                        Utility.Typewrite($" marches onward!");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        value--;
                        break;
                }
            }
            Save++;
            Part2(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void KnightCheckpoint(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            /*Player knight = new Player
            {
                MaxHealth = 250,
                Health = 250,
                Damage = 25,
                Defend = 3,
                DefHeal = 20,
                Status = false
            };*/
            knight.MaxHealth = 250;
            knight.Health = knight.MaxHealth;
            knight.Damage = 25;
            knight.Status = false;

            if (potion.Inventory < 15)
            {
                potion.Inventory = 15;
            }
            if (bigpotion.Inventory < 5)
            {
                potion.Inventory = 5;
            }
            if (megapotion.Inventory < 3)
            {
                megapotion.Inventory = 3;
            }
            if (potionMax.Inventory < 2)
            {
                potionMax.Inventory = 2;
            }
            if (dagger.Inventory < 10)
            {
                dagger.Inventory = 10;
            }
            if (holywater.Inventory < 5)
            {
                holywater.Inventory = 5;
            }
            if (axe.Inventory < 3)
            {
                axe.Inventory = 3;
            }
            if (bomb.Inventory < 2)
            {
                bomb.Inventory = 2;
            }

            Part2(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void Part2(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            //bat fight
            Titles.LevelFourTitle();
            SoundPlayer Battle2 = new SoundPlayer("Bloody Tears.wav");
            Battle2.Load();
            Battle2.PlayLooping();

            Goon bat = new Goon
            {
                Name = "Vampire Bat",
                GoonHealth = 280,
                GoonMaxHP = 280,
                GoonAttack1 = 20,
                GoonAttack2 = 40,
                GoonSpecial = 40
            };

            if (knight.Health <= 0)
            {
                knight.Health += 50;
            }

            while (bat.GoonHealth > 0)
            {
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                Divider();
                bat.GoonDisplay();
                Divider();
                knight.KnightStats();
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {bat.Name} swoops in!", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                int RNG4 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
                        //attack
                        knight.Defend = 3;
                        if (RNG > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            bat.GoonHealth -= knight.Damage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                            Console.ResetColor();
                            bat.GoonHealth -= (knight.Damage * 2);
                        }

                        System.Threading.Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (RNG2 > 2)
                        {
                            if(RNG3 >= 5)
                            {
                                Console.WriteLine($"The {bat.Name} claws at {Player.CharacterName}!");
                                knight.Health -= bat.GoonAttack1;
                            }
                            else
                            {
                                Console.WriteLine($"The {bat.Name} slashes with its wings");
                                knight.Health -= bat.GoonAttack2;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The {bat.Name} lands a bite!"); 
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine($"The {bat.Name} drained health from {Player.CharacterName}");
                            knight.Health -= bat.GoonSpecial;
                            if (bat.GoonHealth < bat.GoonMaxHP)
                            {
                                bat.GoonHealth += bat.GoonSpecial;
                                if (bat.GoonHealth > bat.GoonMaxHP)
                                {
                                    bat.GoonHealth = bat.GoonMaxHP;
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case 1:
                        //defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                                if (knight.Health > knight.MaxHealth)
                                {
                                    knight.Health = knight.MaxHealth;
                                }
                            }

                            knight.Defend--;
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {bat.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {bat.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {bat.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"The {bat.Name} claws at {Player.CharacterName}!");
                                    knight.Health -= bat.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"The {bat.Name} slashes with its wings");
                                    knight.Health -= bat.GoonAttack2;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                Console.ResetColor();
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {bat.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {bat.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"The {bat.Name} claws at {Player.CharacterName}!");
                                    knight.Health -= bat.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"The {bat.Name} slashes with its wings");
                                    knight.Health -= bat.GoonAttack2;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                Console.ResetColor();
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
                        //items
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{megapotion.Name}", $"{holywater.Name}", $"{dagger.Name}", $"{axe.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            //potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {bat.Name} caught you off guard!");
                                                    knight.Health -= bat.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);

                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {bat.Name} flaps around.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
                                //big potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {bat.Name} caught you off guard!");
                                                    knight.Health -= bat.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {bat.Name} flaps around.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            //mega potion                
                            case 2:
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{megapotion.Description} {megapotion.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (megapotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {megapotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += megapotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                megapotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {bat.Name} caught you off guard!");
                                                    knight.Health -= bat.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {bat.Name} flaps around.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {megapotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {megapotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                //holy water
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{holywater.Description} {holywater.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (holywater.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {holywater.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            bat.GoonHealth -= holywater.Value;
                                            holywater.Inventory--;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (RNG2 > 2)
                                            {
                                                if (RNG3 >= 5)
                                                {
                                                    Console.WriteLine($"The {bat.Name} claws at {Player.CharacterName}!");
                                                    knight.Health -= bat.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {bat.Name} slashes with its wings");
                                                    knight.Health -= bat.GoonAttack2;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"The {bat.Name} lands a bite!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"The {bat.Name} drained health from {Player.CharacterName}");
                                                knight.Health -= bat.GoonSpecial;
                                                if (bat.GoonHealth < bat.GoonMaxHP)
                                                {
                                                    bat.GoonHealth += bat.GoonSpecial * 2;
                                                    if (bat.GoonHealth > bat.GoonMaxHP)
                                                    {
                                                        bat.GoonHealth = bat.GoonMaxHP;
                                                    }
                                                }

                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {holywater.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                        }
                                        Console.Clear();
                                        break;
                                }

                                break;
                            case 4:
                                //dagger
                                string[] YesNo4 = new string[] { "Yes" };
                                int userYesNo4 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo4.Length + 1}) No", YesNo4);
                                switch (userYesNo4)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            bat.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (RNG2 > 2)
                                            {
                                                if (RNG3 >= 5)
                                                {
                                                    Console.WriteLine($"The {bat.Name} claws at {Player.CharacterName}!");
                                                    knight.Health -= bat.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {bat.Name} slashes with its wings");
                                                    knight.Health -= bat.GoonAttack2;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"The {bat.Name} lands a bite!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"The {bat.Name} drained health from {Player.CharacterName}");
                                                knight.Health -= bat.GoonSpecial;
                                                if (bat.GoonHealth < bat.GoonMaxHP)
                                                {
                                                    bat.GoonHealth += bat.GoonSpecial * 2;
                                                    if (bat.GoonHealth > bat.GoonMaxHP)
                                                    {
                                                        bat.GoonHealth = bat.GoonMaxHP;
                                                    }
                                                }

                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 5:
                                //axe
                                string[] YesNo5 = new string[] { "Yes" };
                                int userYesNo5 = Utility.ShowUserOptionsAndGetAValidResponse($"{axe.Description} {axe.Inventory} left. Use?", $"{YesNo5.Length + 1}) No", YesNo5);
                                switch (userYesNo5)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (axe.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {axe.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            bat.GoonHealth -= axe.Value;
                                            axe.Inventory--;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (RNG2 > 2)
                                            {
                                                if (RNG3 >= 5)
                                                {
                                                    Console.WriteLine($"The {bat.Name} claws at {Player.CharacterName}!");
                                                    knight.Health -= bat.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {bat.Name} slashes with its wings");
                                                    knight.Health -= bat.GoonAttack2;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"The {bat.Name} lands a bite!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"The {bat.Name} drained health from {Player.CharacterName}");
                                                knight.Health -= bat.GoonSpecial;
                                                if (bat.GoonHealth < bat.GoonMaxHP)
                                                {
                                                    bat.GoonHealth += bat.GoonSpecial * 2;
                                                    if (bat.GoonHealth > bat.GoonMaxHP)
                                                    {
                                                        bat.GoonHealth = bat.GoonMaxHP;
                                                    }
                                                }

                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {axe.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                        }

                        break;

                }
            }
            Battle2.Stop();
            

            SoundPlayer Win = new SoundPlayer("Earthbound You Win.wav");
            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {bat.Name}!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" has leveled up!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("MAX HP increased by 20!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("Damage increased by 5!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite(" found more items!\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+5 {bigpotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+2 {megapotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+3 {holywater.Name}");
           

            knight.MaxHealth += 20;
            knight.Damage += 5;
            bigpotion.Inventory += 5;
            megapotion.Inventory += 2;
            holywater.Inventory += 3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();

            Goon ghost = new Goon
            {
                Name = "Silent Ghost",
                GoonMaxHP = 350,
                GoonHealth = 350,
                GoonAttack1 = 20,
                GoonAttack2 = 35
            };

            Titles.LevelFiveTitle();
            SoundPlayer Battle1 = new SoundPlayer("Ghost House.wav");
            Battle1.Load();
            Battle1.PlayLooping();
            int turns = 3;
            knight.Defend = 3;
            if (knight.Health <= 0)
            {
                knight.Health += 50;
            }
            //Ghost fight
            while (ghost.GoonHealth > 0)
            {
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend += 3;
                }
                if (turns == 0)
                {
                    knight.Status = false;
                }

                Divider();
                ghost.GoonDisplay();
                Divider();
                knight.KnightStats();
                if (knight.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ATK/2:    ");
                    Console.ResetColor();
                    Console.Write($"{turns}");
                }
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {ghost.Name} traps you.", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
                        //attack

                        if (knight.Status == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            ghost.GoonHealth -= knight.Damage / 2;
                            turns--;
                        }
                        else
                        {
                            if (RNG > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacks!");
                                Console.ResetColor();
                                ghost.GoonHealth -= knight.Damage;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                                Console.ResetColor();
                                ghost.GoonHealth -= (knight.Damage * 2);
                            }
                        }

                        System.Threading.Thread.Sleep(2000);
                        if (RNG2 > 3)
                        {
                            if (RNG3 >= 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {ghost.Name} snuck up on you!");
                                Console.ResetColor();
                                knight.Health -= ghost.GoonAttack1;
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {ghost.Name} lets out a shriek!");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"{Player.CharacterName}'s attack has been lowered!");
                                Console.ResetColor();
                                knight.Health -= ghost.GoonAttack2;
                                knight.Status = true;
                                if (turns == 0)
                                {
                                    turns = 3;
                                }
                                System.Threading.Thread.Sleep(2000);
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {ghost.Name} lets out a unsettling whisper...");
                            System.Threading.Thread.Sleep(2000);
                            if (RNG3 > 2)
                            {
                                Console.WriteLine($"The whisper had no effect.");
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine($"{Player.CharacterName}'s health was cut in half!");
                                System.Threading.Thread.Sleep(2000);
                                knight.Health /= 2;
                            }
                            Console.ResetColor();
                        }
                        Console.Clear();
                        break;

                    case 1:
                        //defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Status == true)
                            {
                                turns--;
                            }
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                                if(knight.Health > knight.MaxHealth)
                                {
                                    knight.Health = knight.MaxHealth;
                                }
                            }

                            knight.Defend--;
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {ghost.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else if (knight.Defend == 2)
                        {
                            if (knight.Status == true)
                            {
                                turns--;
                            }
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {ghost.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {ghost.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"The {ghost.Name} snuck up on you!");
                                    Console.ResetColor();
                                    knight.Health -= ghost.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"The {ghost.Name} lets out a shriek!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine($"{Player.CharacterName} offense is lowered!");
                                    Console.ResetColor();
                                    knight.Health -= ghost.GoonAttack2;
                                    knight.Status = true;
                                    if (turns == 0)
                                    {
                                        turns = 3;
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (knight.Status == true)
                            {
                                turns--;
                            }
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {ghost.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {ghost.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (RNG2 >= 2)
                                {
                                    Console.WriteLine($"The {ghost.Name} snuck up on you!");
                                    Console.ResetColor();
                                    knight.Health -= ghost.GoonAttack1;
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine($"The {ghost.Name} lets out a shriek!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine($"{Player.CharacterName} offense is lowered!");
                                    Console.ResetColor();
                                    knight.Health -= ghost.GoonAttack2;
                                    knight.Status = true;
                                    if (turns == 0)
                                    {
                                        turns = 3;
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
                        //items                        
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{megapotion.Name}", $"{holywater.Name}", $"{dagger.Name}", $"{axe.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            //potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if(knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} caught you off guard!");
                                                    knight.Health -= ghost.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);

                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} is muttering to itself...");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turns--;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
                                //big potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} caught you off guard!");
                                                    knight.Health -= ghost.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} is muttering to itself...");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turns--;
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            //mega potion                
                            case 2:
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{megapotion.Description} {megapotion.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (megapotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {megapotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += megapotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                megapotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} caught you off guard!");
                                                    knight.Health -= ghost.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} is muttering to itself...");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turns--;
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {megapotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {megapotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                //holy water
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{holywater.Description} {holywater.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (holywater.Inventory > 0)
                                        {
                                            if (knight.Status == true)
                                            {
                                                turns--;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {holywater.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            ghost.GoonHealth -= holywater.Value;
                                            holywater.Inventory--;
                                            if (RNG > 1)
                                            {
                                                if (RNG2 >= 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} snuck up on you!");
                                                    Console.ResetColor();
                                                    knight.Health -= ghost.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} lets out a shriek!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} offense is lowered!");
                                                    Console.ResetColor();
                                                    knight.Health -= ghost.GoonAttack2;
                                                    knight.Status = true;
                                                    if (turns == 0)
                                                    {
                                                        turns = 3;
                                                    }
                                                    System.Threading.Thread.Sleep(2000);
                                                }

                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"The {ghost.Name} lets out a unsettling whisper...");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG2 > 2)
                                                {
                                                    Console.WriteLine($"The whisper did not have any affect.");
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{Player.CharacterName} was cut in half!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    knight.Health /= 2;
                                                }
                                                Console.ResetColor();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {holywater.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                        }
                                        Console.Clear();
                                        break;
                                }

                                break;
                            case 4:
                                //dagger
                                string[] YesNo4 = new string[] { "Yes" };
                                int userYesNo4 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo4.Length + 1}) No", YesNo4);
                                switch (userYesNo4)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            if (knight.Status == true)
                                            {
                                                turns--;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            ghost.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;
                                            if (RNG > 1)
                                            {
                                                if (RNG2 >= 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} snuck up on you!");
                                                    Console.ResetColor();
                                                    knight.Health -= ghost.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} lets out a shriek!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} offense is lowered!");
                                                    Console.ResetColor();
                                                    knight.Health -= ghost.GoonAttack2;
                                                    knight.Status = true;
                                                    if (turns == 0)
                                                    {
                                                        turns = 3;
                                                    }
                                                    System.Threading.Thread.Sleep(2000);
                                                }

                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"The {ghost.Name} lets out a unsettling whisper...");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG2 > 2)
                                                {
                                                    Console.WriteLine($"The whisper did not have any affect.");
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{Player.CharacterName} was cut in half!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    knight.Health /= 2;
                                                }
                                                Console.ResetColor();
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 5:
                                //axe
                                string[] YesNo5 = new string[] { "Yes" };
                                int userYesNo5 = Utility.ShowUserOptionsAndGetAValidResponse($"{axe.Description} {axe.Inventory} left. Use?", $"{YesNo5.Length + 1}) No", YesNo5);
                                switch (userYesNo5)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (axe.Inventory > 0)
                                        {
                                            if (knight.Status == true)
                                            {
                                                turns--;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {axe.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            ghost.GoonHealth -= axe.Value;
                                            axe.Inventory--;
                                            if (RNG > 1)
                                            {
                                                if (RNG2 >= 2)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} snuck up on you!");
                                                    Console.ResetColor();
                                                    knight.Health -= ghost.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {ghost.Name} lets out a shriek!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} offense is lowered!");
                                                    Console.ResetColor();
                                                    knight.Health -= ghost.GoonAttack2;
                                                    knight.Status = true;
                                                    if (turns == 0)
                                                    {
                                                        turns = 3;
                                                    }
                                                    System.Threading.Thread.Sleep(2000);
                                                }

                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"The {ghost.Name} lets out a unsettling whisper...");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG2 > 2)
                                                {
                                                    Console.WriteLine($"The whisper did not have any affect.");
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{Player.CharacterName} was cut in half!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    knight.Health /= 2;
                                                }
                                                Console.ResetColor();
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {axe.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            knight.Status = false;
            Battle1.Stop();


            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {ghost.Name}!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" has leveled up!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("MAX HP increased by 30!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("Damage increased by 5!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite(" found more items!\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+5 {potion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+2 {megapotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"NEW: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+3 {potionMax.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+5 {dagger.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+1 {axe.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"NEW: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+2 {bomb.Name}");
            System.Threading.Thread.Sleep(1000);

            knight.MaxHealth += 30;
            knight.Damage += 5;
            potion.Inventory += 5;
            megapotion.Inventory += 2;
            dagger.Inventory += 5;
            axe.Inventory += 1;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();

            //golem fight
            Titles.LevelSixTitle();
            SoundPlayer Battle3 = new SoundPlayer("Unfounded Revenge.wav");
            Battle3.Load();
            Battle3.PlayLooping();

            Goon golem = new Goon
            {
                Name = "Towering Golem",
                GoonHealth = 600,
                GoonMaxHP = 600,
                GoonAttack1 = 25,
                GoonAttack2 = 40,
                GoonAttack3 = 20,
                GoonSpecial = 120,
                Status = false
            };
            int combo = 0;
            knight.Defend = 3;
            if (knight.Health <= 0)
            {
                knight.Health += 50;
            }
            //golem fight
            while (golem.GoonHealth > 0)
            {
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend = 3;
                }

                Divider();
                golem.GoonDisplay();
                if (golem.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    CHARGED");
                    Console.ResetColor();
                }
                Divider();
                knight.KnightStats();
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {golem.Name} stands in your way.", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                int RNG4 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
                        //attack
                        if (RNG > 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            golem.GoonHealth -= knight.Damage;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                            Console.ResetColor();
                            golem.GoonHealth -= (knight.Damage * 2);
                        }

                        System.Threading.Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (golem.Status == true)
                        {
                            Console.WriteLine($"The {golem.Name} finished charging its attack!");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                            knight.Health -= golem.GoonSpecial;
                            golem.Status = false;
                        }
                        else
                        {
                            if (RNG2 > 3)
                            {
                                if (RNG3 >= 4)
                                {
                                    Console.WriteLine($"{golem.Name} swings its arm!");
                                    knight.Health -= golem.GoonAttack1;
                                }
                                else
                                {
                                    Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                    knight.Health -= golem.GoonAttack2;
                                }
                            }
                            else
                            {
                                if (RNG3 >= 3)
                                {
                                    Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                    System.Threading.Thread.Sleep(2000);
                                    if (0 <= RNG4)
                                    {
                                        Console.WriteLine($"One!");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (4 < RNG4)
                                    {
                                        Console.WriteLine($"Two!");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (8 <= RNG4)
                                    {
                                        Console.WriteLine($"Three!");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    Console.WriteLine($"The attack landed {combo} times!");
                                    knight.Health -= golem.GoonAttack3 * combo;
                                    combo = 0;
                                }
                                else
                                {
                                    Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                    golem.Status = true;
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case 1:
                        //defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                                if (knight.Health > knight.MaxHealth)
                                {
                                    knight.Health = knight.MaxHealth;
                                }
                            }

                            knight.Defend--;
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The {golem.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            golem.Status = false;
                            Console.Clear();
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {golem.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                golem.Status = false;
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (golem.Status == true)
                                {
                                    Console.WriteLine($"The {golem.Name} finished charging its attack!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                                    knight.Health -= golem.GoonSpecial;
                                    golem.Status = false;
                                }
                                else
                                {
                                    if (RNG2 > 2)
                                    {
                                        if (RNG3 >= 4)
                                        {
                                            Console.WriteLine($"{golem.Name} swings its arm!");
                                            knight.Health -= golem.GoonAttack1;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                            knight.Health -= golem.GoonAttack2;
                                        }
                                    }
                                    else
                                    {
                                        if (RNG3 >= 2)
                                        {
                                            Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                            System.Threading.Thread.Sleep(2000);
                                            if (0 <= RNG4)
                                            {
                                                Console.WriteLine($"One!");
                                                System.Threading.Thread.Sleep(2000);
                                                combo++;
                                            }
                                            if (4 < RNG4)
                                            {
                                                Console.WriteLine($"Two!");
                                                System.Threading.Thread.Sleep(2000);
                                                combo++;
                                            }
                                            if (8 <= RNG4)
                                            {
                                                Console.WriteLine($"Three!");
                                                System.Threading.Thread.Sleep(2000);
                                                combo++;
                                            }
                                            Console.WriteLine($"The attack landed {combo} times!");
                                            knight.Health -= golem.GoonAttack3 * combo;
                                            combo = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                            golem.Status = true;
                                        }
                                    }
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                knight.Defend--;
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {golem.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                golem.Status = false;
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"The {golem.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (golem.Status == true)
                                {
                                    Console.WriteLine($"The {golem.Name} finished charging its attack!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                                    knight.Health -= golem.GoonSpecial;
                                    golem.Status = false;
                                }
                                else
                                {
                                    if (RNG2 > 2)
                                    {
                                        if (RNG3 >= 4)
                                        {
                                            Console.WriteLine($"{golem.Name} swings its arm!");
                                            knight.Health -= golem.GoonAttack1;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                            knight.Health -= golem.GoonAttack2;
                                        }
                                    }
                                    else
                                    {
                                        if (RNG3 >= 2)
                                        {
                                            Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                            System.Threading.Thread.Sleep(2000);
                                            if (0 <= RNG4)
                                            {
                                                Console.WriteLine($"One!");
                                                System.Threading.Thread.Sleep(2000);
                                                combo++;
                                            }
                                            if (4 < RNG4)
                                            {
                                                Console.WriteLine($"Two!");
                                                System.Threading.Thread.Sleep(2000);
                                                combo++;
                                            }
                                            if (8 <= RNG4)
                                            {
                                                Console.WriteLine($"Three!");
                                                System.Threading.Thread.Sleep(2000);
                                                combo++;
                                            }
                                            Console.WriteLine($"The attack landed {combo} times!");
                                            knight.Health -= golem.GoonAttack3 * combo;
                                            combo = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                            golem.Status = true;
                                        }
                                    }
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
                        //items                                    0                   1                     2                     3                       4                     5                  6                7 
                        string[] Items = new string[] { $"{ potion.Name }", $"{ bigpotion.Name }", $"{ megapotion.Name }", $"{potionMax.Name}", $"{ holywater.Name }", $"{ dagger.Name }", $"{ axe.Name }", $"{bomb.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            //potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} caught you off guard!");
                                                    knight.Health -= golem.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} stands firmly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
                                //big potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} caught you off guard!");
                                                    knight.Health -= golem.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} stands firmly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                //mega potion
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{megapotion.Description} {megapotion.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (megapotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {megapotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += megapotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                megapotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} caught you off guard!");
                                                    knight.Health -= golem.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} stands firmly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {megapotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {megapotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                //max potion
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{potionMax.Description} {potionMax.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potionMax.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potionMax.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health = knight.MaxHealth;
                                                potionMax.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} caught you off guard!");
                                                    knight.Health -= golem.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {golem.Name} stands firmly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potionMax.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potionMax.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 4:
                                //holy water
                                string[] YesNo4 = new string[] { "Yes" };
                                int userYesNo4 = Utility.ShowUserOptionsAndGetAValidResponse($"{holywater.Description} {holywater.Inventory} left. Use?", $"{YesNo4.Length + 1}) No", YesNo4);
                                switch (userYesNo4)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (holywater.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {holywater.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            golem.GoonHealth -= holywater.Value;
                                            holywater.Inventory--;

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (golem.Status == true)
                                            {
                                                Console.WriteLine($"The {golem.Name} finished charging its attack!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                                                knight.Health -= golem.GoonSpecial;
                                                golem.Status = false;
                                            }
                                            else
                                            {
                                                if (RNG2 > 2)
                                                {
                                                    if (RNG3 >= 4)
                                                    {
                                                        Console.WriteLine($"{golem.Name} swings its arm!");
                                                        knight.Health -= golem.GoonAttack1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                                        knight.Health -= golem.GoonAttack2;
                                                    }
                                                }
                                                else
                                                {
                                                    if (RNG3 >= 2)
                                                    {
                                                        Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        if (0 <= RNG4)
                                                        {
                                                            Console.WriteLine($"One!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (4 < RNG4)
                                                        {
                                                            Console.WriteLine($"Two!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (8 <= RNG4)
                                                        {
                                                            Console.WriteLine($"Three!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        Console.WriteLine($"The attack landed {combo} times!");
                                                        knight.Health -= golem.GoonAttack3 * combo;
                                                        combo = 0;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                                        golem.Status = true;
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {holywater.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 5:
                                //dagger
                                string[] YesNo5 = new string[] { "Yes" };
                                int userYesNo5 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo5.Length + 1}) No", YesNo5);
                                switch (userYesNo5)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            golem.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (golem.Status == true)
                                            {
                                                Console.WriteLine($"The {golem.Name} finished charging its attack!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                                                knight.Health -= golem.GoonSpecial;
                                                golem.Status = false;
                                            }
                                            else
                                            {
                                                if (RNG2 > 2)
                                                {
                                                    if (RNG3 >= 4)
                                                    {
                                                        Console.WriteLine($"{golem.Name} swings its arm!");
                                                        knight.Health -= golem.GoonAttack1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                                        knight.Health -= golem.GoonAttack2;
                                                    }
                                                }
                                                else
                                                {
                                                    if (RNG3 >= 2)
                                                    {
                                                        Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        if (0 <= RNG4)
                                                        {
                                                            Console.WriteLine($"One!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (4 < RNG4)
                                                        {
                                                            Console.WriteLine($"Two!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (8 <= RNG4)
                                                        {
                                                            Console.WriteLine($"Three!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        Console.WriteLine($"The attack landed {combo} times!");
                                                        knight.Health -= golem.GoonAttack3 * combo;
                                                        combo = 0;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                                        golem.Status = true;
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 6:
                                //axe
                                string[] YesNo6 = new string[] { "Yes" };
                                int userYesNo6 = Utility.ShowUserOptionsAndGetAValidResponse($"{axe.Description} {axe.Inventory} left. Use?", $"{YesNo6.Length + 1}) No", YesNo6);
                                switch (userYesNo6)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (axe.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {axe.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            golem.GoonHealth -= axe.Value;
                                            axe.Inventory--;

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (golem.Status == true)
                                            {
                                                Console.WriteLine($"The {golem.Name} finished charging its attack!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                                                knight.Health -= golem.GoonSpecial;
                                                golem.Status = false;
                                            }
                                            else
                                            {
                                                if (RNG2 > 2)
                                                {
                                                    if (RNG3 >= 4)
                                                    {
                                                        Console.WriteLine($"{golem.Name} swings its arm!");
                                                        knight.Health -= golem.GoonAttack1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                                        knight.Health -= golem.GoonAttack2;
                                                    }
                                                }
                                                else
                                                {
                                                    if (RNG3 >= 2)
                                                    {
                                                        Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        if (0 <= RNG4)
                                                        {
                                                            Console.WriteLine($"One!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (4 < RNG4)
                                                        {
                                                            Console.WriteLine($"Two!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (8 <= RNG4)
                                                        {
                                                            Console.WriteLine($"Three!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        Console.WriteLine($"The attack landed {combo} times!");
                                                        knight.Health -= golem.GoonAttack3 * combo;
                                                        combo = 0;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                                        golem.Status = true;
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {axe.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 7:
                                //bomb
                                string[] YesNo7 = new string[] { "Yes" };
                                int userYesNo7 = Utility.ShowUserOptionsAndGetAValidResponse($"{bomb.Description} {bomb.Inventory} left. Use?", $"{YesNo7.Length + 1}) No", YesNo7);
                                switch (userYesNo7)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bomb.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {bomb.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            golem.GoonHealth -= bomb.Value;
                                            bomb.Inventory--;

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (golem.Status == true)
                                            {
                                                Console.WriteLine($"The {golem.Name} finished charging its attack!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{golem.Name} attacks with a giant fist!");
                                                knight.Health -= golem.GoonSpecial;
                                                golem.Status = false;
                                            }
                                            else
                                            {
                                                if (RNG2 > 2)
                                                {
                                                    if (RNG3 >= 4)
                                                    {
                                                        Console.WriteLine($"{golem.Name} swings its arm!");
                                                        knight.Health -= golem.GoonAttack1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} stomped the ground aggresively!");
                                                        knight.Health -= golem.GoonAttack2;
                                                    }
                                                }
                                                else
                                                {
                                                    if (RNG3 >= 2)
                                                    {
                                                        Console.WriteLine($"{golem.Name} is causing the ground to shake!");
                                                        System.Threading.Thread.Sleep(2000);
                                                        if (0 <= RNG4)
                                                        {
                                                            Console.WriteLine($"One!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (4 < RNG4)
                                                        {
                                                            Console.WriteLine($"Two!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        if (8 <= RNG4)
                                                        {
                                                            Console.WriteLine($"Three!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            combo++;
                                                        }
                                                        Console.WriteLine($"The attack landed {combo} times!");
                                                        knight.Health -= golem.GoonAttack3 * combo;
                                                        combo = 0;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{golem.Name} is charging for its next attack!");
                                                        golem.Status = true;
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bomb.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            Battle3.Stop();

            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {golem.Name}!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" has leveled up!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("MAX HP increased by 50!\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite("Damage increased by 5!\n");
            System.Threading.Thread.Sleep(1000);

            knight.MaxHealth += 50;
            knight.Damage += 5;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");

            Console.ReadKey();
            Console.Clear();
            Rest2(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void Rest2(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            Titles.RestArea();

            SoundPlayer Rest = new SoundPlayer("Rest Area.wav");
            Rest.Load();
            Rest.PlayLooping();

            Titles.RestAreaTitle();
            Utility.Typewrite("You once again enter a room filled with unguarded supplies.");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(".");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(".");
            System.Threading.Thread.Sleep(2000);

            Utility.Typewrite("\nYou take this opporunity to heal your wounds and gather supplies.\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite($" restored to MAX HP!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Blue;
            Utility.Typewrite($" improved thier SHIELDING!\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.Typewrite($" grabbed some supplies!\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+10 {potion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+3 {bigpotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+2 {megapotion.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+1 {potionMax.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+5 {holywater.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+10 {dagger.Name}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"+2 {axe.Name}");
            System.Threading.Thread.Sleep(1000);

            knight.Health = knight.MaxHealth;
            knight.DefHeal += 10;
            potion.Inventory += 10;
            bigpotion.Inventory += 3;
            megapotion.Inventory += 2;
            potionMax.Inventory += 1;
            dagger.Inventory += 10;
            holywater.Inventory += 5;
            axe.Inventory += 2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.Typewrite(@"


Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
            RestAreaChoice2(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void RestAreaChoice2(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            int value = 1;
            while (value > 0)
            {
                Titles.RestAreaTitle();
                Utility.Typewrite("The final battle is near...\n");
                System.Threading.Thread.Sleep(1000);
                string[] Commands = new string[] { $"View {Player.CharacterName}'s Stats", "Inspect Items" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"What shall you do?", $"{Commands.Length + 1}) Venture Forth!", Commands);
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Utility.TypewriteFast($"{Player.CharacterName}'s Stats");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Utility.TypewriteFast($"\nMAX HP: {knight.MaxHealth}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Utility.TypewriteFast($"\nMAX DAMAGE: {knight.Damage}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Utility.TypewriteFast($"\nSHIELD: {knight.Defend}");
                        Utility.TypewriteFast($"\nSHIELD (HEAL): {knight.DefHeal}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Utility.Typewrite(@"


Press ENTER to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1:
                        string[] Items = new string[] { $"{potion.Name}", $"{bigpotion.Name}", $"{megapotion.Name}", $"{potionMax.Name}", $"{holywater.Name}", $"{dagger.Name}", $"{axe.Name}", $"{bomb.Name}" };
                        int userItems = Utility.ShowUserOptionsAndGetAValidResponse($"Which Item should you look at?", $"{Items.Length + 1}) Go back", Items);
                        switch (userItems)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{potion.Name}
{potion.Description}
Inventory: {potion.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{bigpotion.Name}
{bigpotion.Description}
Inventory: {bigpotion.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{megapotion.Name}
{megapotion.Description}
Inventory: {megapotion.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{potionMax.Name}
{potionMax.Description}
Inventory: {potionMax.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{holywater.Name}
{holywater.Description}
Inventory: {holywater.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{dagger.Name}
{dagger.Description}
Inventory: {dagger.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{axe.Name}
{axe.Description}
Inventory: {axe.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Utility.TypewriteFast($@"{bomb.Name}
{bomb.Description}
Inventory: {bomb.Inventory}");
                                Utility.Typewrite(@"


Press ENTER to continue.");
                                Console.ReadKey();
                                break;
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Player.Name();
                        Utility.Typewrite($" marches onward!");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        value--;
                        break;
                }
            }
            
            Save++;
            Final(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void KnightFinalCheckpoint(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            /*Player knight = new Player
            {
                MaxHealth = 350,
                Health = 350,
                Damage = 40,
                Defend = 3,
                DefHeal = 30,
                Status = false
            };*/
            knight.MaxHealth = 350;
            knight.Health = knight.MaxHealth;
            knight.Damage = 40;
            knight.Defend = 3;
            knight.Status = false;

            if (potion.Inventory < 15)
            {
                potion.Inventory = 15;
            }
            if (bigpotion.Inventory < 5)
            {
                potion.Inventory = 5;
            }
            if (megapotion.Inventory < 3)
            {
                megapotion.Inventory = 3;
            }
            if (dagger.Inventory < 10)
            {
                dagger.Inventory = 10;
            }
            if (holywater.Inventory < 5)
            {
                holywater.Inventory = 5;
            }
            if (axe.Inventory < 3)
            {
                axe.Inventory = 3;
            }

            Final(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
        }
        public void PreFinal()
        {
            Titles.FinalTitle();

            SoundPlayer Dialogue = new SoundPlayer("Dyna Blades Nest.wav");
            Dialogue.Load();
            Dialogue.Play();
            /*
                               ============================================================================
             */
            ASCII.ASCIIOverlord();
            Divider();
            Player.Name();
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite(" You finally reached the top of my domain.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("I am the OVERLORD,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" and I rule over this land.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("I pity you for thinking you would so easily take me down.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("You have taken down each one of my GOONS that guard this tower.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("However,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" I have no intention of losing to you.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("I must admit, ");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("it must have taken a lot of skill to reach me here.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("You would have made a strong ally.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("Unfortunately");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            /*
                               ============================================================================
             */
            SoundPlayer Draw = new SoundPlayer("Battle Start Sound.wav");
            Draw.Load();
            Draw.Play();
            ASCII.ASCIIOverlordFight();
            Divider();
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.TypewriteFast("                           Your journey ends here.");
            Console.ResetColor();
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
        public void PreDragon()
        {
            Console.Clear();
            ASCII.ASCIIOverlordFight();
            Divider();
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            ASCII.ASCIIOverlordDefeat();
            Divider();
            System.Threading.Thread.Sleep(1000);
            SoundPlayer FalseVictory = new SoundPlayer("False Victory.wav");
            FalseVictory.Load();
            FalseVictory.Play();
            Utility.Typewrite($"Congratulations! You defeated the The Overlord");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write("?");
            System.Threading.Thread.Sleep(1000);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            ASCII.ASCIIOverlordDefeat();
            Console.ResetColor();
            Divider();
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("You think you've won?");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" Pitiful.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("I'm afriad we are just getting started.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("Now,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" come forth...\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("FELL DRAGON!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        public void DragonDefeat()
        {
            {

            
            Console.WindowHeight = 30;
            SoundPlayer Victory = new SoundPlayer("Triumphant Victory.wav");
            Victory.Play();
            string dragon = @"

                            / | ___.--~~~--.___ | \
       ...--=.._           /  ~~___~\_   _/~___~~  \        _..=--...
  _.-~~   .-=_)/==._     _ \ .(~  o~-.\ /.-~o  ~). / _  _.==\(_=-.   ~~-._
 -      _/.-  /         / \/\_ ~---~_-=V=-_~---~ _/\/ \      \  -.\_      -
 ~     /_/  ./          \/\_-_~~v-/~o~) (~o~\-v~~_-_/\/       \.  \_\      ~
     ///    |          _-=___==/(__         __)\==___=-_       |    \\\
   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon1 = @"


       ...--=.._           /  ~~___~\_   _/~___~~  \        _..=--...
  _.-~~   .-=_)/==._     _ \ .(~  o~-.\ /.-~o  ~). / _  _.==\(_=-.   ~~-._
 -      _/.-  /         / \/\_ ~---~_-=V=-_~---~ _/\/ \      \  -.\_      -
 ~     /_/  ./          \/\_-_~~v-/~o~) (~o~\-v~~_-_/\/       \.  \_\      ~
     ///    |          _-=___==/(__         __)\==___=-_       |    \\\
   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon1);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon2 = @"



  _.-~~   .-=_)/==._     _ \ .(~  o~-.\ /.-~o  ~). / _  _.==\(_=-.   ~~-._
 -      _/.-  /         / \/\_ ~---~_-=V=-_~---~ _/\/ \      \  -.\_      -
 ~     /_/  ./          \/\_-_~~v-/~o~) (~o~\-v~~_-_/\/       \.  \_\      ~
     ///    |          _-=___==/(__         __)\==___=-_       |    \\\
   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon2);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon3 = @"




 -      _/.-  /         / \/\_ ~---~_-=V=-_~---~ _/\/ \      \  -.\_      -
 ~     /_/  ./          \/\_-_~~v-/~o~) (~o~\-v~~_-_/\/       \.  \_\      ~
     ///    |          _-=___==/(__         __)\==___=-_       |    \\\
   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon3);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon4 = @"





 ~     /_/  ./          \/\_-_~~v-/~o~) (~o~\-v~~_-_/\/       \.  \_\      ~
     ///    |          _-=___==/(__         __)\==___=-_       |    \\\
   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon4);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon5 = @"






     ///    |          _-=___==/(__         __)\==___=-_       |    \\\
   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon5);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon6 = @"







   /(( ))    \          _/ _ \ X___---===---___X / _ \_       /    (( ))\
  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon6);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon7 = @"








  /  |\ \_   |         /_\/_\ (( \| ` ` ' ' |/ )) /_\/_\      |   _/ /|  \
 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon7);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon8 = @"









 /   | \  \   \       ~~  / _ /\\ V  /~V~)  V //\ _ \  ~~    /   /  / |   \
/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon8);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon9 = @"










/    |  \_ \  |           \/ \\ \\^  \ )/   ^//|// \/        |  / _/  |    \
    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon9);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon10 = @"











    |     \ \  \               '/\\^  )/   ^// |`           /  / /     |
    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon10);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon11 = @"












    |      \ \_ |             '| (\\^ V   ^//  |`          | _/ /      |
    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon11);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon12 = @"













    |       \  \\             '/(~~\`-___-'/) /`           //  /       |
    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon12);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon13 = @"














    |        \_ \\ /|        '|(~~~-\_   _/)  |`          |\ _/        |
     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon13);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon14 = @"















     |         \_/~~~~-.     '/(~~~---===~~)  |`      .-~~~~~\_       |
 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon14);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon15 = @"
















 _._ | ._     _/   _    \   '|(~~~-----~~~)  /`      /     _   \_ .-. | _._
/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon15);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon16 = @"

















/   \|/  \   // / /\\~)  \  '|(~~~-----~~~)  |`     /   (~//\ \ \X   \|/   \";
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(dragon16);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon17 = @"

















";
            Divider();
            
            Console.WriteLine(dragon17);
            Console.ResetColor();
            Console.Write("===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon18 = @"

















";
            Divider();

            Console.WriteLine(dragon18);

            Console.Write("===========");
            
            Console.Write(@"=======");
            
            Console.Write("==========================================");
            
            Console.Write(@"======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon19 = @"

















";
            Divider();

            Console.WriteLine(dragon19);

            Console.Write("===========");

            Console.Write(@"=======");

            Console.Write("==========================================");
            
            Console.Write(@"======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"

            \_)\                                                /\_)
             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon20 = @"

















";
            Divider();

            Console.WriteLine(dragon20);

            Console.Write("===========");

            Console.Write(@"=======");

            Console.Write("==========================================");
           
            Console.Write(@"======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"


             \                                                    /");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ResetColor();
            string dragon21 = @"

















";
            Divider();

            Console.WriteLine(dragon21);

            Console.Write("===========");

            Console.Write(@"=======");

            Console.Write("==========================================");
            
            Console.Write(@"======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("==========");
            
            Console.Write(@"


");
            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.ResetColor();
            string VICTORY = @"
               __      _______ _____ _______ ____  _______     __
               \ \    / /_   _/ ____|__   __/ __ \|  __ \ \   / /
                \ \  / /  | || |       | | | |  | | |__) \ \_/ / 
                 \ \/ /   | || |       | | | |  | |  _  / \   /  
                  \  /   _| || |____   | | | |__| | | \ \  | |   
                   \/   |_____\_____|  |_|  \____/|_|  \_\ |_|   
";
            Divider();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.TypewriteFast(VICTORY);
            Console.ResetColor();
            Divider();
            Utility.TypewriteFast($@"
                       You vanquished the Fell Dragon!");
            System.Threading.Thread.Sleep(8000);
            Console.Clear();
        }
        public void Final(int Save, Player knight, Item potion, Item bigpotion, Item megapotion, Item potionMax, Item holywater, Item dagger, Item axe, Item bomb)
        {
            PreFinal();

            Goon overlord = new Goon
            {
                Name = "The Overlord",
                GoonHealth = 800,
                GoonMaxHP = 800,
                GoonAttack1 = 20,
                GoonAttack2 = 60,
                GoonAttack3 = 15,
                GoonSpecial = 100,
                Status = false    
            };

            SoundPlayer Overlord = new SoundPlayer("Grand Doomer.wav");
            Overlord.Load();
            Overlord.PlayLooping();
            //overlord fight
            if (knight.Health <= 0 )
            {
                knight.Health += 100;
            }
            knight.Defend = 3;
            int turnsGoon = 3;
            int turnsPlayer = 3;
            bool charged = false;
            while (overlord.GoonHealth > 0)
            {
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend = 3;
                }
                if (turnsGoon == 0)
                {
                    overlord.Status = false;
                }
                if (turnsPlayer == 0)
                {
                    knight.Status = false;
                }
                ASCII.ASCIIOverlordFight();
                Divider();
                overlord.GoonDisplay();
                if (overlord.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ATK X2: ");
                    Console.ResetColor();
                    Console.Write($"{turnsGoon}");
                }
                if (charged == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    CHARGED");
                    Console.ResetColor();
                }
                Divider();
                knight.KnightStats();
                if (knight.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ATK/2: ");
                    Console.ResetColor();
                    Console.Write($"{turnsPlayer}");
                }
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The final battle is here.", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                int RNG4 = Utility.GetRandomNumber();
                int RNG5 = Utility.GetRandomNumber();
                int RNG6 = Utility.GetRandomNumber();
                int RNG7 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
                        //attack
                        if (knight.Status == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            overlord.GoonHealth -= knight.Damage / 2;
                            turnsPlayer--;
                        }
                        else
                        {
                            if (RNG > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacks!");
                                Console.ResetColor();
                                overlord.GoonHealth -= knight.Damage;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                                Console.ResetColor();
                                overlord.GoonHealth -= (knight.Damage * 2);
                            }
                        }
                        System.Threading.Thread.Sleep(2000);

                        Console.ForegroundColor = ConsoleColor.Red;
                        if (overlord.Status == true)
                        {
                            if (charged == true)
                            {
                                Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                knight.Health -= overlord.GoonSpecial * 2;
                                charged = false;
                            }
                            else
                            {
                                if (RNG2 >= 5)
                                {
                                    if (RNG3 >= 4)
                                    {
                                        Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                        knight.Health -= overlord.GoonAttack1 * 2;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                        knight.Health -= overlord.GoonAttack2 * 2;
                                        overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                    }
                                }
                                else
                                {
                                    if (RNG4 >= 5)
                                    {
                                        //multi hit
                                        int combo = 0;
                                        int totalDMG = 0;
                                        if (RNG5 >= 3)
                                        {
                                            Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                            System.Threading.Thread.Sleep(2000);
                                            if (RNG6 >= 0)
                                            {
                                                Console.Write("One! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 > 2)
                                            {
                                                Console.Write("Two! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 > 4)
                                            {
                                                Console.Write("Three! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 > 6)
                                            {
                                                Console.Write("Four! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 >= 8)
                                            {
                                                Console.Write("Five!");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (combo == 1)
                                            {
                                                Console.WriteLine($"\nThe attack hit {combo} time");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nThe attack hit {combo} times");
                                            }
                                            totalDMG = overlord.GoonAttack3 * combo;
                                            knight.Health -= totalDMG * 2;

                                        }
                                        // enemy charge
                                        else
                                        {
                                            Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                            charged = true;
                                        }
                                        
                                    }
                                    else
                                    {
                                        // cut player atk
                                        if (RNG7 >= 4)
                                        {
                                            Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                            knight.Status = true;
                                            if (turnsPlayer == 0)
                                            {
                                                turnsPlayer = 3;
                                            }
                                        }
                                        // boost enemy atk
                                        else
                                        {
                                            Console.WriteLine($"{overlord.Name} powered themselves up!");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                            overlord.Status = true;
                                            if (turnsGoon == 0)
                                            {
                                                turnsGoon = 3;
                                            }
                                        }
                                    }
                                }
                            }
                            turnsGoon--;
                        }
                        else
                        {
                            if (charged == true)
                            {
                                Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                knight.Health -= overlord.GoonSpecial;
                                charged = false;
                            }
                            else
                            {
                                if (RNG2 >= 5)
                                {
                                    if (RNG3 >= 4)
                                    {
                                        Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                        knight.Health -= overlord.GoonAttack1;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                        knight.Health -= overlord.GoonAttack2;
                                        overlord.GoonHealth += overlord.GoonAttack2;
                                    }
                                }
                                else
                                {
                                    if (RNG4 >= 5)
                                    {
                                        int combo = 0;
                                        if (RNG5 >= 3)
                                        {
                                            Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                            System.Threading.Thread.Sleep(2000);
                                            if (RNG6 >= 0)
                                            {
                                                Console.Write("One! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 > 2)
                                            {
                                                Console.Write("Two! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 > 4)
                                            {
                                                Console.Write("Three! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 > 6)
                                            {
                                                Console.Write("Four! ");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (RNG6 >= 8)
                                            {
                                                Console.Write("Five!");
                                                System.Threading.Thread.Sleep(1000);
                                                combo++;
                                            }
                                            if (combo == 1)
                                            {
                                                Console.WriteLine($"\nThe attack hit {combo} time");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nThe attack hit {combo} times");
                                            }
                                            knight.Health -= overlord.GoonAttack3 * combo;

                                        }
                                        else
                                        {
                                            Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                            charged = true;
                                        }

                                    }
                                    else
                                    {
                                        if (RNG7 >= 4)
                                        {
                                            Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                            knight.Status = true;
                                            if (turnsPlayer == 0)
                                            {
                                                turnsPlayer = 3;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{overlord.Name} powered themselves up!");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                            overlord.Status = true;
                                            if (turnsGoon == 0)
                                            {
                                                turnsGoon = 3;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case 1:
                        //defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                                if (knight.Health > knight.MaxHealth)
                                {
                                    knight.Health = knight.MaxHealth;
                                }
                            }

                            
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{overlord.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            knight.Defend--;
                            charged = false;
                            if (overlord.Status == true)
                            {
                                turnsGoon--;
                            }
                            if (knight.Status == true)
                            {
                                turnsPlayer--;
                            }
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{overlord.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                knight.Defend--;
                                charged = false;
                                if (overlord.Status == true)
                                {
                                    turnsGoon--;
                                }
                                if (knight.Status == true)
                                {
                                    turnsPlayer--;
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{overlord.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (overlord.Status == true)
                                {
                                    if (charged == true)
                                    {
                                        Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                        knight.Health -= overlord.GoonSpecial * 2;
                                        charged = false;
                                    }
                                    else
                                    {
                                        if (RNG2 >= 5)
                                        {
                                            if (RNG3 >= 4)
                                            {
                                                Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                knight.Health -= overlord.GoonAttack1 * 2;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                knight.Health -= overlord.GoonAttack2 * 2;
                                                overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                            }
                                        }
                                        else
                                        {
                                            if (RNG4 >= 5)
                                            {
                                                //multi hit
                                                int combo = 0;
                                                int totalDMG = 0;
                                                if (RNG5 >= 3)
                                                {
                                                    Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    if (RNG6 >= 0)
                                                    {
                                                        Console.Write("One! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 2)
                                                    {
                                                        Console.Write("Two! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 4)
                                                    {
                                                        Console.Write("Three! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 6)
                                                    {
                                                        Console.Write("Four! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 >= 8)
                                                    {
                                                        Console.Write("Five!");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (combo == 1)
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} time");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} times");
                                                    }
                                                    totalDMG = overlord.GoonAttack3 * combo;
                                                    knight.Health -= totalDMG * 2;

                                                }
                                                // enemy charge
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                    charged = true;
                                                }

                                            }
                                            else
                                            {
                                                // cut player atk
                                                if (RNG7 >= 4)
                                                {
                                                    Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                    knight.Status = true;
                                                    if (turnsPlayer == 0)
                                                    {
                                                        turnsPlayer = 3;
                                                    }
                                                }
                                                // boost enemy atk
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                    overlord.Status = true;
                                                    if (turnsGoon == 0)
                                                    {
                                                        turnsGoon = 3;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    turnsGoon--;
                                }
                                else
                                {
                                    if (charged == true)
                                    {
                                        Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                        knight.Health -= overlord.GoonSpecial;
                                        charged = false;
                                    }
                                    else
                                    {
                                        if (RNG2 >= 5)
                                        {
                                            if (RNG3 >= 4)
                                            {
                                                Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                knight.Health -= overlord.GoonAttack1;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                knight.Health -= overlord.GoonAttack2;
                                                overlord.GoonHealth += overlord.GoonAttack2;
                                            }
                                        }
                                        else
                                        {
                                            if (RNG4 >= 5)
                                            {
                                                int combo = 0;
                                                if (RNG5 >= 3)
                                                {
                                                    Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    if (RNG6 >= 0)
                                                    {
                                                        Console.Write("One! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 2)
                                                    {
                                                        Console.Write("Two! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 4)
                                                    {
                                                        Console.Write("Three! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 6)
                                                    {
                                                        Console.Write("Four! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 >= 8)
                                                    {
                                                        Console.Write("Five!");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (combo == 1)
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} time");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} times");
                                                    }
                                                    knight.Health -= overlord.GoonAttack3 * combo;

                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                    charged = true;
                                                }

                                            }
                                            else
                                            {
                                                if (RNG7 >= 4)
                                                {
                                                    Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                    knight.Status = true;
                                                    if (turnsPlayer == 0)
                                                    {
                                                        turnsPlayer = 3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                    overlord.Status = true;
                                                    if (turnsGoon == 0)
                                                    {
                                                        turnsGoon = 3;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (knight.Status == true)
                                {
                                    turnsPlayer--;
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                            }
                        }
                        else if (knight.Defend <= 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{overlord.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                knight.Defend--;
                                charged = false;
                                if (overlord.Status == true)
                                {
                                    turnsGoon--;
                                }
                                if (knight.Status == true)
                                {
                                    turnsPlayer--;
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{overlord.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                if (overlord.Status == true)
                                {
                                    if (charged == true)
                                    {
                                        Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                        knight.Health -= overlord.GoonSpecial * 2;
                                        charged = false;
                                    }
                                    else
                                    {
                                        if (RNG2 >= 5)
                                        {
                                            if (RNG3 >= 4)
                                            {
                                                Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                knight.Health -= overlord.GoonAttack1 * 2;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                knight.Health -= overlord.GoonAttack2 * 2;
                                                overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                            }
                                        }
                                        else
                                        {
                                            if (RNG4 >= 3)
                                            {
                                                //multi hit
                                                int combo = 0;
                                                int totalDMG = 0;
                                                if (RNG5 >= 3)
                                                {
                                                    Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    if (RNG6 >= 0)
                                                    {
                                                        Console.Write("One! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 2)
                                                    {
                                                        Console.Write("Two! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 4)
                                                    {
                                                        Console.Write("Three! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 6)
                                                    {
                                                        Console.Write("Four! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 >= 8)
                                                    {
                                                        Console.Write("Five!");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (combo == 1)
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} time");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} times");
                                                    }
                                                    totalDMG = overlord.GoonAttack3 * combo;
                                                    knight.Health -= totalDMG * 2;

                                                }
                                                // enemy charge
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                    charged = true;
                                                }

                                            }
                                            else
                                            {
                                                // cut player atk
                                                if (RNG7 >= 4)
                                                {
                                                    Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                    knight.Status = true;
                                                    if (turnsPlayer == 0)
                                                    {
                                                        turnsPlayer = 3;
                                                    }
                                                }
                                                // boost enemy atk
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                    overlord.Status = true;
                                                    if (turnsGoon == 0)
                                                    {
                                                        turnsGoon = 3;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    turnsGoon--;
                                }
                                else
                                {
                                    if (charged == true)
                                    {
                                        Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                        knight.Health -= overlord.GoonSpecial;
                                        charged = false;
                                    }
                                    else
                                    {
                                        if (RNG2 >= 5)
                                        {
                                            if (RNG3 >= 4)
                                            {
                                                Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                knight.Health -= overlord.GoonAttack1;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                knight.Health -= overlord.GoonAttack2;
                                                overlord.GoonHealth += overlord.GoonAttack2;
                                            }
                                        }
                                        else
                                        {
                                            if (RNG4 >= 3)
                                            {
                                                int combo = 0;
                                                if (RNG5 >= 3)
                                                {
                                                    Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    if (RNG6 >= 0)
                                                    {
                                                        Console.Write("One! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 2)
                                                    {
                                                        Console.Write("Two! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 4)
                                                    {
                                                        Console.Write("Three! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 > 6)
                                                    {
                                                        Console.Write("Four! ");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (RNG6 >= 8)
                                                    {
                                                        Console.Write("Five!");
                                                        System.Threading.Thread.Sleep(1000);
                                                        combo++;
                                                    }
                                                    if (combo == 1)
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} time");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"\nThe attack hit {combo} times");
                                                    }
                                                    knight.Health -= overlord.GoonAttack3 * combo;

                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                    charged = true;
                                                }

                                            }
                                            else
                                            {
                                                if (RNG7 >= 4)
                                                {
                                                    Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                    knight.Status = true;
                                                    if (turnsPlayer == 0)
                                                    {
                                                        turnsPlayer = 3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                    overlord.Status = true;
                                                    if (turnsGoon == 0)
                                                    {
                                                        turnsGoon = 3;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (knight.Status == true)
                                {
                                    turnsPlayer--;
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
                        //items                        
                        string[] Items = new string[] { $"{ potion.Name }", $"{ bigpotion.Name }", $"{ megapotion.Name }", $"{potionMax.Name}", $"{ holywater.Name }", $"{ dagger.Name }", $"{ axe.Name }", $"{bomb.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            //potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    if (overlord.Status == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1 * 2;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }    
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{overlord.Name} watches for your next move.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (overlord.Status == true)
                                                {
                                                    turnsGoon--;
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsPlayer--;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
                                //big potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    if (overlord.Status == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1 * 2;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{overlord.Name} watches for your next move.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (overlord.Status == true)
                                                {
                                                    turnsGoon--;
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsPlayer--;
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                //mega potion
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{megapotion.Description} {megapotion.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (megapotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {megapotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += megapotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                megapotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    if (overlord.Status == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1 * 2;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{overlord.Name} watches for your next move.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (overlord.Status == true)
                                                {
                                                    turnsGoon--;
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsPlayer--;
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {megapotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {megapotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            //max potion
                            case 3:
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{potionMax.Description} {potionMax.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potionMax.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potionMax.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health = knight.MaxHealth;
                                                potionMax.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    if (overlord.Status == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1 * 2;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine($"{overlord.Name} caught you off guard!");
                                                        knight.Health -= overlord.GoonAttack1;
                                                        System.Threading.Thread.Sleep(2000);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{overlord.Name} watches for your next move.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (overlord.Status == true)
                                                {
                                                    turnsGoon--;
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsPlayer--;
                                                }
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potionMax.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potionMax.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 4:
                                //holy water
                                string[] YesNo4 = new string[] { "Yes" };
                                int userYesNo4 = Utility.ShowUserOptionsAndGetAValidResponse($"{holywater.Description} {holywater.Inventory} left. Use?", $"{YesNo4.Length + 1}) No", YesNo4);
                                switch (userYesNo4)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (holywater.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {holywater.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            overlord.GoonHealth -= holywater.Value;
                                            holywater.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsPlayer--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (overlord.Status == true)
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial * 2;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1 * 2;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers witht the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2 * 2;
                                                            overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 5)
                                                        {
                                                            //multi hit
                                                            int combo = 0;
                                                            int totalDMG = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                totalDMG = overlord.GoonAttack3 * combo;
                                                                knight.Health -= totalDMG * 2;

                                                            }
                                                            // enemy charge
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            // cut player atk
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            // boost enemy atk
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                turnsGoon--;
                                            }
                                            else
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers witht the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2;
                                                            overlord.GoonHealth += overlord.GoonAttack2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 5)
                                                        {
                                                            int combo = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                knight.Health -= overlord.GoonAttack3 * combo;

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {holywater.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 5:
                                //dagger
                                string[] YesNo5 = new string[] { "Yes" };
                                int userYesNo5 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo5.Length + 1}) No", YesNo5);
                                switch (userYesNo5)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            overlord.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsPlayer--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (overlord.Status == true)
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial * 2;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1 * 2;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2 * 2;
                                                            overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 5)
                                                        {
                                                            //multi hit
                                                            int combo = 0;
                                                            int totalDMG = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                totalDMG = overlord.GoonAttack3 * combo;
                                                                knight.Health -= totalDMG * 2;

                                                            }
                                                            // enemy charge
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            // cut player atk
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            // boost enemy atk
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                turnsGoon--;
                                            }
                                            else
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2;
                                                            overlord.GoonHealth += overlord.GoonAttack2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 5)
                                                        {
                                                            int combo = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                knight.Health -= overlord.GoonAttack3 * combo;

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 6:
                                //axe
                                string[] YesNo6 = new string[] { "Yes" };
                                int userYesNo6 = Utility.ShowUserOptionsAndGetAValidResponse($"{axe.Description} {axe.Inventory} left. Use?", $"{YesNo6.Length + 1}) No", YesNo6);
                                switch (userYesNo6)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (axe.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {axe.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            overlord.GoonHealth -= axe.Value;
                                            axe.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsPlayer--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (overlord.Status == true)
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial * 2;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1 * 2;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2 * 2;
                                                            overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 5)
                                                        {
                                                            //multi hit
                                                            int combo = 0;
                                                            int totalDMG = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                totalDMG = overlord.GoonAttack3 * combo;
                                                                knight.Health -= totalDMG * 2;

                                                            }
                                                            // enemy charge
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            // cut player atk
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            // boost enemy atk
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                turnsGoon--;
                                            }
                                            else
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2;
                                                            overlord.GoonHealth += overlord.GoonAttack2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 3)
                                                        {
                                                            int combo = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                knight.Health -= overlord.GoonAttack3 * combo;

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {axe.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 7:
                                //bomb
                                string[] YesNo7 = new string[] { "Yes" };
                                int userYesNo7 = Utility.ShowUserOptionsAndGetAValidResponse($"{bomb.Description} {bomb.Inventory} left. Use?", $"{YesNo7.Length + 1}) No", YesNo7);
                                switch (userYesNo7)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bomb.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {bomb.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            overlord.GoonHealth -= bomb.Value;
                                            bomb.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsPlayer--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (overlord.Status == true)
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial * 2;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1 * 2;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2 * 2;
                                                            overlord.GoonHealth += overlord.GoonAttack2 * 2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 5)
                                                        {
                                                            //multi hit
                                                            int combo = 0;
                                                            int totalDMG = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                totalDMG = overlord.GoonAttack3 * combo;
                                                                knight.Health -= totalDMG * 2;

                                                            }
                                                            // enemy charge
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            // cut player atk
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            // boost enemy atk
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                turnsGoon--;
                                            }
                                            else
                                            {
                                                if (charged == true)
                                                {
                                                    Console.WriteLine($"{overlord.Name} unleashes the highest of dark power!");
                                                    knight.Health -= overlord.GoonSpecial;
                                                    charged = false;
                                                }
                                                else
                                                {
                                                    if (RNG2 >= 5)
                                                    {
                                                        if (RNG3 >= 4)
                                                        {
                                                            Console.WriteLine($"{overlord.Name} attacked with dark magic!");
                                                            knight.Health -= overlord.GoonAttack1;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"{overlord.Name} pulls the energy from your body!");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.WriteLine($"{overlord.Name} recovers with the stolen energy!");
                                                            knight.Health -= overlord.GoonAttack2;
                                                            overlord.GoonHealth += overlord.GoonAttack2;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (RNG4 >= 3)
                                                        {
                                                            int combo = 0;
                                                            if (RNG5 >= 3)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} traps {Player.CharacterName} in a dark vortex!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                if (RNG6 >= 0)
                                                                {
                                                                    Console.Write("One! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 2)
                                                                {
                                                                    Console.Write("Two! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 4)
                                                                {
                                                                    Console.Write("Three! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 > 6)
                                                                {
                                                                    Console.Write("Four! ");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (RNG6 >= 8)
                                                                {
                                                                    Console.Write("Five!");
                                                                    System.Threading.Thread.Sleep(1000);
                                                                    combo++;
                                                                }
                                                                if (combo == 1)
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} time");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"\nThe attack hit {combo} times");
                                                                }
                                                                knight.Health -= overlord.GoonAttack3 * combo;

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} is gathering large amounts of dark energy!");
                                                                charged = true;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            if (RNG7 >= 4)
                                                            {
                                                                Console.WriteLine($"{overlord.Name} places a curse on {Player.CharacterName}!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{Player.CharacterName}'s attack is cut in half!");
                                                                knight.Status = true;
                                                                if (turnsPlayer == 0)
                                                                {
                                                                    turnsPlayer = 3;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{overlord.Name} powered themselves up!");
                                                                System.Threading.Thread.Sleep(2000);
                                                                Console.WriteLine($"{overlord.Name}'s attack is doubled!");
                                                                overlord.Status = true;
                                                                if (turnsGoon == 0)
                                                                {
                                                                    turnsGoon = 3;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bomb.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            Overlord.Stop();
            knight.Status = false;
            
            PreDragon();

            //dragon fight
            SoundPlayer Dragon = new SoundPlayer("Dirty Beauty.wav");
            Dragon.Load();
            Dragon.PlayLooping();
            ASCII.ASCIIDragonLoad();
            System.Threading.Thread.Sleep(4000);
            Console.Clear();

            Goon dragon = new Goon
            {
                Name = "Fell Dragon",
                GoonHealth = 1500,
                GoonMaxHP = 1500,
                GoonAttack1 = 30,
                GoonAttack2 = 50,
                GoonAttack3 = 20,
                GoonSpecial = 150,
                Status = false
                //poison player
                //reduce player atk
            };
            int poisonDMG = 20;
            bool poisoned = false;
            int turnsATK = 3;
            int turnsPSN = 4;
            if (knight.Health <= 0)
            {
                knight.Health += 50;
            }

            Console.WindowHeight = 40;
            while (dragon.GoonHealth > 0)
            {
                if (knight.Health <= 0)
                {
                    Console.Clear();
                    GameOver(Save, knight, potion, bigpotion, megapotion, potionMax, holywater, dagger, axe, bomb);
                }
                if (knight.Defend == 0)
                {
                    knight.Defend = 3;
                }
                if (turnsATK == 0)
                {
                    knight.Status = false;
                }
                if (turnsPSN == 0)
                {
                    poisoned = false;
                }
                Divider();
                dragon.GoonDisplay();
                if (dragon.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    CHARGED");
                    Console.ResetColor();
                }
                ASCII.ASCIIDragon();
                knight.KnightStats();
                if (knight.Status == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ATK/2:  ");
                    Console.ResetColor();
                    Console.Write($"{turnsATK}");
                }
                if (poisoned == true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("    POISON:  ");
                    Console.ResetColor();
                    Console.Write($"{turnsPSN}");
                }
                Divider();

                string[] Commands = new string[] { "ATTACK", "DEFEND", "ITEM" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {dragon.Name} stands before you.", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                int RNG2 = Utility.GetRandomNumber();
                int RNG3 = Utility.GetRandomNumber();
                int RNG4 = Utility.GetRandomNumber();
                int RNG5 = Utility.GetRandomNumber();
                int RNG6 = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;

                    case 0:
                        //attack
                        if (knight.Status == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} attacks!");
                            Console.ResetColor();
                            dragon.GoonHealth -= knight.Damage / 2;
                            turnsATK--;
                        }
                        else
                        {
                            if (RNG > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacks!");
                                Console.ResetColor();
                                dragon.GoonHealth -= knight.Damage;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} attacked with strength!");
                                Console.ResetColor();
                                dragon.GoonHealth -= (knight.Damage * 2);
                            }
                        }

                        System.Threading.Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        //enemy attack
                        if (dragon.Status == true)
                        {
                            Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                            knight.Health -= dragon.GoonSpecial;
                            dragon.Status = false;
                        }
                        else if (RNG >= 5)
                        {
                            if (RNG2 >= 4)
                            {
                                Console.WriteLine($"The {dragon.Name} slams its claw");
                                knight.Health -= dragon.GoonAttack1;
                            }
                            else
                            {
                                Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                knight.Health -= dragon.GoonAttack2;
                            }
                        }
                        else if (RNG3 >= 5)
                        {
                            int combo = 0;
                            Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                            System.Threading.Thread.Sleep(2000);
                            if(RNG4 >= 0)
                            {
                                Console.Write("One! ");
                                System.Threading.Thread.Sleep(1000);
                                combo++;
                            }
                            if (RNG4 > 2)
                            {
                                Console.Write("Two! ");
                                System.Threading.Thread.Sleep(1000);
                                combo++;
                            }
                            if (RNG4 > 4)
                            {
                                Console.Write("Three! ");
                                System.Threading.Thread.Sleep(1000);
                                combo++;
                            }
                            if (RNG4 > 6)
                            {
                                Console.Write("Four! ");
                                System.Threading.Thread.Sleep(1000);
                                combo++;
                            }
                            if (RNG4 >= 8)
                            {
                                Console.Write("Five!");
                                System.Threading.Thread.Sleep(1000);
                                combo++;
                            }
                            if (combo == 1)
                            {
                                Console.WriteLine($"\nThe attack hit {combo} time!");
                            }
                            else
                            {
                                Console.WriteLine($"\nThe attack hit {combo} times!");
                            }
                            knight.Health -= dragon.GoonAttack3 * combo;
                        }
                        else if (RNG5 >= 5)
                        {
                            Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                            dragon.Status = true;
                        }
                        else
                        {
                            if (RNG6 >= 6)
                            {
                                Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                knight.Status = true;
                                if (turnsATK == 0)
                                {
                                    turnsATK = 3;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                poisoned = true;
                                if (turnsPSN == 0)
                                {
                                    turnsPSN = 4;
                                }
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        if (poisoned == true)
                        {
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                            knight.Health -= poisonDMG;
                            turnsPSN--;
                        }

                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case 1:
                        //defend
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} used their shield!");
                        Console.ResetColor();
                        if (knight.Defend == 3)
                        {
                            if (knight.Health < knight.MaxHealth)
                            {
                                knight.Health += knight.DefHeal;
                                if (knight.Health > knight.MaxHealth)
                                {
                                    knight.Health = knight.MaxHealth;
                                }
                            }
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{dragon.Name} attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            knight.Defend--;
                            dragon.Status = false;
                            if (knight.Status == true)
                            {
                                turnsATK--;
                            }
                        }
                        else if (knight.Defend == 2)
                        {
                            if (RNG >= 3)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{dragon.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                knight.Defend--;
                                dragon.Status = false;
                                if (knight.Status == true)
                                {
                                    turnsATK--;
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{dragon.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                //enemy atk
                                if (dragon.Status == true)
                                {
                                    Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                                    knight.Health -= dragon.GoonSpecial;
                                    dragon.Status = false;
                                }
                                else if (RNG >= 5)
                                {
                                    if (RNG2 >= 4)
                                    {
                                        Console.WriteLine($"The {dragon.Name} slams its claw");
                                        knight.Health -= dragon.GoonAttack1;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                        knight.Health -= dragon.GoonAttack2;
                                    }
                                }
                                else if (RNG3 >= 5)
                                {
                                    int combo = 0;
                                    Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                                    System.Threading.Thread.Sleep(2000);
                                    if (RNG4 >= 0)
                                    {
                                        Console.Write("One! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 > 2)
                                    {
                                        Console.Write("Two! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 > 4)
                                    {
                                        Console.Write("Three! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 > 6)
                                    {
                                        Console.Write("Four! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 >= 8)
                                    {
                                        Console.Write("Five!");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (combo == 1)
                                    {
                                        Console.WriteLine($"\nThe attack hit {combo} time!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\nThe attack hit {combo} times!");
                                    }
                                    knight.Health -= dragon.GoonAttack3 * combo;
                                }
                                else if (RNG5 >= 5)
                                {
                                    Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                                    dragon.Status = true;
                                }
                                else
                                {
                                    if (RNG6 >= 6)
                                    {
                                        Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                        knight.Status = true;
                                        if (turnsATK == 0)
                                        {
                                            turnsATK = 3;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                        poisoned = true;
                                        if (turnsPSN == 0)
                                        {
                                            turnsPSN = 4;
                                        }
                                    }
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                            }
                            if (knight.Status == true)
                            {
                                turnsATK--;
                            }
                        }
                        else if (knight.Defend == 1)
                        {
                            if (RNG >= 7)
                            {
                                if (knight.Health < knight.MaxHealth)
                                {
                                    knight.Health += knight.DefHeal;
                                    if (knight.Health > knight.MaxHealth)
                                    {
                                        knight.Health = knight.MaxHealth;
                                    }
                                }

                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{dragon.Name} attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Player.CharacterName} shielded the attacked!");
                                Console.ResetColor();
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                knight.Defend--;
                                dragon.Status = false;
                                if (knight.Status == true)
                                {
                                    turnsATK--;
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{dragon.Name} got pass the shield!");
                                System.Threading.Thread.Sleep(2000);
                                //enemy attack
                                if (dragon.Status == true)
                                {
                                    Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                                    knight.Health -= dragon.GoonSpecial;
                                    dragon.Status = false;
                                }
                                else if (RNG >= 5)
                                {
                                    if (RNG2 >= 4)
                                    {
                                        Console.WriteLine($"The {dragon.Name} slams its claw");
                                        knight.Health -= dragon.GoonAttack1;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                        knight.Health -= dragon.GoonAttack2;
                                    }
                                }
                                else if (RNG3 >= 5)
                                {
                                    int combo = 0;
                                    Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                                    System.Threading.Thread.Sleep(2000);
                                    if (RNG4 >= 0)
                                    {
                                        Console.Write("One! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 > 2)
                                    {
                                        Console.Write("Two! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 > 4)
                                    {
                                        Console.Write("Three! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 > 6)
                                    {
                                        Console.Write("Four! ");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (RNG4 >= 8)
                                    {
                                        Console.Write("Five!");
                                        System.Threading.Thread.Sleep(1000);
                                        combo++;
                                    }
                                    if (combo == 1)
                                    {
                                        Console.WriteLine($"\nThe attack hit {combo} time!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\nThe attack hit {combo} times!");
                                    }
                                    knight.Health -= dragon.GoonAttack3 * combo;
                                }
                                else if (RNG5 >= 5)
                                {
                                    Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                                    dragon.Status = true;
                                }
                                else
                                {
                                    if (RNG6 >= 6)
                                    {
                                        Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                        knight.Status = true;
                                        if (turnsATK == 0)
                                        {
                                            turnsATK = 3;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                        System.Threading.Thread.Sleep(2000);
                                        Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                        poisoned = true;
                                        if (turnsPSN == 0)
                                        {
                                            turnsPSN = 4;
                                        }
                                    }
                                }
                               
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                            }
                            if (knight.Status == true)
                            {
                                turnsATK--;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        if (poisoned == true)
                        {
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                            knight.Health -= poisonDMG;
                            turnsPSN--;
                            System.Threading.Thread.Sleep(2000);
                        }
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    case 2:
                        //items                        
                        string[] Items = new string[] { $"{ potion.Name }", $"{ bigpotion.Name }", $"{ megapotion.Name }", $"{potionMax.Name}", $"{ holywater.Name }", $"{ dagger.Name }", $"{ axe.Name }", $"{bomb.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Inventory", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            //potion
                            case 0:
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{potion.Description} {potion.Inventory} left. Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += potion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                potion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {dragon.Name} caught you off guard!");
                                                    knight.Health -= dragon.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {dragon.Name} looks at you angrly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsATK--;
                                                }
                                                if (poisoned == true)
                                                {
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                    knight.Health -= poisonDMG;
                                                    turnsPSN--;
                                                }
                                                Console.ResetColor();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;
                            case 1:
                                //big potion
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{bigpotion.Description} {bigpotion.Inventory} left. Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bigpotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {bigpotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += bigpotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                bigpotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {dragon.Name} caught you off guard!");
                                                    knight.Health -= dragon.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"The {dragon.Name} looks you angrly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsATK--;
                                                }
                                                if (poisoned == true)
                                                {
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                    knight.Health -= poisonDMG;
                                                    turnsPSN--;
                                                }
                                                Console.ResetColor();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {bigpotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bigpotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                //mega potion
                                string[] YesNo2 = new string[] { "Yes" };
                                int userYesNo2 = Utility.ShowUserOptionsAndGetAValidResponse($"{megapotion.Description} {megapotion.Inventory} left. Use?", $"{YesNo2.Length + 1}) No", YesNo2);
                                switch (userYesNo2)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (megapotion.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {megapotion.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health += megapotion.Value;
                                                if (knight.Health > knight.MaxHealth)
                                                {
                                                    knight.Health = knight.MaxHealth;
                                                }
                                                megapotion.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{dragon.Name} caught you off guard!");
                                                    knight.Health -= dragon.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{dragon.Name} looks at you angrly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsATK--;
                                                }
                                                if (poisoned == true)
                                                {
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                    knight.Health -= poisonDMG;
                                                    turnsPSN--;
                                                }
                                                Console.ResetColor();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {megapotion.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {megapotion.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            //max potion
                            case 3:
                                string[] YesNo3 = new string[] { "Yes" };
                                int userYesNo3 = Utility.ShowUserOptionsAndGetAValidResponse($"{potionMax.Description} {potionMax.Inventory} left. Use?", $"{YesNo3.Length + 1}) No", YesNo3);
                                switch (userYesNo3)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (potionMax.Inventory > 0)
                                        {
                                            if (knight.Health < knight.MaxHealth)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used a {potionMax.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                knight.Health = knight.MaxHealth;
                                                potionMax.Inventory--;
                                                if (RNG > 9)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{dragon.Name} caught you off guard!");
                                                    knight.Health -= dragon.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"{dragon.Name} looks at you angrly.");
                                                    Console.ResetColor();
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                if (knight.Status == true)
                                                {
                                                    turnsATK--;
                                                }
                                                if (poisoned == true)
                                                {
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                    knight.Health -= poisonDMG;
                                                    turnsPSN--;
                                                }
                                                Console.ResetColor();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use a {potionMax.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }

                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {potionMax.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 4:
                                //holy water
                                string[] YesNo4 = new string[] { "Yes" };
                                int userYesNo4 = Utility.ShowUserOptionsAndGetAValidResponse($"{holywater.Description} {holywater.Inventory} left. Use?", $"{YesNo4.Length + 1}) No", YesNo4);
                                switch (userYesNo4)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (holywater.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {holywater.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            dragon.GoonHealth -= holywater.Value;
                                            holywater.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsATK--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            //enemy attack
                                            if (dragon.Status == true)
                                            {
                                                Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                                                knight.Health -= dragon.GoonSpecial;
                                                dragon.Status = false;
                                            }
                                            else if (RNG >= 5)
                                            {
                                                if (RNG2 >= 4)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} slams its claw");
                                                    knight.Health -= dragon.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                                    knight.Health -= dragon.GoonAttack2;
                                                }
                                            }
                                            else if (RNG3 >= 5)
                                            {
                                                int combo = 0;
                                                Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG4 >= 0)
                                                {
                                                    Console.Write("One! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 2)
                                                {
                                                    Console.Write("Two! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 4)
                                                {
                                                    Console.Write("Three! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 6)
                                                {
                                                    Console.Write("Four! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 >= 8)
                                                {
                                                    Console.Write("Five!");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (combo == 1)
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} time!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} times!");
                                                }
                                                knight.Health -= dragon.GoonAttack3 * combo;
                                            }
                                            else if (RNG5 >= 5)
                                            {
                                                Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                                                dragon.Status = true;
                                            }
                                            else
                                            {
                                                if (RNG6 >= 6)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                                    knight.Status = true;
                                                    if (turnsATK == 0)
                                                    {
                                                        turnsATK = 3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                                    poisoned = true;
                                                    if (turnsPSN == 0)
                                                    {
                                                        turnsPSN = 4;
                                                    }
                                                }
                                            }

                                            if (poisoned == true)
                                            {
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                knight.Health -= poisonDMG;
                                                turnsPSN--;
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {holywater.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 5:
                                //dagger
                                string[] YesNo5 = new string[] { "Yes" };
                                int userYesNo5 = Utility.ShowUserOptionsAndGetAValidResponse($"{dagger.Description} {dagger.Inventory} left. Use?", $"{YesNo5.Length + 1}) No", YesNo5);
                                switch (userYesNo5)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (dagger.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {dagger.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            dragon.GoonHealth -= dagger.Value;
                                            dagger.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsATK--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            //enemy attack
                                            if (dragon.Status == true)
                                            {
                                                Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                                                knight.Health -= dragon.GoonSpecial;
                                                dragon.Status = false;
                                            }
                                            else if (RNG >= 5)
                                            {
                                                if (RNG2 >= 4)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} slams its claw");
                                                    knight.Health -= dragon.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                                    knight.Health -= dragon.GoonAttack2;
                                                }
                                            }
                                            else if (RNG3 >= 5)
                                            {
                                                int combo = 0;
                                                Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG4 >= 0)
                                                {
                                                    Console.Write("One! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 2)
                                                {
                                                    Console.Write("Two! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 4)
                                                {
                                                    Console.Write("Three! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 6)
                                                {
                                                    Console.Write("Four! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 >= 8)
                                                {
                                                    Console.Write("Five!");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (combo == 1)
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} time!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} times!");
                                                }
                                                knight.Health -= dragon.GoonAttack3 * combo;
                                            }
                                            else if (RNG5 >= 5)
                                            {
                                                Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                                                dragon.Status = true;
                                            }
                                            else
                                            {
                                                if (RNG6 >= 6)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                                    knight.Status = true;
                                                    if (turnsATK == 0)
                                                    {
                                                        turnsATK = 3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                                    poisoned = true;
                                                    if (turnsPSN == 0)
                                                    {
                                                        turnsPSN = 4;
                                                    }
                                                }
                                            }

                                            if (poisoned == true)
                                            {
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                knight.Health -= poisonDMG;
                                                turnsPSN--;
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {dagger.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 6:
                                //axe
                                string[] YesNo6 = new string[] { "Yes" };
                                int userYesNo6 = Utility.ShowUserOptionsAndGetAValidResponse($"{axe.Description} {axe.Inventory} left. Use?", $"{YesNo6.Length + 1}) No", YesNo6);
                                switch (userYesNo6)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (axe.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {axe.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            dragon.GoonHealth -= axe.Value;
                                            axe.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsATK--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            //enemy attack
                                            if (dragon.Status == true)
                                            {
                                                Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                                                knight.Health -= dragon.GoonSpecial;
                                                dragon.Status = false;
                                            }
                                            else if (RNG >= 5)
                                            {
                                                if (RNG2 >= 4)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} slams its claw");
                                                    knight.Health -= dragon.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                                    knight.Health -= dragon.GoonAttack2;
                                                }
                                            }
                                            else if (RNG3 >= 5)
                                            {
                                                int combo = 0;
                                                Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG4 >= 0)
                                                {
                                                    Console.Write("One! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 2)
                                                {
                                                    Console.Write("Two! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 4)
                                                {
                                                    Console.Write("Three! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 6)
                                                {
                                                    Console.Write("Four! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 >= 8)
                                                {
                                                    Console.Write("Five!");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (combo == 1)
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} time!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} times!");
                                                }
                                                knight.Health -= dragon.GoonAttack3 * combo;
                                            }
                                            else if (RNG5 >= 5)
                                            {
                                                Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                                                dragon.Status = true;
                                            }
                                            else
                                            {
                                                if (RNG6 >= 6)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                                    knight.Status = true;
                                                    if (turnsATK == 0)
                                                    {
                                                        turnsATK = 3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                                    poisoned = true;
                                                    if (turnsPSN == 0)
                                                    {
                                                        turnsPSN = 4;
                                                    }
                                                }
                                            }

                                            if (poisoned == true)
                                            {
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                knight.Health -= poisonDMG;
                                                turnsPSN--;
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {axe.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                            case 7:
                                //bomb
                                string[] YesNo7 = new string[] { "Yes" };
                                int userYesNo7 = Utility.ShowUserOptionsAndGetAValidResponse($"{bomb.Description} {bomb.Inventory} left. Use?", $"{YesNo7.Length + 1}) No", YesNo7);
                                switch (userYesNo7)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (bomb.Inventory > 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used a {bomb.Name}!");
                                            Console.ResetColor();
                                            System.Threading.Thread.Sleep(2000);
                                            dragon.GoonHealth -= bomb.Value;
                                            bomb.Inventory--;
                                            if (knight.Status == true)
                                            {
                                                turnsATK--;
                                            }

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            //enemy attack
                                            if (dragon.Status == true)
                                            {
                                                Console.WriteLine($"The {dragon.Name} lets out a giant ball of fire!");
                                                knight.Health -= dragon.GoonSpecial;
                                                dragon.Status = false;
                                            }
                                            else if (RNG >= 5)
                                            {
                                                if (RNG2 >= 4)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} slams its claw");
                                                    knight.Health -= dragon.GoonAttack1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} sweeps with its giant wings");
                                                    knight.Health -= dragon.GoonAttack2;
                                                }
                                            }
                                            else if (RNG3 >= 5)
                                            {
                                                int combo = 0;
                                                Console.WriteLine($"The {dragon.Name} breathes fire on {Player.CharacterName}!");
                                                System.Threading.Thread.Sleep(2000);
                                                if (RNG4 >= 0)
                                                {
                                                    Console.Write("One! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 2)
                                                {
                                                    Console.Write("Two! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 4)
                                                {
                                                    Console.Write("Three! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 > 6)
                                                {
                                                    Console.Write("Four! ");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (RNG4 >= 8)
                                                {
                                                    Console.Write("Five!");
                                                    System.Threading.Thread.Sleep(1000);
                                                    combo++;
                                                }
                                                if (combo == 1)
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} time!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"\nThe attack hit {combo} times!");
                                                }
                                                knight.Health -= dragon.GoonAttack3 * combo;
                                            }
                                            else if (RNG5 >= 5)
                                            {
                                                Console.WriteLine($"The {dragon.Name} is collecting its breath!");
                                                dragon.Status = true;
                                            }
                                            else
                                            {
                                                if (RNG6 >= 6)
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a black haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName}'s attack is cut to half!");
                                                    knight.Status = true;
                                                    if (turnsATK == 0)
                                                    {
                                                        turnsATK = 3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {dragon.Name} covers the area in a purple haze...");
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine($"{Player.CharacterName} is poisoned!");
                                                    poisoned = true;
                                                    if (turnsPSN == 0)
                                                    {
                                                        turnsPSN = 4;
                                                    }
                                                }
                                            }

                                            if (poisoned == true)
                                            {
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine($"{Player.CharacterName} is hurting from the poison!");
                                                knight.Health -= poisonDMG;
                                                turnsPSN--;
                                            }
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ResetColor();
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have any {bomb.Name}");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;

                        }

                        break;

                }
            }
            Dragon.Stop();

            DragonDefeat();
            Ending();
        }
        public void Ending()
        {
            SoundPlayer ending = new SoundPlayer("Friends and Sun.wav");
            ending.Play();
            string image = @"
                                                             ###
                                                            #####
                                                            ######
                                                           #######
                                                          ### #####
                                                          ### #####
                                                          #########
                                                          ###### ##
                                                          ###### ###
                                                         ###########
                                                        #### #######
                                                        #### #######
                                                       ##############
                                                       ##############
 ______________________________________________________##############";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(image);
            Console.ResetColor();
            Divider();
            Utility.Typewrite("Just as it started, ");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite("'s journey came to an end.\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("After using the last of their strength to summon the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("Fell Dragon");
            Console.ResetColor();
            Utility.Typewrite(", ");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("The Overlord\n");
            Console.ResetColor();
            Utility.Typewrite("collapsed and their tyranny came to an end. ");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("The land,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" now free from the evils\nof ");
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.Typewrite("The Overlord");
            Console.ResetColor();
            Utility.Typewrite(",");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" will have peace return once again.\n");
            System.Threading.Thread.Sleep(1000);
            Player.Name();
            Utility.Typewrite(" will also return;");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" return to their journey of wandering the various\nlands in search for more people in need.");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" This was not just an ending,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("\nbut a new beginning for ");
            Player.Name();
            Console.Write(".\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("Where will they go after?");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" Who knows... this is just one of their many stories,\n");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite("and like any story,");
            System.Threading.Thread.Sleep(1000);
            Utility.Typewrite(" there will always be.");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.WindowHeight = 40;
            Console.WindowWidth = 90;
            string THEEND = @"                                                        
  ****           *      *****    **         ***** **    
 *  *************    ******  *  **** *   ******  **** * 
*     *********     **   *  *   *****   **   *  * ****  
*     *  *         *    *  *    * *    *    *  *   **   
 **  *  **             *  *     *          *  *         
    *  ***            ** **     *         ** **         
   **   **            ** **     *         ** **         
   **   **            ** ********         ** ******     
   **   **            ** **     *         ** *****      
   **   **            ** **     **        ** **         
    **  **            *  **     **        *  **         
     ** *      *         *       **          *          
      ***     *      ****        **      ****         * 
       *******      *  *****      **    *  ***********  
         ***       *     **            *     ******     
                   *                   *                
                    **                  **              
                                                          
                             ***** **         ***** *     **          ***** **    
                          ******  **** *   ******  **    **** *    ******  ***    
                         **   *  * ****   **   *  * **    ****   **    *  * ***   
                        *    *  *   **   *    *  *  **    * *   *     *  *   ***  
                            *  *             *  *    **   *          *  *     *** 
                           ** **            ** **    **   *         ** **      ** 
                           ** **            ** **     **  *         ** **      ** 
                           ** ******        ** **     **  *         ** **      ** 
                           ** *****         ** **      ** *         ** **      ** 
                           ** **            ** **      ** *         ** **      ** 
                           *  **            *  **       ***         *  **      ** 
                              *                *        ***            *       *  
                          ****         *   ****          **       *****       *   
                         *  ***********   *  *****               *   *********    
                        *     ******     *     **               *       ****      
                        *                *                      *                 
                         **               **                     **               ";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.TypewriteFast(THEEND);
            Utility.Typewrite(@"

Press ENTER to end your journey.");
        }
    }

    //unfinished
    class MageGame
    {
        public string input;
        static int choice;
        public string Title { get; set; }
        public static void Divider()
        {
            Console.WriteLine(@"
============================================================================");
        }
        public void GameOver()
        {
            string GameOver = @"           
          _____          __  __ ______    ______      ________ _____  
         / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
        | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
        | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
        | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
         \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\";

            SoundPlayer Failure = new SoundPlayer("Failure.wav");
            Failure.Play();
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.TypewriteFast(GameOver);
            Console.ResetColor();
            Console.Write(@"
========================== ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //                       Continue?         
            Utility.Typewrite("      Continue?         ");
            Console.ResetColor();
            Console.Write("==========================");
            Utility.Typewrite("\n1) Yes     2)No\n");

            input = Console.ReadLine();
            if (int.TryParse(input, out choice)) 
            {
                if (choice == 1)
                {
                    Console.Clear();
                    Part1();
                }
                else
                {
                    Utility.Typewrite($"Thank you for playing ");
                    Player.Name();
                    Utility.Typewrite($"!");
                    System.Threading.Thread.Sleep(4000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Utility.Typewrite($"Thank you for playing ");
                Player.Name();
                Utility.Typewrite($"!");
                System.Threading.Thread.Sleep(4000);
                Environment.Exit(0);
            }

        }
        public void Part1()
        {
            Item FireMagic = new Item();
            FireMagic.Name = "FIRE";
            FireMagic.Description = "Basic fire spell. Cost 20 MANA";
            FireMagic.Value = 20;
            FireMagic.Inventory = 20;

            Item Heal = new Item();
            Heal.Name = "HEALING";
            Heal.Description = "Heals user by 20 HP. Cost 10 MANA.";
            Heal.Value = 20;
            Heal.Inventory = 10;

            Player mage = new Player();
            mage.Health = 100;
            mage.Damage = 10;
            mage.Magic = 100;

            Goon goblin = new Goon();
            goblin.Name = "Crazy Goblin";
            goblin.GoonHealth = 100;
            goblin.GoonAttack1 = 10;
            goblin.GoonSpecial = 20;

            Titles.LevelOneTitle();
            //music loop
            SoundPlayer Battle1 = new SoundPlayer("Strike Attack.wav");
            Battle1.Load();
            Battle1.PlayLooping();
            while (goblin.GoonHealth > 0)
            {
                if (mage.Health <= 0)
                {
                    Console.Clear();
                    GameOver();
                }

                Divider();
                goblin.GoonDisplay();
                Divider();
                mage.MageStats();
                Divider();

                string[] Commands = new string[] { "ATTACK", "MAGIC", "CONCENTRATE" };
                int userChoice = Utility.ShowUserOptionsAndGetAValidResponse($"The {goblin.Name}! attacks!", "Choose a command!", Commands);
                int RNG = Utility.GetRandomNumber();
                switch (userChoice)
                {
                    default:
                        Console.Clear();
                        break;
                    case 0:
//attack
                        goblin.GoonHealth = goblin.GoonHealth - mage.Damage;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} attacks!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000);

                        Console.ForegroundColor = ConsoleColor.Red;
                        if (RNG > 5)
                        {
                            Console.WriteLine($"The {goblin.Name} attacks!");
                            mage.Health = mage.Health - goblin.GoonAttack1;
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                            mage.Health = mage.Health - goblin.GoonSpecial;
                            System.Threading.Thread.Sleep(2000);
                        }
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    case 1:
//magic
                        string[] Items = new string[] { $"{Heal.Name}", $"{FireMagic.Name}" };
                        int userItem = Utility.ShowUserOptionsAndGetAValidResponse($"{Player.CharacterName}'s Spells", $"{Items.Length + 1}) Go back", Items);
                        switch (userItem)
                        {
                            default:
                                Console.Clear();
                                break;
                            case 0:
//heal
                                string[] YesNo = new string[] { "Yes" };
                                int userYesNo = Utility.ShowUserOptionsAndGetAValidResponse($"{Heal.Description} Use?", $"{YesNo.Length + 1}) No", YesNo);
                                switch (userYesNo)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (mage.Magic > 10)
                                        {
                                            if (mage.Health < 100)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"{Player.CharacterName} used {Heal.Name}!");
                                                Console.ResetColor();
                                                System.Threading.Thread.Sleep(2000);
                                                mage.Health = mage.Health + Heal.Value;
                                                mage.Magic = mage.Magic - Heal.Inventory;
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                if (RNG > 9)
                                                {

                                                    Console.WriteLine($"The {goblin.Name} caught you off guard!");
                                                    mage.Health = mage.Health - goblin.GoonAttack1;
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"The {goblin.Name} is mocking {Player.CharacterName}!");
                                                    System.Threading.Thread.Sleep(2000);
                                                }
                                                Console.ResetColor();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cant use {Heal.Name} right now!");
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                        }
                                        else
                                        { 
                                          Console.WriteLine($"Sorry you don't have enough ");
                                          Console.ForegroundColor = ConsoleColor.Green;
                                          Console.Write("MANA");
                                          Console.ResetColor();
                                          Console.Write("!");
                                          System.Threading.Thread.Sleep(2000);
                                           Console.Clear(); 
                                        }
                                        break;
                                }
                                Console.Clear();
                                break;

                            case 1:
//fire
                                string[] YesNo1 = new string[] { "Yes" };
                                int userYesNo1 = Utility.ShowUserOptionsAndGetAValidResponse($"{FireMagic.Description} Use?", $"{YesNo1.Length + 1}) No", YesNo1);
                                switch (userYesNo1)
                                {
                                    default:
                                        Console.Clear();
                                        break;
                                    case 0:
                                        if (mage.Magic > 20)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"{Player.CharacterName} used {FireMagic.Name}!");
                                            Console.ResetColor();
                                            goblin.GoonHealth = goblin.GoonHealth - FireMagic.Value;
                                            mage.Magic = mage.Magic - FireMagic.Inventory;
                                            System.Threading.Thread.Sleep(2000);
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            if (RNG > 5)
                                            {
                                                Console.WriteLine($"The {goblin.Name} attacks!");
                                                mage.Health = mage.Health - goblin.GoonAttack1;
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            else
                                            {
                                                Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                                                mage.Health = mage.Health - goblin.GoonSpecial;
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            Console.ResetColor();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Sorry you don't have enough ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("MANA");
                                            Console.ResetColor();
                                            Console.Write("!");
                                            System.Threading.Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 2:
//concentrate
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{Player.CharacterName} is concentrating...");
                        System.Threading.Thread.Sleep(2000);
                        if (mage.Magic < 100)
                        {
                            if (RNG >= 3)
                            {
                                Console.WriteLine($"{Player.CharacterName} restored 10 MANA!");
                                mage.Magic += 10;
                                System.Threading.Thread.Sleep(2000);

                            }
                            else
                            {
                                Console.WriteLine($"{Player.CharacterName} concentrated hard and restore 20 MANA!");
                                mage.Magic += 20;
                                System.Threading.Thread.Sleep(2000);
                            }
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (RNG > 2)
                            {
                                Console.WriteLine($"The {goblin.Name} attacks!");
                                mage.Health = mage.Health - goblin.GoonAttack1;
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine($"The {goblin.Name} unleashes a strong attack!");
                                mage.Health = mage.Health - goblin.GoonSpecial;
                                System.Threading.Thread.Sleep(2000);
                            }
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine($"{Player.CharacterName} can't concentrate right now!");
                            System.Threading.Thread.Sleep(2000);
                        }
                        Console.Clear();
                        break;
                }
            }
            Battle1.Stop();

            SoundPlayer Win = new SoundPlayer("Earthbound You Win.wav");
            Win.Load();
            Win.Play();

            Divider();
            Titles.VictoryScreen();
            Divider();
            Utility.Typewrite($"Congratulations! You defeated the {goblin.Name}!");
        }
    }
    class Program
    {
        public static void Main()
        {
            //var GameStart = new GameStart();
            Console.Title = "Tower Quest";
            Console.WindowWidth = 80;
            GameStart GameStart = new GameStart();
            //System.Threading.Thread.Sleep(8000);
            GameStart.Title();
            GameStart.NameCharacter();
            GameStart.ClassesIntro();
            //KnightGame knightGame = new KnightGame();
            //knightGame.Ending();
            //MageGame mageGame = new MageGame();
            //mageGame.GameOver();
            
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
