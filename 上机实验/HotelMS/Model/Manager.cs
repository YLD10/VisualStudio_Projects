using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Manager:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Manager
	{
		public Manager()
		{}
		#region Model
		private string _manid;
		private string _manname;
		private string _mansex;
		private int _manage;
		private string _passwd= "123456";
		private byte[] _manphoto;
		/// <summary>
		/// 
		/// </summary>
		public string manID
		{
			set{ _manid=value;}
			get{return _manid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string manName
		{
			set{ _manname=value;}
			get{return _manname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string manSex
		{
			set{ _mansex=value;}
			get{return _mansex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int manAge
		{
			set{ _manage=value;}
			get{return _manage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string passwd
		{
			set{ _passwd=value;}
			get{return _passwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] manPhoto
		{
			set{ _manphoto=value;}
			get{return _manphoto;}
		}
		#endregion Model

	}
}

