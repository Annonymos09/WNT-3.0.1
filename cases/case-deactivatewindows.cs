using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class casedeactivatewin
    {
        public static void casedeactivatewin1()
        {
            //deactivate win update
            Console.WriteLine(">>> Please press [d] to deactivate Windows auto updates <<<");
            Console.WriteLine(">>> Please press [a] to activate Windows auto updates <<<");
            Console.WriteLine(">>> Press 'Ctrl+C' to close the completed program. <<<");

            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
            if (Console.ReadLine() == "d")
            {
                System.Diagnostics.Process.Start("cmd", "/c " + "net stop wuauserv");
                System.Diagnostics.Process.Start("cmd", "/c " + "net stop bits");
                System.Diagnostics.Process.Start("cmd", "/c " + "net stop dosvc");
            }
            //activate win update
            else
            {
                Methodes.collordangarus();
                Console.WriteLine("The input is invalid!");
                Console.WriteLine(">>> If you encounter any problems, please contact the program administrator or go to the support tab within the program. <<<");
                Methodes.collorgood();
                Console.ReadKey();
            }



            if (Console.ReadLine() == "a")
            {
                System.Diagnostics.Process.Start("cmd", "/c " + "net start wuauserv");
                System.Diagnostics.Process.Start("cmd", "/c " + "net start bits");
                System.Diagnostics.Process.Start("cmd", "/c " + "net start dosvc");
            }
            else
            {
                Methodes.collordangarus();
                Methodes.collorgood();
                Console.ReadKey();
            }
        }
    }
}