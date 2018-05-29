using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Administrators:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Administrators
	{
		public Administrators()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _passwd;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
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

