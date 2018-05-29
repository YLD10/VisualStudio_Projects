using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Courses:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Courses
	{
		public Courses()
		{}
		#region Model
		private string _id;
		private string _couname;
		private int _coutime;
		private decimal _coupoint;
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
		public string couName
		{
			set{ _couname=value;}
			get{return _couname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int couTime
		{
			set{ _coutime=value;}
			get{return _coutime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal couPoint
		{
			set{ _coupoint=value;}
			get{return _coupoint;}
		}
		#endregion Model

	}
}

