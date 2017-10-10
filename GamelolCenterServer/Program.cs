using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using System.Threading;
using GamelolCenterServer.Util;
using GamelolCenterServer.LogServer;
namespace GamelolCenterServer
{
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                NetServer server = new NetServer(1000);
                server.lengthEncode = LengthEncoding.encode;
                server.lengthDecode = LengthEncoding.decode;
                server.serDecode = MessageEncoding.Decode;
                server.serEncode = MessageEncoding.Encode;
                server.center = new HandlerCenter();
                server.init();
                server.Start(int.Parse(ConfigurationSetting.GetConfigurationValue("centerServerPort")));
            }
            catch (Exception e)
            {
                Console.WriteLine("Server Error " + e.TargetSite);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
            }
            SystemLogSystem.Instance.SendMessageToLogServer();

        }
        
    }
}
