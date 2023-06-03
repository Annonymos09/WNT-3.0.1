using System.Net.NetworkInformation;
using WNT;

namespace right_consol.materiels
{
    public class casepingIP
    {
        public static void casepingIP1()
        {
            //ping a ip ore a Hostname
            try
            {
                
                Ping myPing = new Ping();
                Console.WriteLine("Please enter a Ip ore a Hostname !");
                Methodes.collorinput();
                Console.Write("WNT>>>");
                Methodes.collortext();
                PingReply reply = myPing.Send(Console.ReadLine(), 1000);
                if (reply != null)
                {
                    Console.WriteLine(" Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    //Console.WriteLine(reply.ToString());
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("COMSPEC"), "/C " + "start " + "http://" + reply.Address);
                }
            }
            catch
            {
                Methodes.collordangarus();
                Console.WriteLine("ERROR: your Ip ore Hostname is invalide");
            }
            Console.ReadKey();
            Methodes.collordangarus();
            Console.WriteLine(">>> Please enter the number to start the next programm <<<");
            Methodes.collorinput();
            Console.Write("WNT>>>");
            Methodes.collortext();
        }
    }
}