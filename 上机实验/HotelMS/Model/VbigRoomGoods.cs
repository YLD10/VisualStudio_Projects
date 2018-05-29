using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// VbigRoomGoods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VbigRoomGoods
	{
		public VbigRoomGoods()
		{}
		#region Model
		private string _goodsid;
		private string _goodsname;
		private decimal _goodsprice;
		private string _roomtypeid;
		/// <summary>
		/// 
		/// </summary>
		public string goodsID
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string goodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal goodsPrice
		{
			set{ _goodsprice=value;}
			get{return _goodsprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roomTypeID
		{
			set{ _roomtypeid=value;}
			get{return _roomtypeid;}
		}
		#endregion Model

	}
}

