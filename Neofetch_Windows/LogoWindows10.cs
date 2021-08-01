using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Neofetch_Windows
{
    class LogoWindows10
    {
        private string[] logo = {

"                                   WWWWWWWWW",
"                         WWWWWWWWWWWWWWWWWWW",
"               WWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"    WWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"                                             ",
"                                             ",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"  WWWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"   WWWWWWWWWWWWWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"              WWWWW   WWWWWWWWWWWWWWWWWWWWWWW",
"                         WWWWWWWWWWWWWWWWWWWW",
"                                    WWWWWWWWW",
        };

        public LogoWindows10()
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var item in logo)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
