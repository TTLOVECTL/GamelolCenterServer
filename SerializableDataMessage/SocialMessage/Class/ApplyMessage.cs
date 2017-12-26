using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage.SocialMessage.Class
{
    /// <summary>
    /// 好友申请信息
    /// </summary>
    public class ApplyMessage
    {
        /// <summary>
        /// 申请者ID
        /// </summary>
        public int sendId;

        /// <summary>
        /// 被申请者ID
        /// </summary>
        public int acceptId;

        /// <summary>
        /// 被申请者是否同意
        /// </summary>
        public bool isAgree;


    }
}
