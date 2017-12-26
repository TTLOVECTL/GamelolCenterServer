using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using GamelolCenterServer.HandlerTool;
using SerializableDataMessage;
using GamelolCenterServer.SocialServer;
using SerializableDataMessage.SocialMessage.Enum;
using SerializableDataMessage.SocialMessage.Class;
using GamelolCenterServer.Util;
using LitJson;
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
            SocketModel model = new SocketModel();
            model.type = token.playerId;
            model.area = (int)SocialArea.FRIEND_AREA;
            model.command = (int)FriendCommand.INFORM_COMMADN;
            OnlineMessage onlineMessage = new OnlineMessage();
            onlineMessage.onlinePlayerId = token.playerId;
            onlineMessage.isOnline = false;
            model.message = LitJson.JsonMapper.ToJson(onlineMessage);
            SocialNetWork.Instance.write(model);
            
        }

        public override void MessageRecive(UserToken token, object message)
        {
            SocketModel modle = message as SocketModel;
            switch ((SerializableType)modle.type) {
                case SerializableType.AUTHENTICATION_TYPE:
                    InputFormat.ConsoleWriteLineMessage("用户身份验证指令", JsonMapper.ToJson(modle));
                    authenticationHandler.MessageRecevie(token,modle);
                    break;
                case SerializableType.PROPETRY_TYPE:
                    if (token.playerId == 0) {
                        return;
                    }
                    InputFormat.ConsoleWriteLineMessage("发送给商城服务器",JsonMapper.ToJson(modle));
                    propetryHandler.MessageRecevie(token,modle);
                    break;
                case SerializableType.SOCIAL_TYPE:
                    if (token.playerId == 0)
                    {
                        return;
                    }
                    InputFormat.ConsoleWriteLineMessage("发送给社交服务器", JsonMapper.ToJson(modle));
                    socialHandler.MessageRecevie(token, modle);
                    break;
                case SerializableType.MATCH_TYPE:
                    if (token.playerId == 0)
                    {
                        return;
                    }
                    InputFormat.ConsoleWriteLineMessage("发送给匹配服务器", JsonMapper.ToJson(modle));
                    matchHandle.MessageRecevie(token, modle);
                    break;

            }
        }
    }
}
