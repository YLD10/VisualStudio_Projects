using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// CustomerLive
	/// </summary>
	public partial class CustomerLive
	{
		private readonly Maticsoft.DAL.CustomerLive dal=new Maticsoft.DAL.CustomerLive();
		public CustomerLive()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(DateTime startLiveTime,string cusID,string floorNum,string roomID)
		{
			return dal.Exists(startLiveTime,cusID,floorNum,roomID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Add(Maticsoft.Model.CustomerLive model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.CustomerLive model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(DateTime startLiveTime,string cusID,string floorNum,string roomID)
		{
			
			return dal.Delete(startLiveTime,cusID,floorNum,roomID);
		}


		#region 自定义

		/// <summary>
		/// 删除多条数据
		/// </summary>
		public bool DeleteCustomerLive(string strWhere)
		{

			return dal.DeleteCustomerLive(strWhere);
		}
		#endregion

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.CustomerLive GetModel(DateTime startLiveTime,string cusID,string floorNum,string roomID)
		{
			
			return dal.GetModel(startLiveTime,cusID,floorNum,roomID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.CustomerLive GetModelByCache(DateTime startLiveTime,string cusID,string floorNum,string roomID)
		{
			
			string CacheKey = "CustomerLiveModel-" + startLiveTime+cusID+floorNum+roomID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(startLiveTime,cusID,floorNum,roomID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.CustomerLive)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}


		#region 自定义

		/// <summary>
		/// 获取多条数据
		/// </summary>
		public DataSet GetListCustomerLive(string strWhere)
		{

			return dal.GetListCustomerLive(strWhere);
		}
		#endregion

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.CustomerLive> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.CustomerLive> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.CustomerLive> modelList = new List<Maticsoft.Model.CustomerLive>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.CustomerLive model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

