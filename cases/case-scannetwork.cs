using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;


namespace right_consol.materiels
{
    public class casescannetwork
    {
        public static void casescannetwork1()
        {
            Process.Start("cmd", "/c " + "arp -a");
            
            
        }

    }
}