using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using SerializableDataMessage;
using LitJson;
using GamelolCenterServer.SocialServer;
using SerializableDataMessage.SocialMessage.Enum;
using SerializableDataMessage.SocialMessage.Class;

namespace GamelolCenterServer.HandlerTool
{
    public class AuthenticationHandler : HanderInterface
    {
        public void ClientClose(UserToken token)
        {
            throw new NotImplementedException();
        }

        public void MessageRecevie(UserToken token, SocketModel message)
        {
            AuthenticationMessage authenticationMessage =JsonMapper.ToObject<AuthenticationMessage>(message.getMessage<string>());
            token.playerId = authenticationMessage.playerId;
            HandlerCenter.playerToken.Add(token.playerId, token);
            SocketModel model = new SocketModel();
            model.type = token.playerId;
            model.area = (int)SocialArea.FRIEND_AREA;
            model.command = (int)FriendCommand.INFORM_COMMADN;

            OnlineMessage onlineMessage = new OnlineMessage();
            onlineMessage.onlinePlayerId = token.playerId;
            onlineMessage.isOnline = true;
            model.message = LitJson.JsonMapper.ToJson(onlineMessage);
            SocialNetWork.Instance.write(model);
        }
    }
}
