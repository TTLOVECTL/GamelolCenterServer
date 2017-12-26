using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage.SocialMessage.Class
{
    /// <summary>
    /// 玩家之间的聊天信息
    /// </summary>
    public class ChatMessage
    {
        /// <summary>
        /// 发送者ID
        /// </summary>
        public int SenderID;

        /// <summary>
        /// 接受者ID
        /// </summary>
        public int reciverId;

        /// <summary>
        /// 聊天信息内容
        /// </summary>
        public string message;

    }
}
