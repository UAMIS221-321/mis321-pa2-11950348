using System;

namespace PA2.Misc
{
    public class Output
    {
        public static void MenuOption(){
            
            for (int dots = 0; dots <= 3; dots++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("\rPlease select a following option from the menu{0}", new string('.', dots));
                System.Console.ResetColor();
                System.Threading.Thread.Sleep(300);
            }
        }

        public static void HowToPlay(){
            
            for (int dots = 0; dots <= 3; dots++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("\rHow to play: Each player will enter their name, then select a character for battle{0}", new string('.', dots));
                System.Console.ResetColor();
                System.Threading.Thread.Sleep(300);
            }
        }

        public static void HowToPlayAI(){
            
            System.Console.Clear();
            for (int dots = 0; dots <= 3; dots++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("\rHow to play: Please enter your name and select a character{0}", new string('.', dots));
                System.Console.ResetColor();
                System.Threading.Thread.Sleep(300);
            }
            System.Console.Clear();
        }

        public static void InvalidMenuSelectionError(){
            
            System.Console.WriteLine("");
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            for (int dots = 0; dots <= 3; dots++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.Write("\r[Error] Invalid Selection! Please enter the number for the option you wish to choose{0}", new string('.', dots));
                System.Console.ResetColor();
                System.Threading.Thread.Sleep(300);
            }
            System.Console.WriteLine("");
            Default.Key();
            System.Console.Clear();
        }

        public static void Exit(){
            
            System.Console.Clear();
            for (int dots = 0; dots <= 3; dots++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("\rThanks you playing! Goodbye{0}", new string('.', dots));
                System.Console.ResetColor();
                System.Threading.Thread.Sleep(300);
            }
            System.Console.Clear();
        }

        public static void Battle(){
            
            //System.Console.WriteLine("########     ###    ######## ######## ##       ########  ####");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("########     ###    ######## ######## ##       ########  ####");
            System.Console.WriteLine("##     ##  ##   ##     ##       ##    ##       ##        ####");
            System.Console.WriteLine("########  ##     ##    ##       ##    ##       ######     ## ");
            System.Console.WriteLine("##     ## #########    ##       ##    ##       ##            ");
            System.Console.WriteLine("##     ## ##     ##    ##       ##    ##       ##        ####");
            System.Console.WriteLine("########  ##     ##    ##       ##    ######## ########  ####");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(999); 
            System.Console.Clear();
        }

