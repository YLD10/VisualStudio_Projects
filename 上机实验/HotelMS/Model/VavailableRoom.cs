using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// VavailableRoom:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VavailableRoom
	{
		public VavailableRoom()
		{}
		#region Model
		private string _floornum;
		private string _roomid;
		private int _livestate;
		private string _roomtypeid;
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
		public string roomTypeID
		{
			set{ _roomtypeid=value;}
			get{return _roomtypeid;}
		}
		#endregion Model

	}
}

