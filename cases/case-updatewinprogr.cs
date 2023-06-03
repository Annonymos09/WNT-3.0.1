using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class casewinprogr
    {
        public static void casewinprogr1()
        {
            //update windows programm 
            Methodes.collordangarus();
            Console.WriteLine("when this message comes ''Do you agree with all terms of the source agreeme ?''");
            Console.WriteLine("accept it to continue with [Y]");
            Methodes.collorgood();
            System.Diagnostics.Process.Start("cmd", "/c " + "winget upgrade");
            System.Diagnostics.Process.Start("cmd", "/c " + "winget upgrade -h --all");
            System.Diagnostics.Process.Start("cmd", "/c " + "exit");
            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}