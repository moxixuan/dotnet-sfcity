using System;
using System.Collections.Generic;
using System.Text;

namespace sdk.request
{
    public class ProductDetail
    {
        /// <summary>
        /// string(64)	空	是	物品名称
        /// </summary>
        public string product_name { get; set; }
        /// <summary>
        /// int(11)	0	否	物品ID
        /// </summary>
        public int product_id { get; set; }
        /// <summary>
        /// int(11)	0	是	物品数量
        /// </summary>
        public int product_num { get; set; }
        /// <summary>
        /// int(11)	0	否	物品价格
        /// </summary>
        public int product_price { get; set; }
        /// <summary>
        /// string(64)	空	否	物品单位
        /// </summary>
        public string product_unit { get; set; }
        /// <summary>
        /// string(256)	空	否	备注
        /// </summary>
        public string product_remark { get; set; }
        /// <summary>
        /// string(1024)	空	否	详情
        /// </summary>
        public string item_detail { get; set; }
    }
}
