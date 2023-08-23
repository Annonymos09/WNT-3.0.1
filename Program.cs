using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using right_consol.materiels;

namespace WNT
{

    class Programm
    {
        public static void Main(string[] args)
        {

            string pictur = @"  

                                                                                  
                      _____          _____   ______   _________________ 
                     |\    \   _____|\    \ |\     \ /                 \
                     | |    | /    /|\\    \| \     \\______     ______/
                     \/     / |    || \|    \  \     |  \( /    /  )/   
                     /     /_  \   \/  |     \  |    |   ' |   |   '    
                    |     // \  \   \  |      \ |    |     |   |        
                    |    |/   \ |    | |    |\ \|    |    /   //        
                    |\ ___/\   \|   /| |____||\_____/|   /___//         
                    | |   | \______/ | |    |/ \|   ||  |`   |          
                     \|___|/\ |    | | |____|   |___|/  |____|          
                        \(   \|____|/    \(       )/      \(            
                         '      )/        '       '        '            
                                '                                                                   

                                  Windows Network Tool

                   ";
            Methodes.collorgood();
            Console.WriteLine(pictur);
            Console.WriteLine("<----------------------------------------------Setup---------------------------------------------->");
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("[0] = to help");
                Methodes.collorinput();
                Console.Write("WNT>>>");
                Methodes.collortext();
                
                
                

            bool isRunning = true;
                while (isRunning)
                {
                    //start switch 
                    int oZahl = 0;
                    Int32.TryParse(Console.ReadLine(), out oZahl);

                    switch (oZahl)
                    {



                        //case 0
                        //
                        //case 0
                        case 0:
                            //help
                            casehelp.casehelp1(); 
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-1
                        //
                        //case-1
                        case 1:
                        //about WNT
                        caselicense.caselicense1();
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-2
                        //
                        //case-2
                        case 2:
                            //IP steads anzeigen 
                            caseIP.caseIP1();
                        break;



//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-3
                        //
                        //case-3
                        case 3:
                            //scanning Network
                            casescannetwork.casescannetwork1();
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-4
                        //
                        //case-4
                        case 4:
                            //ping a ip ore a Hostname
                            casepingIP.casepingIP1();
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-5
                        //
                        //case-5
                        case 5:
                            //mrt
                            casemrt.casemrt1();
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-6
                        //
                        //case-6
                        case 6:
                            checkdisk.checkdisk1();
                            break;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-6
                        //
                        //case-6
                        case 7:
                            // repair Win system fil
                            caserepairwinfilesystem.caserepairwinfilesystem1();
                            isRunning = false;

                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-8
                        //
                        //case-8
                        case 8:
                            //repair Win hard online
                            caserepairwinsystem.caserepairwinsystem1();

                            isRunning = false;

                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-9
                        //
                        //case-9
                        case 9:
                            //repairwinmwdia
                            caserepairmedia.caserepairmedia1();


                        break;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-10
                        //
                        //case-10
                        case 10:
                            //update Windows 
                            caseupdatewindows.caseupdatewindows1();
                            isRunning = false;

                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-11
                        //
                        //case-11
                        case 11:
                            //update windows programm 
                            casewinprogr.casewinprogr1();

                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-12
                        //
                        //case-12
                        case 12:
                            //diskpart
                            casediskpart.casediskpart1();     
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-13
                        //
                        //case-13
                        case 13:
                            //Programm group-install
                            caseprogrammgroup.caseprogrammgroup1();

                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-14
                        //    
                        //case-14
                        case 14:
                            //deactivate win update
                            casedeactivatewin.casedeactivatewin1();
                        break;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                        //case-15
                        //     
                        //case-15
                        case 15:
                            //activate windows
                            caseactivatewin.caseactivatewin1(); 
                        break;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                    //case-16
                    //     
                    //case-16
                    case 16:
                        //deactive-defender
                        Process.Start("cmd", "/c " + "sc stop WinDefend");
                        Methodes.collordangarus();
                        Console.WriteLine(">>> Please enter the number to start the next programm <<<");
                        Methodes.collorgood();

                        break;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                    //case-17
                    //     
                    //case-17
                    case 17:
                        //active-defender
                        Process.Start("cmd", "/c " + "sc start WinDefend");
                        Methodes.collordangarus();
                        Console.WriteLine(">>> Please enter the number to start the next programm <<<");
                        Methodes.collorgood();

                        break;

                    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                    //case-18
                    //     
                    //case-18
                    case 18:
                        //opti win
                        Methodes.collorgood();
                        string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                        string relativePath = @"cases\opti.bat";
                        string fullPath = System.IO.Path.Combine(currentDirectory, relativePath);
                        System.Diagnostics.Process.Start(fullPath);

                        Methodes.collordangarus();
                        Console.WriteLine(">>> Please enter the number to start the next programm <<<");
                        Methodes.collorinput();
                        Console.Write("WNT>>>");
                        Methodes.collortext();
                        break;

                    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                    //case-19
                    //     
                    //case-19
                    case 19:
                        casemsoffice.casemsoffice1();
                        break;
                            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                    //default
                    //  
                    //default
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
}


