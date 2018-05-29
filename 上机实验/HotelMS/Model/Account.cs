using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Account
	{
		public Account()
		{}
		#region Model
		private string _cusid;
		private string _floornum;
		private string _roomid;
		private decimal _income;
		/// <summary>
		/// 
		/// </summary>
		public string cusID
		{
			set{ _cusid=value;}
			get{return _cusid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string floorNum
		{
			set{ _floornum=value;}
			get{return _floornum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roomID
		{
			set{ _roomid=value;}
			get{return _roomid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal income
		{
			set{ _income=value;}
			get{return _income;}
		}
		#endregion Model

	}
}

