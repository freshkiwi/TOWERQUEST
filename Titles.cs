using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Media;

namespace AdventureGame
{
    class Titles
    {
        public static void LevelOneTitle()
        {
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
            string Level = @"
 _      ________      ________ _        __ 
| |    |  ____\ \    / /  ____| |      /_ |
| |    | |__   \ \  / /| |__  | |       | |
| |    |  __|   \ \/ / |  __| | |       | |
| |____| |____   \  /  | |____| |____   | |
|______|______|   \/   |______|______|  |_|";

            SoundPlayer Advance = new SoundPlayer("Venture Forth.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Advance.Stop();
        }
        public static void LevelTwoTitle()
        {
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
            string Level = @"
 _      ________      ________ _        ___  
| |    |  ____\ \    / /  ____| |      |__ \ 
| |    | |__   \ \  / /| |__  | |         ) |
| |    |  __|   \ \/ / |  __| | |        / / 
| |____| |____   \  /  | |____| |____   / /_ 
|______|______|   \/   |______|______| |____|";

            SoundPlayer Advance = new SoundPlayer("Venture Forth.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Advance.Stop();
        }
        public static void LevelThreeTitle()
        {
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
            string Level = @"
 _      ________      ________ _        ____  
| |    |  ____\ \    / /  ____| |      |___ \ 
| |    | |__   \ \  / /| |__  | |        __) |
| |    |  __|   \ \/ / |  __| | |       |__ < 
| |____| |____   \  /  | |____| |____   ___) |
|______|______|   \/   |______|______| |____/ ";

            SoundPlayer Advance = new SoundPlayer("Venture Forth.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Advance.Stop();
        }
        public static void LevelFourTitle()
        {
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
            string Level = @"
 _      ________      ________ _        _  _   
| |    |  ____\ \    / /  ____| |      | || |  
| |    | |__   \ \  / /| |__  | |      | || |_ 
| |    |  __|   \ \/ / |  __| | |      |__   _|
| |____| |____   \  /  | |____| |____     | |  
|______|______|   \/   |______|______|    |_|  ";

            SoundPlayer Advance = new SoundPlayer("Omen of Battle.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Advance.Stop();
        }
        public static void LevelFiveTitle()
        {
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
            string Level = @"
 _      ________      ________ _        _____ 
| |    |  ____\ \    / /  ____| |      | ____|
| |    | |__   \ \  / /| |__  | |      | |__  
| |    |  __|   \ \/ / |  __| | |      |___ \ 
| |____| |____   \  /  | |____| |____   ___) |
|______|______|   \/   |______|______| |____/ ";

            SoundPlayer Advance = new SoundPlayer("Omen of Battle.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Advance.Stop();
        }
        public static void LevelSixTitle()
        {
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
            string Level = @"
 _      ________      ________ _          __  
| |    |  ____\ \    / /  ____| |        / /  
| |    | |__   \ \  / /| |__  | |       / /_  
| |    |  __|   \ \/ / |  __| | |      | '_ \ 
| |____| |____   \  /  | |____| |____  | (_) |
|______|______|   \/   |______|______|  \___/ ";

            SoundPlayer Advance = new SoundPlayer("Omen of Battle.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Advance.Stop();
        }
        public static void FinalTitle()
        {
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
            string Level = @"
 ______ _____ _   _          _      
|  ____|_   _| \ | |   /\   | |     
| |__    | | |  \| |  /  \  | |     
|  __|   | | | . ` | / /\ \ | |     
| |     _| |_| |\  |/ ____ \| |____ 
|_|    |_____|_| \_/_/    \_\______|
                                    ";

            SoundPlayer Advance = new SoundPlayer("The Revenge.wav");
            Advance.Play();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(image);
            Console.ResetColor();
            Utility.TypewriteFast(Level);
            System.Threading.Thread.Sleep(6000);
            Console.Clear();
            Advance.Stop();
        }
        public static void RestAreaTitle()
        {
            string Title = @"
=============================================================================
         _____  ______  _____ _______            _____  ______          
        |  __ \|  ____|/ ____|__   __|     /\   |  __ \|  ____|   /\    
        | |__) | |__  | (___    | |       /  \  | |__) | |__     /  \   
        |  _  /|  __|  \___ \   | |      / /\ \ |  _  /|  __|   / /\ \  
        | | \ \| |____ ____) |  | |     / ____ \| | \ \| |____ / ____ \ 
        |_|  \_\______|_____/   |_|    /_/    \_\_|  \_\______/_/    \_\

=============================================================================";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ResetColor();

        }
        public static void RestArea()
        {
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
            string Rest = @"

 _____  ______  _____ _______            _____  ______          
|  __ \|  ____|/ ____|__   __|     /\   |  __ \|  ____|   /\    
| |__) | |__  | (___    | |       /  \  | |__) | |__     /  \   
|  _  /|  __|  \___ \   | |      / /\ \ |  _  /|  __|   / /\ \  
| | \ \| |____ ____) |  | |     / ____ \| | \ \| |____ / ____ \ 
|_|  \_\______|_____/   |_|    /_/    \_\_|  \_\______/_/    \_\";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(image);
            Utility.TypewriteFast(Rest);
            Console.ResetColor();
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
        }
        public static void VictoryScreen()
        {
            string victory = @"
            __      _______ _____ _______ ____  _______     __
            \ \    / /_   _/ ____|__   __/ __ \|  __ \ \   / /
             \ \  / /  | || |       | | | |  | | |__) \ \_/ / 
              \ \/ /   | || |       | | | |  | |  _  / \   /  
               \  /   _| || |____   | | | |__| | | \ \  | |   
                \/   |_____\_____|  |_|  \____/|_|  \_\ |_|
";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Utility.TypewriteFast(victory);
            Console.ResetColor();
        }
    }
}
