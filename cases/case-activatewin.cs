using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caseactivatewin
    {
        public static void caseactivatewin1()
        {
            //activate windows
            Methodes.collordangarus();
            Console.WriteLine("Please enter a number:");
            Console.WriteLine("If you have a Windows key, please only upgrade your license.");
            Methodes.collorgood();
            Console.WriteLine("[0] = Activate Windows with key (you have a key)");
            Console.WriteLine("[1] = Activate Windows (Home version) without key (you have no key)");
            Console.WriteLine("[2] = Activate Windows (Pro version) without key (you have a key)");
            Console.WriteLine("[3] = Activate Windows (Enterprise version) without key (you have a key)");
            Console.WriteLine("[4] = Activate Windows (Education version) without key (you have a key)");
            Console.WriteLine("[5] = Remove watermark.");


            int input2 = 0;
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
            Int32.TryParse(Console.ReadLine(), out input2);
            switch (input2)
            { 
                case 0:
                    //normaly 
                    Console.WriteLine("please enter your licens key");
                    System.Diagnostics.Process.Start("cmd", "/c " + "slmgr. vbs /upk");
                    System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ipk " + Console.ReadLine());
                    System.Diagnostics.Process.Start("cmd", "/c " + " slmgr /skms zh.us.to");
                    System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ato");
                    break;
                case 1:
                    // win home
                    Console.WriteLine("Are you sure you don't want to 'unofficially activate' windows?");
                    Console.WriteLine("please enter y to confirm");
                    if (Console.ReadLine() == "y")
                    {
                        Methodes.winactiv1();
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /skms kms.digiboy.ir");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ato");
                    }
                    else
                    {
                        Console.WriteLine("Please press 'Ctrl+C' to stop and close the program.");
                    }
                    break;
                case 2:
                    // win profesionel
                    Console.WriteLine("Are you sure you don't want to 'unofficially activate' windows?");
                    Console.WriteLine("please enter y to confirm");
                    if (Console.ReadLine() == "y")
                    {
                        
                        Methodes.winactiv1();
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /skms kms.digiboy.ir");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ato");
                    }
                    else
                    {
                        Console.WriteLine("Please press 'Ctrl+C' to stop and close the program.");
                    }
                    break;
                case 3:
                    //Enterprise 
                    Console.WriteLine("Are you sure you don't want to 'unofficially activate' windows?");
                    Console.WriteLine("please enter y to confirm");
                    if (Console.ReadLine() == "y")
                    {
                        Methodes.winactiv1();
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /skms kms.digiboy.ir");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ato");
                    }
                    else
                    {
                        Console.WriteLine("Please press 'Ctrl+C' to stop and close the program.");
                    }
                    break;
                case 4:
                    //Edukation
                    Console.WriteLine("Are you sure you don't want to 'unofficially activate' windows?");
                    Console.WriteLine("please enter y to confirm");
                    if (Console.ReadLine() == "y")
                    {
                        // win 
                        Methodes.winactiv1();
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /skms kms.digiboy.ir");
                        System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ato");
                    }
                    else
                    {
                        Console.WriteLine("Please press 'Ctrl+C' to stop and close the program.");
                    }
                    break;
                case 5:
                    //remove watermark
                    Console.WriteLine("Are you sure you don't want to 'unofficially activate' windows?");
                    Console.WriteLine("please enter y to confirm");
                    if (Console.ReadLine() == "y")
                    {
                        System.Diagnostics.Process.Start("cmd", "/c " + "taskkill /F /IM Explorer.exe");
                        System.Diagnostics.Process.Start("cmd", "/c " + "cd %windir%\\System32");
                        System.Diagnostics.Process.Start("cmd", "/c " + "takeown /f explorerframe.dll &&icacls explorerframe.dll /grant administrators:F");
                        System.Diagnostics.Process.Start("cmd", "/c " + "ren explorerframe.dll explorerframe.dll.backup");
                        System.Diagnostics.Process.Start("cmd", "/c " + "taskkill /im explorer.exe /f && explorer.exe");
                    }
                    else
                    {
                        Console.WriteLine("Please press 'Ctrl+C' to stop and close the program.");
                    }
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}