using System;
using System.Collections.Generic;
using System.Text;

namespace sdk.request
{
    public class Shop
    {
        /// <summary>
        /// string（64）	空	是	店铺名称
        /// </summary>
        public string shop_name { get; set; }

        /// <summary>
        /// string（64）	空	是	店铺电话
        /// </summary>
        public string shop_phone { get; set; }

        /// <summary>
        /// string（255）	空	是	店铺地址
        /// </summary>
        public string shop_address { get; set; }

        /// <summary>
        /// string（32）	空	否	店铺经度
        /// </summary>
        public string shop_lng { get; set; }

        /// <summary>
        /// string（32）	空	否	店铺纬度	
        /// </summary>
        public string shop_lat { get; set; }
    }
}
