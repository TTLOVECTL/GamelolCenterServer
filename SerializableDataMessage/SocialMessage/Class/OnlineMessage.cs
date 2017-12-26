using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage.SocialMessage.Class
{
    /// <summary>
    /// 上下线通知信息类
    /// </summary>
    public class OnlineMessage
    {
        /// <summary>
        /// 玩家ID
        /// </summary>
        public int onlinePlayerId;

        /// <summary>
        /// 是否在线
        /// </summary>
        public bool isOnline;
    }
}
