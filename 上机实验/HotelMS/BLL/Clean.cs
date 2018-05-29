﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// Clean
	/// </summary>
	public partial class Clean
	{
		private readonly Maticsoft.DAL.Clean dal=new Maticsoft.DAL.Clean();
		public Clean()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string floorNum,string staID)
		{
			return dal.Exists(floorNum,staID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Clean model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Clean model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string floorNum,string staID)
		{
			
			return dal.Delete(floorNum,staID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Clean GetModel(string floorNum,string staID)
		{
			
			return dal.GetModel(floorNum,staID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.Clean GetModelByCache(string floorNum,string staID)
		{
			
			string CacheKey = "CleanModel-" + floorNum+staID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(floorNum,staID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.Clean)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.Clean> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.Clean> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.Clean> modelList = new List<Maticsoft.Model.Clean>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.Clean model;
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
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

