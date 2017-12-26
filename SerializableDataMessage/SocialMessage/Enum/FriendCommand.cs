using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage.SocialMessage.Enum
{
    /// <summary>
    /// 好友信息变更指令集
    /// </summary>
    public enum FriendCommand
    {
        /// <summary>
        /// 添加聊天好友
        /// </summary>
        ADD_COMMAND,

        /// <summary>
        /// 查找聊天好友
        /// </summary>
        FIND_COMMAND,

        /// <summary>
        /// 删除聊天好友
        /// </summary>
        DELETE_COMMAND,

        /// <summary>
        /// 接受好友申请
        /// </summary>
        ACCEPT_COMMAND,

        /// <summary>
        /// 获取好友列表
        /// </summary>
        GET_COMMAND,

        /// <summary>
        /// 好友上线下线通知
        /// </summary>
        INFORM_COMMADN

    }
}
