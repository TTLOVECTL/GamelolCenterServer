using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;

namespace GamelolCenterServer
{
    public class HandlerCenter : AbsHandleCenter
    {
        public override void ClientClose(UserToken token, string error)
        {
            throw new NotImplementedException();
        }

        public override void MessageRecive(UserToken token, object message)
        {
            SocketModel modle = message as SocketModel;
            //throw new NotImplementedException();
        }
    }
}
