﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace CoolConsoleApp2
{
    class Graphic
    {
        public void ProgramLogoStart()
        {
            Console.SetWindowSize(150, 30);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            List<string> logoAuthor = new List<string> { "B", "Y", " ", "C", "H", "E", "R", "N", "_", "N", "I", "C" };

            Console.Write("______   ______   ______   __                 ______   ______   __   __   ______   ______   __       ______             ______   ______  ______  \n");
            Thread.Sleep(200);
            Console.Write("/\\  ___\\ /\\  __ \\ /\\  __ \\ /\\ \\               /\\  ___\\ /\\  __ \\ /\\ \"-.\\ \\ /\\  ___\\ /\\  __ \\ /\\ \\     /\\  ___\\           /\\  __ \\ /\\  == \\/\\  == \\ \n");
            Thread.Sleep(200);
            Console.Write("\\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\/\\ \\\\ \\ \\____          \\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\-.  \\\\ \\___  \\\\ \\ \\/\\ \\\\ \\ \\____\\ \\  __\\           \\ \\  __ \\\\ \\  _-/\\ \\  _-/ \n");
            Thread.Sleep(200);
            Console.Write(" \\ \\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_____\\\\ \\_____\\\\ \\_\\\\\"\\_\\\\/\\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_\\ \\_\\\\ \\_\\   \\ \\_\\   \n");
            Thread.Sleep(200);
            Console.Write("  \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_____/ \\/_____/ \\/_/ \\/_/ \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_/\\/_/ \\/_/    \\/_/   ");
            Thread.Sleep(200);

            Console.SetCursorPosition(75 - logoAuthor.Count, 6);
            for (int i = 0; i < logoAuthor.Count; i++)
            {
                Console.Write(logoAuthor[i]);
                Thread.Sleep(200);
            }
        }

        public void ProgramLogo()
        {
            Console.SetWindowSize(150, 30);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            List<string> logoAuthor = new List<string> { "B", "Y", " ", "C", "H", "E", "R", "N", "_", "N", "I", "C" };

            Console.Write("______   ______   ______   __                 ______   ______   __   __   ______   ______   __       ______             ______   ______  ______  \n");
            Console.Write("/\\  ___\\ /\\  __ \\ /\\  __ \\ /\\ \\               /\\  ___\\ /\\  __ \\ /\\ \"-.\\ \\ /\\  ___\\ /\\  __ \\ /\\ \\     /\\  ___\\           /\\  __ \\ /\\  == \\/\\  == \\ \n");
            Console.Write("\\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\/\\ \\\\ \\ \\____          \\ \\ \\____\\ \\ \\/\\ \\\\ \\ \\-.  \\\\ \\___  \\\\ \\ \\/\\ \\\\ \\ \\____\\ \\  __\\           \\ \\  __ \\\\ \\  _-/\\ \\  _-/ \n");
            Console.Write(" \\ \\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_____\\\\ \\_____\\\\ \\_\\\\\"\\_\\\\/\\_____\\\\ \\_____\\\\ \\_____\\\\ \\_____\\          \\ \\_\\ \\_\\\\ \\_\\   \\ \\_\\   \n");
            Console.Write("  \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_____/ \\/_____/ \\/_/ \\/_/ \\/_____/ \\/_____/ \\/_____/ \\/_____/           \\/_/\\/_/ \\/_/    \\/_/   ");

            Console.SetCursorPosition(75 - logoAuthor.Count, 6);
            for (int i = 0; i < logoAuthor.Count; i++)
            {
                Console.Write(logoAuthor[i]);
            }
        }

        public void lobster()
        {
            Console.Clear();
            Thread.Sleep(300);
            SoundPlayer lobsterMusic= new SoundPlayer("lobster.wav");
            lobsterMusic.PlayLooping();

            Console.SetWindowSize(164, 44);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"*****************************++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++***********************************************:::::::***:*
*********************************+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*********+************************************::::::::****
*********************************+++++++++++++++++++++++++++++++++*:::::::*++++++++++++++++++++++++++++++++++++***************************************:::::*****
++++++++*******************+++++++++++++++++++++++++++++++++++*:::::::::::::-:++++++++++++++++++++++++++++++++***************************************:::::*****+
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++:-::::---:::::::---:*++++++++++++++++++++++++++++****++++++++++++++++++***************************++
+++++++++++++++++++++++++++++++++++++++++++++++++++++=====:--:*:*::::::::::::----:*++++++++++++++++++++++++++**+++++++++++++++++++++++++++++++******************
++++++++++++++++++++++++++++++++++++++++++++++==========+--::**:---:::::::::::::::-:++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++***********+
+++++++++++++++++++++++++++++++++++++++++++============+--::::-:-:**::-:-::::::---:::*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++**+++
++++++++++++++++++++++++++========++++================+-::::-:-**:---::*::::----::-:**-*+++++++++++++++++++=======++++++++++++++++++++++++++++++++++++++++++++==
+++++++++++++++++++++++++++++++======================+:::----:*:-.--::::-:::-------:::::-+++====================+++++++++++++++++++++++++++++++++++++++++++++===
++++=+++++++++++=====+++++++++++=====================+::-:.-:*:...--::::+*:---::::-::---:-+============+===+++++++++++++++++++++++++++++++++++++++++++++++++====
==================+++===============+++++============::-:---::-..-:**:::-**+****+*:::+:-.:-+===================+==================++++++++++++++++++++++++======
=================+==================================*::-:--:::---:**:%##%===+:::**-=+**++:::=====================================+++++++++++++++++==============
===================================================+::--:-::-.--::::=###%+=++:::+**+%=###%+:*===================================================================
===================================================+::-:::::-.--::*++=======%++::::=+==%#*:-:+==================================================================
===================================================*:::--:---.:-:+=++==%==++++++*+===%=++*-:*+==================================================================
==================================================:*:::-::------++*****+*:**::++:+*++=====+**+==========+=======================================================
================================================+:***:--:::::**+=:*:=+:++==++:++=***++***+=**+========+:*+**+========================++++=======================
====================================::**=========:::::---******++::**++===+%=*+=%+====**=+:***+==*::***::::-::+=================================================
==========%%%%%===============%==%:::**+:*=======--:**::::*+++++=#=+:--**++=%+*+==+======+=+++*++++**:***+*:----:*==============================================
%%====%%%%%%%%=======%%%%%%%%%%%%*-:***+++++==%=-::::--%:-:*+**====%=+:::**+=+*+=++=+*:*%##+===+++*+++*******:::-------:*+======================================
%===============%%%%%%%%%%%%%%%==-::*+++====+----::::**+****++++=####%=**++*++*++=+****%##+==+++*++++**:::::----.---::=*-------::**++===========================
%========%%====+**:::::::::::::::.:***++=**:-::::********++++==+==###%#****+==*+==+*+++#=+++++*++******:::::-::::::-:**::*++*::::**++:::::::::::-:++============
=====++*::::-::::::::::::::::::*:.:**+=:::::**********++**:%==+====###+=+***==*+==+=+=+=%++=++++=*+*****:::::::::::**::::::**:::::::-:::--::---::::---:--::::+==
--:::::***:::::::::*******:******::*+==*--::**************+*+++++======%=+:++%++=%+++++%%%%%++++*++**+++++++******++:***:--::::::::::::::::-:-----::-::---------
::::**:::::::::::::**********++++*--:::-------:*+*****:::****+++======%%==*++%++===+++######%=+*++++*+++==++++++=+***:::*::----::::::*::::::::::::----::::::-:::
::::::::::::::::::::**:**:::::::::::+*::----:==***::*::**:*****++=%=+==#%%*++=++%%%=++%##%=%#%=+++++++====++++*--:::::****::*:-----::::::::::::::::--:::--::--::
+********::********+++***:*:::::**+-----::--:***:*:::***::*:**+===#%%%###%+*+===%%%%=++%%#=%%##%==++=++===+++*:::*:::****::++*:*:--.--:::+::::::::*::::::::-:---
*::::::::****++++++************=++++::::--:::*+***::::*::*::*+%%%%########=*++==%###=+++=%#######=+++++=%==++%****:::********++*::-----:**+*****::::::::::::::::
***+*+*****:::****++++*:****:*:*=***-::..--::**++*==****:::::%%%%%#########*++==####%+++##########=%%%=+====+::**::*:***:**++*::****--.---:::::::::::::--::--:::
++++++*+******++=***+****++**++*++*+:::.-::::::--********:::+####+#########+++==#####=++=#####%#####%%=%%===++*******::**:**:**::***:-----.-***::::::::::::-:--:
:::***+***++++*****:*+=******+++++++::-:--:***++**+=+++*+++%%#####%%#######=*+=%######+++%####%%%%==++===%=++*********+*::*++++++*:***:-------:::*::::::-:-:::::
***++=******+*+++++=======%++++==+++::--:::::**++**:*****+%###=+=##########%*++%######=++=##%%%%%=+++=%%%=-::***********::****+*****:*::-------:+*+***:***:***::
+++*+*+++++++++=++======++++++==%%+**+::***::***++**::**::*::****=+==######%+++%######%+++###%*+**==%%##%%====+++****++*******++*******::--::::--:****:::::::::*
*****++++==+++++=%%==+*+%%%%==%%%::=*:**:::********+***::**:::::***+########+++%#######=++%#=*++==%##%%%%%%%=+****:**************+*::**::----*::-::++*******::::
++=++=+++++==++++++++*+========%-:::*+*:::**:+**++*+*::**:****:*:::**+**=%##+++%#######%+++==%%%=%%%%%%%%==%=*:****:***+***::*******:***::---::*::--:****:::::**
++===+%=+++++++=*++++++++=%####*-:*:**:::**:::***+++++***++*:****:::**++===%+*+=%#####%==++%#%%%%%%#%%%%%=%=+*++***:**:**::::::::******:*::----:::::*-+****:::**
+=======**+++==+===++==%#######--:::*:::::*++**+=++++***:****:*+**+*:***+=%%+*+=#%%%===%%++=####%%%%%%%%+==+===+*::*:::::::-----::::***:::::----:-:::+::******::
++++++*++++==++=*+*=#%####=****.-::::*::::***++**+++**::*+++*++***::******+++*+=%++%#####=++%%%%===++++++++++++*::--::::***:---::-:***:**:::-----:::::*-*+++::::
+++======++*++++++=#####=*++++*.-::::*:**::*::*+*+=+++++++*++**************=%**+#%=====###++=%%=%=++++++===+++=+:::--:+===++*-:==*:*****:*:::------:::::--******
%%#=+++*=+++==+*+=#####%***+++:.-:**::::*****:*+**+++*++++++********:***+**+%**+######===%=+=%=====++++==%==%%==*::**+++++:::-::=+*:***::**::--.--:--:::-:-****:
#==++*+=++++**+*%######==++===:.-:**:::*****:::*+++**+++++++++*******+*****+=+*+##########%++=%==++=+++=%%=%%#%%*:*+:**:--:::*:***=+:::::::*::-------::::-::*+**
**+++++++*++++++%######==+===+*.-:*:::**:**::*****+*+=+++***++********+**+**==*++=%########=+=#%===+=++===%%=%%==*++**::::::::*****+%+:::::***::-.----:-:::**:**
+==+*+*+++++*+=%######=====%=%+--::****:****::**:***++++++*++++*++*********++=**=##########%++%#%%=====+===%=%%%#+===*:*:+++*++**:::*==::::***:::-.----:::::::-*
++**++++=#%%=+%%#####%=%#+%%*=+--::**::***:****::***+++*******+++++*********+=**+=##########=+=##%======++=%%%#%%###=***++++++****:::*%=*:::*****:-.:--:::::-:-*");
            Console.ResetColor();
        }
    }
}
