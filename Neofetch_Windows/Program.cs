using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Neofetch_Windows
{
    class Program
    {
        private static string[] ListInfo = {"","","","OS: ", "Version: ","IpAddress: ", "Processor: ", "Processor Core: "
                                     ,"VideoController: ","VideoControllerRam: ","Memory: " };

        static void Main(string[] args)
        {
            ShowInfo();

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop + 10);
        }

        private static void ShowInfo()
        {
            var lst = GetSystemInfo();
            LogoWindows10 logoWindows;
            LogoWindowsXp windowsXp;

            if (lst[3].Contains("10") || lst.Contains("8"))
                logoWindows = new LogoWindows10();
            else
                windowsXp = new LogoWindowsXp();


            Console.SetCursorPosition(55, Console.CursorTop - 28);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(lst[0]);
            Console.SetCursorPosition(55, Console.CursorTop);

            Console.WriteLine(lst[1]);
            Console.SetCursorPosition(55, Console.CursorTop);

            Console.WriteLine(lst[2]);
            Console.SetCursorPosition(55, Console.CursorTop);

            for (int i = 3; i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(ListInfo[i]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(lst[i]);
                Console.SetCursorPosition(55, Console.CursorTop);
                Console.WriteLine();
                Console.SetCursorPosition(55, Console.CursorTop);
            }
        }

        private static List<string> GetSystemInfo()
        {
            List<string> info = new List<string>();
            info.Add(Environment.UserName);
            info.Add("---------------------");
            info.Add("");


            ManagementObjectSearcher searcher5 = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_OperatingSystem");
            foreach (var item in searcher5.Get())
            {
                info.Add(item["Name"].ToString().Substring(0,22));
                info.Add(item["Version"].ToString());
            }

            
            searcher5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapterConfiguration");

            string ip = "";
            foreach (var item in searcher5.Get())
            {
                if (item["IPAddress"] != null)
                {
                    String[] arrIPAddress = (String[])(item["IPAddress"]);
                   
                    foreach (String arrValue in arrIPAddress)
                    {
                        if (arrValue.Length < 16)
                            ip += arrValue + " \\ ";
                    }

                    
                }
            }

            info.Add(ip);

            searcher5 =  new ManagementObjectSearcher("root\\CIMV2",    "SELECT * FROM Win32_Processor");

            foreach (var item in searcher5.Get())
            {
                info.Add(item["Name"].ToString());
                info.Add(item["NumberOfCores"].ToString());
            }


            searcher5 =  new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (var item in searcher5.Get())
            {
                info.Add(item["Description"].ToString());
                info.Add(int.Parse(item["AdapterRAM"].ToString()) / 1024 / 1024 + " Mb");
            }

            searcher5 =new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");

            foreach (var item in searcher5.Get())
            {
                ulong totalRam = Convert.ToUInt64(item["TotalVisibleMemorySize"]);
                ulong busyRam = totalRam - Convert.ToUInt64(item["FreePhysicalMemory"]);
                info.Add(busyRam / 1024 + " / " + totalRam / 1024 + " Mb");
            }

            return info;
        }
    }
}
