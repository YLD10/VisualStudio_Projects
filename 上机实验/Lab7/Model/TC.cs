using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// TC:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class TC
	{
		public TC()
		{}
		#region Model
		private string _teaid;
		private string _couid;
		/// <summary>
		/// 
		/// </summary>
		public string teaID
		{
			set{ _teaid=value;}
			get{return _teaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string couID
		{
			set{ _couid=value;}
			get{return _couid;}
		}
		#endregion Model

	}
}

