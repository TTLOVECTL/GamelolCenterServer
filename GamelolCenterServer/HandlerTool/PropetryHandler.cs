using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
using GamelolCenterServer.PropetryServer;

namespace GamelolCenterServer.HandlerTool
{
    public class PropetryHandler : HanderInterface
    {
        public void ClientClose(UserToken token)
        {
            throw new NotImplementedException();
        }

        public void MessageRecevie(UserToken token, SocketModel message)
        {
            message.type = token.playerId;
            //信息转发给商场、道具等服务器
            PropetryNetWork.Instance.write(message);
        }
    }
}
