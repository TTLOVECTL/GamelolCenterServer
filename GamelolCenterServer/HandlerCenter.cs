using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using GamelolCenterServer.HandlerTool;
using SerializableDataMessage;
namespace GamelolCenterServer
{
    public class HandlerCenter : AbsHandleCenter
    {
        private HanderInterface authenticationHandler = null;
        private HanderInterface propetryHandler = null;
        private HanderInterface matchHandle = null;
        private HanderInterface socialHandler = null;

        public static SortedDictionary<int, UserToken> playerToken = new SortedDictionary<int, UserToken>();

        public HandlerCenter() {
            authenticationHandler = new AuthenticationHandler();
            propetryHandler = new PropetryHandler();
            matchHandle = new MatchHandler();
            socialHandler = new SocialHandler();
        }
        public override void ClientClose(UserToken token, string error)
        {
            Console.WriteLine("玩家ID:"+token.playerId+"断开了连接");
            if (HandlerCenter.playerToken.ContainsKey(token.playerId)) {
                HandlerCenter.playerToken.Remove(token.playerId);
            }
            
        }

        public override void MessageRecive(UserToken token, object message)
        {
            SocketModel modle = message as SocketModel;
            Console.WriteLine(modle.getMessage<string>());
            switch ((SerializableType)modle.type) {
                case SerializableType.AUTHENTICATION_TYPE:
                    authenticationHandler.MessageRecevie(token,modle);
                    break;
                case SerializableType.PROPETRY_TYPE:
                    if (token.playerId == 0) {
                        return;
                    }
                    propetryHandler.MessageRecevie(token,modle);
                    break;
                case SerializableType.SOCIAL_TYPE:
                    if (token.playerId == 0)
                    {
                        return;
                    }
                    socialHandler.MessageRecevie(token, modle);
                    break;
                case SerializableType.MATCH_TYPE:
                    if (token.playerId == 0)
                    {
                        return;
                    }
                    matchHandle.MessageRecevie(token, modle);
                    break;

            }
        }
    }
}
