using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;


namespace WNT
{
    public class Methodes
    {
        public static void collordangarus()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void collorgood()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void collortext()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
        }


        public static void collornotes()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void collorinput()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void winactiv1()
        {
            System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /upk");
            System.Diagnostics.Process.Start("cmd", "/c " + "slmgr.vbs /cpky");
            System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /ckms");
            System.Diagnostics.Process.Start("cmd", "/c " + "slmgr.vbs /ckms");
            System.Diagnostics.Process.Start("cmd", "/c " + "slmgr /skms localhost");
        }
    } 
}