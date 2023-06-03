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
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    // Specify the name of the EXE file
                    string exeName = @"cases\OfficeSetup.exe";

                    // Combine the base directory and the EXE name to get the full path
                    string exePath = Path.Combine(baseDirectory, exeName);

                    // Create a new process instance
                    Process process = new Process();

                    try
                    {
                        // Set the StartInfo properties
                        process.StartInfo.FileName = exePath;
                        // Add any command line arguments if required
                        // process.StartInfo.Arguments = "arg1 arg2";

                        // Start the process
                        process.Start();

                        // Wait for the process to exit
                        process.WaitForExit();

                        // Get the exit code
                        int exitCode = process.ExitCode;

                        // Process completed successfully
                        Console.WriteLine("Process exited with code: " + exitCode);
                    }
                    catch (Exception ex)
                    {
                        // An error occurred
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {
                        // Close the process to release resources
                        process.Close();
                        Methodes.collordangarus();
                    }
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