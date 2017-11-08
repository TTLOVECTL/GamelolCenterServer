using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using GamelolCenterServer.MatchServer;

namespace GamelolCenterServer.HandlerTool
{
    public class MatchHandler : HanderInterface
    {
        public void ClientClose(UserToken token)
        {
            throw new NotImplementedException();
        }

        public void MessageRecevie(UserToken token, SocketModel message)
        {
            message.type = token.playerId;
            //信息转发给匹配服务器
           MatchNetWork.Instance.write(message);
        }
    }
}
