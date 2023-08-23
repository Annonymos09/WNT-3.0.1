using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class casediskpart
    {
        public static void casediskpart1()
        {
            //diskpart
            Process p = new Process();                                    // new instance of Process class
            p.StartInfo.UseShellExecute = false;                          // do not start a new shell
            p.StartInfo.RedirectStandardOutput = true;                    // Redirects the on screen results
            p.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
            p.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
            p.Start();                                                    // Starts the process
            Methodes.collordangarus();
            Console.WriteLine("Caution: Using diskpart can cause possible damage to the system!");
            Methodes.collortext();
            Console.WriteLine("Before deleting a disk, make sure you know the number of the disk you want to delete.");
            Console.WriteLine("To check, open disk management and read out the number.");
            Methodes.collorgood();
            Console.WriteLine("For example:");
            Console.WriteLine("Disk 1                              Number to be entered below = 1");
            Methodes.collordangarus();
            Console.WriteLine("Please never select disk 0 because it contains your Windows system and can be accidentally deleted with it.");
            Methodes.collorgood();
            int Zahl1 = 0;
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
            Int32.TryParse(Console.ReadLine(), out Zahl1);
            p.StandardInput.WriteLine("select disk " + Zahl1);              // Issues commands to diskpart
            p.StandardInput.WriteLine("clean");                           //   |
            p.StandardInput.WriteLine("create partition primary");        //   |
            p.StandardInput.WriteLine("select partition 1");              //   |
            p.StandardInput.WriteLine("format fs=ntfs quick");            //   |
            p.StandardInput.WriteLine("active");                          //   |
            p.StandardInput.WriteLine("assign");                          //   |
            p.StandardInput.WriteLine("exit");                            // _\|/_
            string output = p.StandardOutput.ReadToEnd();                 // Places the output to a variable
            p.WaitForExit();                                              // Waits for the exe to finish

            Console.WriteLine(output);
            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}