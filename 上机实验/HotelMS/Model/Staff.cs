using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Staff:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Staff
	{
		public Staff()
		{}
		#region Model
		private string _staid;
		private string _staname;
		private string _stasex;
		private int _staage;
		private byte[] _staphoto;
		/// <summary>
		/// 
		/// </summary>
		public string staID
		{
			set{ _staid=value;}
			get{return _staid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string staName
		{
			set{ _staname=value;}
			get{return _staname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string staSex
		{
			set{ _stasex=value;}
			get{return _stasex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int staAge
		{
			set{ _staage=value;}
			get{return _staage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] staPhoto
		{
			set{ _staphoto=value;}
			get{return _staphoto;}
		}
		#endregion Model

	}
}

