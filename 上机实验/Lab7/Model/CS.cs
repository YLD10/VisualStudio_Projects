using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// CS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CS
	{
		public CS()
		{}
		#region Model
		private string _couid;
		private string _stuid;
		private string _teaid;
		private decimal? _score;
		/// <summary>
		/// 
		/// </summary>
		public string couID
		{
			set{ _couid=value;}
			get{return _couid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuID
		{
			set{ _stuid=value;}
			get{return _stuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string teaID
		{
			set { _teaid = value; }
			get { return _teaid; }
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model

	}
}

