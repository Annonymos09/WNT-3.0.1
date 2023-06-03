using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caseIP
    {
        public static void caseIP1()
        {
            //IP steads anzeigen 
            Process.Start("cmd", "/c " + "ipconfig");
            Console.ReadLine();
            Methodes.collordangarus();
            Console.WriteLine("Public IP-Adress");
            Process.Start("cmd", "/c " + "curl ifconfig.me");
            Console.ReadLine();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}