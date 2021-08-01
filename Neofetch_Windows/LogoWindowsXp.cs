using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neofetch_Windows
{
    class LogoWindowsXp
    {
        private string[] logo =
        {


"            RRRRRRRRRRR                        ",
"          RRRRRRRRRRRRRRR                      ",
"         RRRRRRRRRRRRRRRR                      ",
"         RRRRRRRRRRRRRRRR                      ",
"        RRRRRRRRRRRRRRRR    GGG            G   ",
"        RRRRRRRRRRRRRRRR    GGGGGGGGGGGGGGGG   ",
"        RRRRRRRRRRRRRRR    GGGGGGGGGGGGGGGG    ",
"       RRRRRRRRRRRRRRRR    GGGGGGGGGGGGGGGG    ",
"       RRRRRRRRRRRRRRRR    GGGGGGGGGGGGGGGG    ",
"      RRRRRRRRRRRRRRRR    GGGGGGGGGGGGGGGG     ",
"      R            RRR    GGGGGGGGGGGGGGGG     ",
"                         GGGGGGGGGGGGGGGG       ",
"                         GGGGGGGGGGGGGGG       ",
"      BBBBBBBBBB        GGGGGGGGGGGGGGG        ",
"     BBBBBBBBBBBBBB        GGGGGGGGG           ",
"    BBBBBBBBBBBBBBBB                           ",
"    BBBBBBBBBBBBBBB                            ",
"   BBBBBBBBBBBBBBBB    YYY           Y         ",
"   BBBBBBBBBBBBBBBB    YYYYYYYYYYYYYYYY        ",
"   BBBBBBBBBBBBBBB    YYYYYYYYYYYYYYYY         ",
"  BBBBBBBBBBBBBBBB    YYYYYYYYYYYYYYYY         ",
"  BBBBBBBBBBBBBBBB    YYYYYYYYYYYYYYY          ",
" BBBBBBBBBBBBBBBB    YYYYYYYYYYYYYYYY          ",
" B           BBBB    YYYYYYYYYYYYYYYY          ",
"                    YYYYYYYYYYYYYYYY           ",
"                    YYYYYYYYYYYYYYYY           ",
"                    YYYYYYYYYYYYYYY            ",
"                      YYYYYYYYYYY              ",
        };

        public LogoWindowsXp()
        {
            Console.WriteLine();
            foreach (var item in logo)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == 'R')
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (item[i] == 'G')
                        Console.ForegroundColor = ConsoleColor.Green;
                    if (item[i] == 'B')
                        Console.ForegroundColor = ConsoleColor.Blue;
                    if (item[i] == 'Y')
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write(item[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
