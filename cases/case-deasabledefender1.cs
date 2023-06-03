using System;
using System.Diagnostics;

namespace right_consol.materiels
{
        public class deasabledefender
        {
        public static void deasabledefender1(string[] args)
        {
            // Disable Windows Defender
            string command = "Set-MpPreference -DisableRealtimeMonitoring $false";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("powershell.exe", command);
            Process.Start(procStartInfo);
        }
    }
}