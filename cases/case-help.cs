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
[2] = What is my IP?
[3] = IP scan
[4] = Ping and go to the web interface
[5] = Windows MRT
[6] = Check hard disk
[7] = Repair Windows system files
[8] = Repair Windows system files
[9] = Repair USB device
[10] = Update system
[11] = Update all programs
[12] = Diskpart
[13] = Download various program groups
[14] = Disable/enable Windows updates
[15] = Activate Windows
[16] = Disable Windows Defender
[17] = Enable Windows Defender
[18] = Windows optimization for low-end PCs (uninstall microsoft complytly)  
[19] = Enable Microsoft Office-2021 (profesional plus)

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