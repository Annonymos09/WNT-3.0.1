using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class casemsoffice
    {
        public static void casemsoffice1()
        {
            //activate office
            Console.WriteLine("[0] = install office 365");
            Console.WriteLine("[1] = activate office 365");
            //start switch 
            int input3 = 0;
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
            Int32.TryParse(Console.ReadLine(), out input3);

            switch (input3)
            {
                //case 0
                //
                //case 0
                
                case 0:
                    Methodes.collorgood();
                    string currentDirectory2 = System.IO.Directory.GetCurrentDirectory();
                    string relativePath2 = @"cases\install64.bat";
                    string fullPath2 = System.IO.Path.Combine(currentDirectory2, relativePath2);
                    System.Diagnostics.Process.Start(fullPath2);
                    Console.ReadLine();

                    Methodes.collordangarus();
                    Console.WriteLine(">>> Please enter the number to start the next programm <<<");
                    Methodes.collorinput();
                    Console.Write("WNT>>>");
                    Methodes.collortext();
                    break;
                //case 1
                //
                //case 1
                case 1:
                    Methodes.collorgood();
                    string currentDirectory1 = System.IO.Directory.GetCurrentDirectory();
                    string relativePath1 = @"cases\office-2019-activate.bat";
                    string fullPath1 = System.IO.Path.Combine(currentDirectory1, relativePath1);
                    System.Diagnostics.Process.Start(fullPath1);
                    Console.ReadKey();
                    Console.ReadLine();

                    Methodes.collordangarus();
                    Console.WriteLine(">>> Please enter the number to start the next programm <<<");
                    Methodes.collorinput();
                    Console.Write("WNT>>>");
                    Methodes.collortext();
                    break;
                default:
                    Methodes.collordangarus();
                    Console.WriteLine(">>> Invalid operation <<<");
                    Methodes.collordangarus();
                    Console.WriteLine(">>> Please enter a number to start a programm <<<");
                    Methodes.collorgood();
                    break;
            }

        }
    }
}