        public static void OnevsOne(){
            
            System.Console.Clear();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine(" ####   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine(" ###### ");
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.WriteLine(" ##     ##  ######  ");
            System.Console.WriteLine(" ##     ## ##    ## ");
            System.Console.WriteLine(" ##     ## ##       ");
            System.Console.WriteLine(" ##     ##  ######  ");
            System.Console.WriteLine("  ##   ##        ## ");
            System.Console.WriteLine("   ## ##   ##    ## ");
            System.Console.WriteLine("    ###     ######  ");
           
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine(" ####   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine("   ##   ");
            System.Console.WriteLine(" ###### ");
            System.Threading.Thread.Sleep(500); 
            
            System.Console.Clear();
            System.Console.ResetColor();
        }

        public static void AIvsPlayer(){
            
            System.Console.Clear();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("##    ##  #######  ##     ## ");
            System.Console.WriteLine(" ##  ##  ##     ## ##     ## ");
            System.Console.WriteLine("  ####   ##     ## ##     ## ");
            System.Console.WriteLine("   ##    ##     ## ##     ## ");
            System.Console.WriteLine("   ##    ##     ## ##     ## ");
            System.Console.WriteLine("   ##    ##     ## ##     ## ");
            System.Console.WriteLine("   ##     #######   #######  ");
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.WriteLine(" ##     ##  ######  ");
            System.Console.WriteLine(" ##     ## ##    ## ");
            System.Console.WriteLine(" ##     ## ##       ");
            System.Console.WriteLine(" ##     ##  ######  ");
            System.Console.WriteLine("  ##   ##        ## ");
            System.Console.WriteLine("   ## ##   ##    ## ");
            System.Console.WriteLine("    ###     ######  ");
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.WriteLine("    ###    #### ");
            System.Console.WriteLine("   ## ##    ##  ");
            System.Console.WriteLine("  ##   ##   ##  ");
            System.Console.WriteLine(" ##     ##  ##  ");
            System.Console.WriteLine(" #########  ##  ");
            System.Console.WriteLine(" ##     ##  ##  ");
            System.Console.WriteLine(" ##     ## #### ");
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();
            System.Console.ResetColor();
        }

         public static void GameOver(){
            
            System.Console.Clear();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("  ######      ###    ##     ## ######## ");
            System.Console.WriteLine(" ##    ##    ## ##   ###   ### ##       ");
            System.Console.WriteLine(" ##         ##   ##  #### #### ##       ");
            System.Console.WriteLine(" ##   #### ##     ## ## ### ## ######   ");
            System.Console.WriteLine(" ##    ##  ######### ##     ## ##       ");
            System.Console.WriteLine(" ##    ##  ##     ## ##     ## ##       ");
            System.Console.WriteLine("  ######   ##     ## ##     ## ######## \n");
            
            System.Threading.Thread.Sleep(300);

            System.Console.WriteLine("  #######  ##     ## ######## ########  ");
            System.Console.WriteLine(" ##     ## ##     ## ##       ##     ## ");
            System.Console.WriteLine(" ##     ## ##     ## ##       ##     ## ");
            System.Console.WriteLine(" ##     ## ##     ## ######   ########  ");
            System.Console.WriteLine(" ##     ##  ##   ##  ##       ##   ##   ");
            System.Console.WriteLine(" ##     ##   ## ##   ##       ##    ##  ");
            System.Console.WriteLine("  #######     ###    ######## ##     ## ");
            System.Console.ResetColor();

            System.Threading.Thread.Sleep(999);
            System.Console.Clear();
        }

        public static void Welcome(){
            
            System.Console.Clear();
            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(" ##      ## ######## ##        ######   #######  ##     ## ######## ");
            System.Console.WriteLine(" ##  ##  ## ##       ##       ##    ## ##     ## ###   ### ##       ");
            System.Console.WriteLine(" ##  ##  ## ##       ##       ##       ##     ## #### #### ##       ");
            System.Console.WriteLine(" ##  ##  ## ######   ##       ##       ##     ## ## ### ## ######   ");
            System.Console.WriteLine(" ##  ##  ## ##       ##       ##       ##     ## ##     ## ##       ");
            System.Console.WriteLine(" ##  ##  ## ##       ##       ##    ## ##     ## ##     ## ##       ");
            System.Console.WriteLine("  ###  ###  ######## ########  ######   #######  ##     ## ######## ");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(500);
            System.Console.Clear(); 

            System.Console.Clear();
            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(" ########  #######  ");
            System.Console.WriteLine("    ##    ##     ## ");
            System.Console.WriteLine("    ##    ##     ## ");
            System.Console.WriteLine("    ##    ##     ## ");
            System.Console.WriteLine("    ##    ##     ## ");
            System.Console.WriteLine("    ##    ##     ## ");
            System.Console.WriteLine("    ##     #######  ");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(500); 

            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(" ######## ##     ## ######## ");
            System.Console.WriteLine("    ##    ##     ## ##       ");
            System.Console.WriteLine("    ##    ##     ## ##       ");
            System.Console.WriteLine("    ##    ######### ######   ");
            System.Console.WriteLine("    ##    ##     ## ##       ");
            System.Console.WriteLine("    ##    ##     ## ##       ");
            System.Console.WriteLine("    ##    ##     ## ######## ");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(" ########     ###    ######## ######## ##       ########  ");
            System.Console.WriteLine(" ##     ##  ##   ##     ##       ##    ##       ##        ");
            System.Console.WriteLine(" ########  ##     ##    ##       ##    ##       ######    ");
            System.Console.WriteLine(" ##     ## #########    ##       ##    ##       ##        ");
            System.Console.WriteLine(" ##     ## ##     ##    ##       ##    ##       ##        ");
            System.Console.WriteLine(" ########  ##     ##    ##       ##    ######## ########  ");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("  #######  ######## ");
            System.Console.WriteLine(" ##     ## ##       ");
            System.Console.WriteLine(" ##     ## ##       ");
            System.Console.WriteLine(" ##     ## ######   ");
            System.Console.WriteLine(" ##     ## ##       ");
            System.Console.WriteLine(" ##     ## ##       ");
            System.Console.WriteLine("  #######  ##       ");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(500); 
            System.Console.Clear();

            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("  ######     ###    ##       ##    ## ########   ######   #######  ####  ######  ");
            System.Console.WriteLine(" ##    ##   ## ##   ##        ##  ##  ##     ## ##    ## ##     ## #### ##    ## ");
            System.Console.WriteLine(" ##        ##   ##  ##         ####   ##     ## ##       ##     ##  ##  ##       ");
            System.Console.WriteLine(" ##       ##     ## ##          ##    ########   ######  ##     ## ##    ######  ");
            System.Console.WriteLine(" ##       ######### ##          ##    ##              ## ##     ##            ## ");
            System.Console.WriteLine(" ##    ## ##     ## ##          ##    ##        ##    ## ##     ##      ##    ## ");
            System.Console.WriteLine("  ######  ##     ## ########    ##    ##         ######   #######        ######  \n");
            System.Console.ResetColor();
           
            System.Threading.Thread.Sleep(250); 

            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine(" ##     ##    ###    ######## ##        ######  ######## ########   #######  ##     ## ");
            System.Console.WriteLine(" ###   ###   ## ##   ##       ##       ##    ##    ##    ##     ## ##     ## ###   ### ");
            System.Console.WriteLine(" #### ####  ##   ##  ##       ##       ##          ##    ##     ## ##     ## #### #### ");
            System.Console.WriteLine(" ## ### ## ##     ## ######   ##        ######     ##    ########  ##     ## ## ### ## ");
            System.Console.WriteLine(" ##     ## ######### ##       ##             ##    ##    ##   ##   ##     ## ##     ## ");
            System.Console.WriteLine(" ##     ## ##     ## ##       ##       ##    ##    ##    ##    ##  ##     ## ##     ## ");
            System.Console.WriteLine(" ##     ## ##     ## ######## ########  ######     ##    ##     ##  #######  ##     ## ");
            System.Console.ResetColor();
            
            System.Threading.Thread.Sleep(999);
            System.Console.Clear();

        }
    }
}