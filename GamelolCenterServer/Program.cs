using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using System.Threading;

namespace GamelolCenterServer
{
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                NetServer server = new NetServer(100);
                server.lengthEncode = LengthEncoding.encode;
                server.lengthDecode = LengthEncoding.decode;
                server.serDecode = MessageEncoding.Decode;
                server.serEncode = MessageEncoding.Encode;
                server.center = new HandlerCenter();
                server.init();
                server.Start(2001);
            }
            catch (Exception e)
            {
                Console.WriteLine("Server Error " + e.TargetSite);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
            }
            while (true)
            {
                Thread.Sleep(360000);
            }

        }
        
    }
}
