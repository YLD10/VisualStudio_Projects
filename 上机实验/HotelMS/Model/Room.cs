using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Room:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Room
	{
		public Room()
		{}
		#region Model
		private string _floornum;
		private string _roomid;
		private int _livestate;
		private int _cleanstate;
		private int _damagestate;
		private string _roomtypeid;
		private int _roomabandoned=1;
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
		public int liveState
		{
			set{ _livestate=value;}
			get{return _livestate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int cleanState
		{
			set{ _cleanstate=value;}
			get{return _cleanstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int damageState
		{
			set{ _damagestate=value;}
			get{return _damagestate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roomTypeID
		{
			set{ _roomtypeid=value;}
			get{return _roomtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int roomAbandoned
		{
			set{ _roomabandoned=value;}
			get{return _roomabandoned;}
		}
		#endregion Model

	}
}

