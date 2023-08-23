using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caseprogrammgroup
    {
        public static void caseprogrammgroup1()
        {
            //Programm group-install
            Console.WriteLine("Please enter a number to install all programs in this group");
            Console.WriteLine("[0] for Desktop Programs");
            Console.WriteLine("[1] for Gaming Programs");
            Console.WriteLine("[2] for Programming/Coding Programs");
            int input1 = 0;
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
            Int32.TryParse(Console.ReadLine(), out input1);
            switch (input1)
            {
                case 0:
                    //desktop

                    Methodes.collordangarus();
                    Console.WriteLine(">>> When this message appears ''Do you agree with all terms of the software agreement?'' <<<");
                    Console.WriteLine(">>> Accept it to continue with [Y] <<<");
                    Methodes.collorgood();

                    foreach (string searchstring in Dictionarys.desktop.Keys)
                    {
                        string install = Dictionarys.desktop[searchstring];
                        System.Diagnostics.Process.Start("cmd", "/c " + "winget search " + searchstring);
                        System.Diagnostics.Process.Start("cmd", "/c " + "winget install " + install);
                    }
                    break;

                case 1:
                    //gaming


                    Methodes.collordangarus();
                    Console.WriteLine(">>> When this message appears ''Do you agree with all terms of the software agreement?'' <<<");
                    Console.WriteLine(">>> Accept it to continue with [Y] <<<");
                    Methodes.collorgood();

                    foreach (string searchstring in Dictionarys.gaming.Keys)
                    {
                        string install = Dictionarys.gaming[searchstring];
                        System.Diagnostics.Process.Start("cmd", "/c " + "winget search " + searchstring);
                        System.Diagnostics.Process.Start("cmd", "/c " + "winget install " + install);
                    }
                    break;
                case 2:
                    //Programming/coding

                    Methodes.collordangarus();
                    Console.WriteLine(">>> When this message appears ''Do you agree with all terms of the software agreement?'' <<<");
                    Console.WriteLine(">>> Accept it to continue with [Y] <<<");
                    Methodes.collorgood();

                    foreach (string searchstring in Dictionarys.coding.Keys)
                    {
                        string install = Dictionarys.coding[searchstring];
                        System.Diagnostics.Process.Start("cmd", "/c " + "winget search " + searchstring);
                        System.Diagnostics.Process.Start("cmd", "/c " + "winget install " + install);
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