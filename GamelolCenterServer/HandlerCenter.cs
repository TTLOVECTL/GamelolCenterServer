﻿using System;
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

        public static SortedDictionary<int, UserToken> playerToken = new SortedDictionary<int, UserToken>();

        public HandlerCenter() {
            authenticationHandler = new AuthenticationHandler();
            propetryHandler = new PropetryHandler();
        }
        public override void ClientClose(UserToken token, string error)
        {
            Console.WriteLine("玩家"+token.playerId+"断开了连接");
            if (HandlerCenter.playerToken.ContainsKey(token.playerId)) {
                HandlerCenter.playerToken.Remove(token.playerId);
            }
            
        }

        public override void MessageRecive(UserToken token, object message)
        {
            SocketModel modle = message as SocketModel;
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
            }
        }
    }
}