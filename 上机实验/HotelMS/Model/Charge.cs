using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Charge:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Charge
	{
		public Charge()
		{}
		#region Model
		private string _cusid;
		private string _manid="离职";
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
		public string manID
		{
			set{ _manid=value;}
			get{return _manid;}
		}
		#endregion Model

	}
}

