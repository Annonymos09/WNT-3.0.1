using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class casehelp
    {
        public static void casehelp1()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Methodes.collorgood();
            Console.WriteLine("<-------------------------------------- Everything at your own risk --------------------------------------->");
            Methodes.collornotes();
            Console.WriteLine("These tools can damage the system if used incorrectly!");
            Console.WriteLine("Before you make an entry, please check everything several times to ensure that you really want to do it.");
            Console.WriteLine("Important information: all programs can be terminated at any time with Ctrl + C.");
            Methodes.collorgood();
            string help = @"
[0] = Help
[1] = License WNT
[2] = What's my IP?
[3] = IP Scan
[4] = Ping and go to web interface
[5] = Windows MRT
[6] = Check hard disk
[7] = Repair Windows system files
[8] = Repair Windows system files
[9] = Repair USB device
[10] = Update your system
[11] = Update all programs
[12] = Diskpart
[13] = Download different program groups
[14] = Deactivate/Activate Windows updates
[15] = Activate Windows
[16] = Deactivate Windows Defender
[17] = Activate Windows Defender
[18] = Windows optimization for low-end PCs (uninsall all microsoft progamms) 
[19] = Activate microsoft office-19
";
            Console.WriteLine(help);

            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter a number to start a programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}