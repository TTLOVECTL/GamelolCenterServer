﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceNetFrame.ace;
using AceNetFrame.ace.auto;
namespace GamelolCenterServer
{
    public interface HanderInterface
    {
        void MessageRecevie(UserToken token, SocketModel message);
        void ClientClose(UserToken token);
    }
}
