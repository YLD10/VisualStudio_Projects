using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Customer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Customer
	{
		public Customer()
		{}
		#region Model
		private string _cusid;
		private string _cusname;
		private string _cussex;
		private int _cusage;
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
		public string cusName
		{
			set{ _cusname=value;}
			get{return _cusname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cusSex
		{
			set{ _cussex=value;}
			get{return _cussex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cusAge
		{
			set{ _cusage=value;}
			get{return _cusage;}
		}
		#endregion Model

	}
}

