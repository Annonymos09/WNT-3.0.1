using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class casemrt
    {
        public static void casemrt1()
        {
            //mrt
            Process.Start("cmd", "/c " + "mrt");
            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}