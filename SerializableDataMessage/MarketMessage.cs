using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDataMessage
{
    /// <summary>
    /// 商场信息类
    /// </summary>
    [Serializable]
    public class MarketMessage
    {
        /// <summary>
        /// 商品类型
        /// </summary>
        public GoodType goodType;

        /// <summary>
        /// 商品ID
        /// </summary>
        public int goodId;

        /// <summary>
        /// 物品数量
        /// </summary>
        public int goodNumber;

        /// <summary>
        /// 物品价格
        /// </summary>
        public int goodPrice;

        /// <summary>
        /// 物品使用的货币
        /// </summary>
        public MoneyType moneyType;
    }
}
