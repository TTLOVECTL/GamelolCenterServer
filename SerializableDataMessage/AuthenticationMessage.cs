using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage
{
    /// <summary>
    /// 身份验证信息类
    /// </summary>
    [Serializable]
    public class AuthenticationMessage
    {
        /// <summary>
        /// 玩家ID
        /// </summary>
        public int playerId;

        /// <summary>
        /// 玩家名称
        /// </summary>
        public string playerName;
    }
}
