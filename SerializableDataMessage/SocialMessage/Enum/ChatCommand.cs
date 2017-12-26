using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage.SocialMessage.Enum
{
    /// <summary>
    /// 聊天信息发送指令集
    /// </summary>
    public enum ChatCommand
    {
        /// <summary>
        /// 信息发送给服务所有人
        /// </summary>
        ALL_COMMAND,
        /// <summary>
        /// 信息发生给指定好友
        /// </summary>
        FRIEND_COMMAND

    }
}
