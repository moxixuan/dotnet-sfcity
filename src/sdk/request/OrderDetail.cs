using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace sdk.request
{
    public class OrderDetail
    {
        /// <summary>
        /// int(11)	0	是	用户订单总金额（单位：分）
        /// </summary>
        public int total_price { get; set; }

        /// <summary>
        /// int(11)	0	是	物品类型	枚举值见下面定义
        /// </summary>
        public int product_type { get; set; }

        /// <summary>
        /// int(11)	0	否	实收用户金额（单位：分）
        /// </summary>
        public int user_money { get; set; }

        /// <summary>
        /// int(11)	0	否	实付商户金额（单位：分）
        /// </summary>
        public int shop_money { get; set; }

        /// <summary>
        /// int(11)	0	是	物品重量（单位：克）
        /// </summary>
        public int weight_gram { get; set; }

        /// <summary>
        /// int(11)	0	否	物品体积（单位：升）
        /// </summary>
        public int volume_litre { get; set; }

        /// <summary>
        /// int(11)	0	否	商户收取的配送费（单位：分）
        /// </summary>
        public int delivery_money { get; set; }

        /// <summary>
        /// 	int(11)	0	是	物品个数
        /// </summary>
        public int product_num { get; set; }

        /// <summary>
        /// int(11)	0	是	物品种类个数
        /// </summary>
        public int product_type_num { get; set; }

        public List<ProductDetail> product_detail { get; set; }
    }
}
        