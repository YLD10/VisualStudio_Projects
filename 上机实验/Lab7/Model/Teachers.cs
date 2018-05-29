using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Teachers:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Teachers
	{
		public Teachers()
		{}
		#region Model
		private string _id;
		private string _teaname;
		private int _teasex;
		private string _teatitle;
		private string _passwd;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string teaName
		{
			set{ _teaname=value;}
			get{return _teaname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int teaSex
		{
			set{ _teasex=value;}
			get{return _teasex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string teaTitle
		{
			set{ _teatitle=value;}
			get{return _teatitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string passwd
		{
			set{ _passwd=value;}
			get{return _passwd;}
		}
		#endregion Model

	}
}

