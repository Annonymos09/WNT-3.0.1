using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class checkdisk
    {
        public static void checkdisk1()
        {
            //mrt
            Console.WriteLine("this tool checks your hard drive for damage");
            Process.Start("cmd", "/c " + "chkdsk");
            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}