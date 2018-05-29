using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// CustomerHistoryRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CustomerHistoryRecord
	{
		public CustomerHistoryRecord()
		{}
		#region Model
		private string _cusid;
		private int _historytimes;
		private decimal _discountrate;
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
		public int historyTimes
		{
			set{ _historytimes=value;}
			get{return _historytimes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal discountRate
		{
			set{ _discountrate=value;}
			get{return _discountrate;}
		}
		#endregion Model

	}
}

