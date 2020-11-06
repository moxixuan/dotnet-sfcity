using System;
using System.Collections.Generic;
using System.Text;

namespace sdk.request
{
    public class Receive
    {
        /// <summary>
        /// string（64）	空	是	用户姓名	
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// string（64）	空	是	用户电话	
        /// </summary>
        public string user_phone { get; set; }
        /// <summary>
        /// string（255）	空	是	用户地址	
        /// </summary>
        public string user_address { get; set; }
        /// <summary>
        /// string（32）	空	是	用户经度
        /// </summary>
        public string user_lng { get; set; }
        /// <summary>
        /// string（32）	空	是	用户纬度	 
        /// </summary>
        public string user_lat { get; set; }
        /// <summary>
        /// string（32）	空	否	发单城市	用来校验是否跨城；请填写城市的中文名称，如北京市、深圳市
        /// </summary>
        public string city_name { get; set; }
    }
}
