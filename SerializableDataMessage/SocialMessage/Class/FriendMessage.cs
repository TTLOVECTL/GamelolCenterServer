using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage.SocialMessage.Class
{
    /// <summary>
    /// 好友信息类
    /// </summary>
    public class FriendMessage
    {
        /// <summary>
        /// 好友ID
        /// </summary>
        public int friendId;

        /// <summary>
        /// 好友昵称
        /// </summary>
        public String friendName;

        /// <summary>
        /// 好友是否在线
        /// </summary>
        public bool isOnline;

        /// <summary>
        /// 好友头像
        /// </summary>
        public string headImage;

        /// <summary>
        /// 好友账户是否存在
        /// </summary>
        public bool isExit;

        /// <summary>
        /// 是否已是自己的好友
        /// </summary>
        public bool isHave;
    }
}
