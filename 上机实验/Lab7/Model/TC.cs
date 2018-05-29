using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// TC:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TC
	{
		public TC()
		{}
		#region Model
		private string _teaid;
		private string _couid;
		/// <summary>
		/// 
		/// </summary>
		public string teaID
		{
			set{ _teaid=value;}
			get{return _teaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string couID
		{
			set{ _couid=value;}
			get{return _couid;}
		}
		#endregion Model

	}
}

