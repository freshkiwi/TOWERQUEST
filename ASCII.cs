using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class ASCII
    {
        public static void ASCIIGoblin()
        {
            string goblin = @"
                                                            
            @@@@@@                         @@@@@&           
             @@@,@@@@@@@ .,#         @@@@@@@* @@#           
              @@@   *@@@@@@@@@@@@@@@@@@      (@@.           
               @@@@@@@               *@@@@(  @@@            
               @@@@   @@          @@    @@@%@@             
              @@@     %@@@@@@@@@@@@@      &@@               
             @@@        @@      @@         @@%              
            @@@         @@@    @@@         @@#              
            (@@%         &@@@@@@/         @@@               
              @@@&                    .@@@@%                
                %@@@@@@@@&#&@@@@@@@@@@@@                    
                  #@@@@,(&@&#((*   @@@@@@@@&&&@@@@@         
        @@@@@@@@@@@@@@             @@@@  ,#&&&%/ @@@        
       @@@.       @@@                @@@%         @@@       
      *@@,       @@@                   @@@@       @@@@@&    
  @@@@@@@&     ,@@@                      @@@   #@@@@@@@@@@@@
  #* @@@(@@@@@(#@@,                     @@@#   /@    @@@    
     /@@        .@@@@@     @@@@@@@@@@@@@@/                  
                    @@@@@@@@/.    @@@%                      
                  @@@%              @@@*                    
                 ,@@%                &@@@(        ,         
               .@@@@                  .@@@@@@@@@@@@&        
        ,@@@@@@@@.                                          ";
            Console.WriteLine(goblin);
        }
        public static void ASCIIGhost()
        {
            string ghost = @"
               ...
             ;::::;
           ;::::; :;
         ;:::::'   :;
        ;:::::;     ;.
       ,:::::'       ;           OOO\
       ::::::;       ;          OOOOO\
       ;:::::;       ;         OOOOOOOO
      ,;::::::;     ;'         / OOOOOOO
    ;:::::::::`. ,,,;.        /  / DOOOOOO
  .';:::::::::::::::::;,     /  /     DOOOO
 ,::::::;::::::;;;;::::;,   /  /        DOOO
;`::::::`'::::::;;;::::: ,#/  /          DOOO
:`:::::::`;::::::;;::: ;::#  /            DOOO
::`:::::::`;:::::::: ;::::# /              DOO
`:`:::::::`;:::::: ;::::::#/               DOO
 :::`:::::::`;; ;:::::::::##                OO
 ::::`:::::::`;::::::::;:::#                OO
 `:::::`::::::::::::;'`:;::#                O
  `:::::`::::::::;' /  / `:#
   ::::::`:::::;'  /  /   `#";
            Console.WriteLine(ghost);
        }
        public static void ASCIIDragon()
        {
            string dragon = @"
                             /|                 |\
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
            Console.Write("\n");
            Console.ResetColor();

        }
        public static void ASCIIDragonLoad()
        {
            string dragon = @"
                             /|                 |\
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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Utility.TypewriteFast(dragon);
            Console.ResetColor();
            Utility.TypewriteFast("\n===========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Utility.TypewriteFast(@"/ \ \ )");
            Console.ForegroundColor = ConsoleColor.White;
            Utility.TypewriteFast("==========================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Utility.TypewriteFast(@"\_) \\");
            Console.ForegroundColor = ConsoleColor.White;
            Utility.TypewriteFast("==========");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Utility.TypewriteFast(@"
           \ (\_)\                                            /\_)\
            \_)\                                                /\_)
             \                                                    /");
            Console.Write("\n");
            Console.ResetColor();
        }
        public static void ASCIIOverlord()
        {
            string overlord = @"
                                    _____
                                   /_____\
                                   ||///||
                                   \ \_/ /
                                   /  \  \
                                   \   | |
                                   /   | |
                                   |   | /
                                   |   | \
                                  /    |  \
                                 /_____/___\";
            Console.WriteLine(overlord);
        }
        public static void ASCIIOverlordFight()
        {
            string overlord = @"
                                     _____
                                    /_____\
                                 ┌-┐||///||
                                 \@/_\\_/ /
                                / │__/  / \
                                |[│--   | |
                                | │  \  | |
                                | │  |  | /
                                | │  |  | \
                                \ │  |  |  \
                                 \│__/___\__\";
            Console.WriteLine(overlord);
        }
        public static void ASCIIOverlordDefeat()
        {
            string fallen = @"
                                     _____
                                    /_____\
                                    ||///||
                                   /  \_/  \
                                 _/    \    \_
                                /       \     \
                               /________/______\";
            Console.WriteLine(fallen);
        }
    }
/*
============================================================================
    */
}
