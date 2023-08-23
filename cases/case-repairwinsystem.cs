using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caserepairwinsystem
    {
        public static void caserepairwinsystem1()
        {
            //repair Win hard online
            System.Diagnostics.Process.Start("cmd", "/c " + "dism /Online /Cleanup-Image /ScanHealth");
            System.Diagnostics.Process.Start("cmd", "/c " + "Dism /Online /Cleanup-Image /CheckHealth");
            System.Diagnostics.Process.Start("cmd", "/c " + "dism /Online /Cleanup-Image /RestoreHealth");
            Methodes.collordangarus();
            Console.WriteLine(">>> please restart your Computer! <<<");
            Console.WriteLine("now all found damaged Windows files were repaired");
        }
    }
}