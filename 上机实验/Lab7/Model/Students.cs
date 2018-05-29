using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Students:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Students
	{
		public Students()
		{}
		#region Model
		private string _id;
		private string _stuname;
		private int _stusex;
		private string _stucollege;
		private string _stumajor;
		private string _stuclass;
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
		public string stuName
		{
			set{ _stuname=value;}
			get{return _stuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int stuSex
		{
			set{ _stusex=value;}
			get{return _stusex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuCollege
		{
			set{ _stucollege=value;}
			get{return _stucollege;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuMajor
		{
			set{ _stumajor=value;}
			get{return _stumajor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuClass
		{
			set{ _stuclass=value;}
			get{return _stuclass;}
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

