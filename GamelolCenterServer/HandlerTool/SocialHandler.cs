using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using GamelolCenterServer.SocialServer;

namespace GamelolCenterServer.HandlerTool
{
    public class SocialHandler : HanderInterface
    {
        public void ClientClose(UserToken token)
        {
            throw new NotImplementedException();
        }

        public void MessageRecevie(UserToken token, SocketModel message)
        {
            message.type = token.playerId;
            ///将信息转发给社交服务器
            SocialNetWork.Instance.write(message);
        }
    }
}
