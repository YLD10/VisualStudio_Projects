using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Clean:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Clean
	{
		public Clean()
		{}
		#region Model
		private string _floornum;
		private string _staid;
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
		public string staID
		{
			set{ _staid=value;}
			get{return _staid;}
		}
		#endregion Model

	}
}

