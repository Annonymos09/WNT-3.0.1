using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caserepairwinfilesystem
    {
        public static void caserepairwinfilesystem1()
        {
            // repair Win system fil
            Process.Start("cmd", "/c " + "sfc /scannow");
            Methodes.collordangarus();
            Console.WriteLine(">>> please restart your Computer! <<<");
            Console.WriteLine("now all found damaged Windows files were repaired");
        }
    }
}