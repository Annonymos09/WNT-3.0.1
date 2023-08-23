using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caserepairmedia
    {
        public static void caserepairmedia1()
        {
            Methodes.collordangarus();
            Console.WriteLine(">>> caution data can be corrupted <<<");
            Methodes.collorgood();
            Console.WriteLine("plase enter the letter from the usb device");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext(); 
            string device = Console.ReadLine();
            Process.Start("cmd", "/c " + "CHKDSK " + device + "/offlinescanandfix");
            Methodes.collordangarus();
            Console.WriteLine("now all found damaged files repaired");
        }
    }
}