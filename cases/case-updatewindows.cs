using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caseupdatewindows
    {
        public static void caseupdatewindows1()
        {
            //update Windows 

            System.Diagnostics.Process.Start("cmd", "/c " + "wuauclt /detectnow /updatenow");
            Console.WriteLine(">>> please restart your computer <<<");
        }
    }
}