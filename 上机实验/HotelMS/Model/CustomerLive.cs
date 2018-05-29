using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// CustomerLive:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CustomerLive
	{
		public CustomerLive()
		{}
		#region Model
		private DateTime _startlivetime;
		private DateTime _proendlivetime;
		private DateTime _endlivetime;
		private string _cusid;
		private string _floornum;
		private string _roomid;
		private int _isaccount;
		/// <summary>
		/// 
		/// </summary>
		public DateTime startLiveTime
		{
			set{ _startlivetime=value;}
			get{return _startlivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime proEndLiveTime
		{
			set{ _proendlivetime=value;}
			get{return _proendlivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime endLiveTime
		{
			set{ _endlivetime=value;}
			get{return _endlivetime;}
		}
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
		public string floorNum
		{
			set{ _floornum=value;}
			get{return _floornum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roomID
		{
			set{ _roomid=value;}
			get{return _roomid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int isAccount
		{
			set{ _isaccount=value;}
			get{return _isaccount;}
		}
		#endregion Model

	}
}

