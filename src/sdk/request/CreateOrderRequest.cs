using System;
using System.Collections.Generic;
using System.Text;

namespace sdk.request
{
    public class CreateOrderRequest
    {
		//int（11）	0	是	同城开发者ID	可在顺丰同城开放平台上自助申请
		public int? dev_id { get; set; }

		//	string（64）	0	是	店铺ID
		public string shop_id { get; set; }

		// 	int(11)	1	否	店铺ID类型	1：顺丰店铺ID ；2：接入方店铺ID
		public int? shop_type { get; set; }

		/// <summary>
		/// string(128)	空	是	商家订单号	不允许重复
		/// </summary>
		public string shop_order_id { get; set; }

		/// <summary>
		/// string(12)	空	是	订单接入来源	1：美团；2：饿了么；3：百度；4：口碑；其他请直接填写中文字符串值
		/// </summary>
		public string order_source { get; set; }

		/// <summary>
		/// string(12)	空	否	取货序号	与order_source配合使用
		/// 如：饿了么10号单，表示如下：
		/// order_source=2;order_sequence=10。
		/// 用于骑士快速寻找配送物
		/// </summary>
		public string order_sequence { get; set; }

		/// <summary>
		/// int（2）	2	否	坐标类型	1：百度坐标，2：高德坐标
		/// </summary>
		public int? lbs_type { get; set; }

		/// <summary>
		/// int（11）	1	是	用户支付方式	1：已付款 0：货到付款
		/// </summary>
		public int? pay_type { get; set; }

		/// <summary>
		/// int（11）	0	否	代收金额	单位：分
		/// </summary>
		public int? receive_user_money { get; set; }

		/// <summary>
		/// int（11）	0	是	用户下单时间	秒级时间戳
		/// </summary>
		public int? order_time { get; set; }

		/// <summary>
		/// int（2）	0	是	是否是预约单	0：非预约单；1：预约单
		/// </summary>
		public int? is_appoint { get; set; }

		/// <summary>
		/// int（2）	0	否	预约单类型	预约单的时候传入,1：预约单送达单；2：预约单上门单
		/// </summary>
		public int? appoint_type { get; set; }

        /// <summary>
        /// int（11）	0	否	用户期望送达时间	预约单需必传,秒级时间戳
        /// </summary>
        public int? expect_time { get; set; }

        public int? expect_pickup_time { get; set; }

        /// <summary>
        /// int（11）	0	是	是否保价，0：非保价；1：保价
        /// </summary>
        public int? is_insured { get; set; }

		/// <summary>
		/// int（11）	0	否	保价金额	单位：分
		/// </summary>
		public int? is_person_direct { get; set; }

		/// <summary>
		/// int（2）	0	否	配送交通工具，0：否；1：电动车；2：小轿车
		/// </summary>
		public int? vehicle { get; set; }

		/// <summary>
		/// int（11）	0	否	保价金额	单位：分
		/// </summary>
		public int? declared_value { get; set; }

		/// <summary>
		/// 	int（11）	0	否	订单小费，不传或者传0为不加小费	单位分，加小费最低不能少于100分
		/// </summary>
		public int? gratuity_fee { get; set; }

        /// <summary>
        /// string（1024）	空	否	订单备注
        /// </summary>
        public string remark { get; set; }

		/// <summary>
		/// int（11）	1	否	物流流向	1：从门店取件送至用户；
		/// 2：从用户取件送至门店
		/// </summary>
		public int? rider_pick_method { get; set; }

		/// <summary>
		/// int	1	否	返回字段控制标志位（二进制）	1：价格，2：距离，4：重量，组合条件请相加
		/// 例如全部返回为填入7
		/// </summary>
		public int? return_flag { get; set; }

		/// <summary>
		/// int（11）	0	是	推单时间	秒级时间戳
		/// </summary>
		public int? push_time { get; set; }

		/// <summary>
		/// int（11）	0	是	版本号	参照文档主版本号填写
		/// 如：文档版本号1.7,version=17
		/// </summary>
		public int? version { get; set; }

		/// <summary>
		/// OBJ	空	是	收货人信息	Obj，详见receive结构
		/// </summary>
		public Receive receive { get; set; }

		/// <summary>
		/// OBJ	空	否	发货店铺信息	Obj，详见shop结构，
		/// 平台级开发者（如饿了么）需传入
		/// 如无特殊说明此字段可忽略
		/// </summary>
		public Shop shop { get; set; }

		/// <summary>
		/// OBJ	空	是	订单详情	Obj，详见order_detail结构
		/// </summary>
		public OrderDetail order_detail { get; set; }
	}
}
