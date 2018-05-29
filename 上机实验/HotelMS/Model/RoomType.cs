using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// RoomType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RoomType
	{
		public RoomType()
		{}
		#region Model
		private string _roomtypeid;
		private decimal _roomtypeprice;
		/// <summary>
		/// 
		/// </summary>
		public string roomTypeID
		{
			set{ _roomtypeid=value;}
			get{return _roomtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal roomTypePrice
		{
			set{ _roomtypeprice=value;}
			get{return _roomtypeprice;}
		}
		#endregion Model

	}
}

