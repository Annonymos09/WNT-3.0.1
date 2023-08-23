using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using WNT;


namespace right_consol.materiels
{
    public class caselicense
    {
        public static void caselicense1()
        {
            string copyright = @"Copyright (c) 2023 Anonymous09

""Permission is hereby granted, free of charge, to any person obtaining a copy of this 
software and associated documentation files (the ""Software""), to use, copy, modify, merge,
publish, distribute, sublicense, and/or sell copies of the Software, subject to the following conditions:

- The above copyright notice and this permission notice must be included in all copies or substantial portions of the Software.
- The license tab of the Software may not be modified in any way.
- The software may not be used to harm people or machines.

THE SOFTWARE IS PROVIDED ""AS IS"" WITHOUT WARRANTY OF ANY KIND, EITHER
EXPRESS OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, THE WARRANTIES OF 
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIMS, 
DAMAGES OR OTHER LIABILITIES ARISING OUT OF ANY BREACH OF CONTRACT, 
TORT OR OTHERWISE ARISING IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";

            Console.WriteLine(copyright);
            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}