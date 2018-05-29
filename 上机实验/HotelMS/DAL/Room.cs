using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Room
	/// </summary>
	public partial class Room
	{
		public Room()
		{ }
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string floorNum, string roomID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from Room");
			strSql.Append(" where floorNum='" + floorNum + "' and roomID='" + roomID + "' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Room model)
		{
			StringBuilder strSql = new StringBuilder();
			StringBuilder strSql1 = new StringBuilder();
			StringBuilder strSql2 = new StringBuilder();
			if (model.floorNum != null)
			{
				strSql1.Append("floorNum,");
				strSql2.Append("'" + model.floorNum + "',");
			}
			if (model.roomID != null)
			{
				strSql1.Append("roomID,");
				strSql2.Append("'" + model.roomID + "',");
			}
			if (model.liveState == 0 || model.liveState == 1)
			{
				strSql1.Append("liveState,");
				strSql2.Append("" + model.liveState + ",");
			}
			if (model.cleanState == 0 || model.cleanState == 1)
			{
				strSql1.Append("cleanState,");
				strSql2.Append("" + model.cleanState + ",");
			}
			if (model.damageState == 0 || model.damageState == 1)
			{
				strSql1.Append("damageState,");
				strSql2.Append("" + model.damageState + ",");
			}
			if (model.roomTypeID != null)
			{
				strSql1.Append("roomTypeID,");
				strSql2.Append("'" + model.roomTypeID + "',");
			}
			if (model.roomAbandoned == 0 || model.roomAbandoned == 1)
			{
				strSql1.Append("roomAbandoned,");
				strSql2.Append("'" + model.roomAbandoned + "',");
			}

			strSql.Append("insert into Room(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Room model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("update Room set ");
			if (model.liveState == 0 || model.liveState == 1)
			{
				strSql.Append("liveState=" + model.liveState + ",");
			}
			if (model.cleanState == 0 || model.cleanState == 1)
			{
				strSql.Append("cleanState=" + model.cleanState + ",");
			}
			if (model.damageState == 0 || model.damageState == 1)
			{
				strSql.Append("damageState=" + model.damageState + ",");
			}
			if (model.roomTypeID != null)
			{
				strSql.Append("roomTypeID='" + model.roomTypeID + "',");
			}
			if (model.roomAbandoned == 0 || model.roomAbandoned == 1)
			{
				strSql.Append("roomAbandoned='" + model.roomAbandoned + "',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where floorNum='" + model.floorNum + "' and roomID='" + model.roomID + "' ");
			int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string floorNum, string roomID)
		{

			StringBuilder strSql = new StringBuilder();
			strSql.Append("delete from Room ");
			strSql.Append(" where floorNum='" + floorNum + "' and roomID='" + roomID + "' ");
			int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Room GetModel(string floorNum, string roomID)
		{

			StringBuilder strSql = new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" floorNum,roomID,liveState,cleanState,damageState,roomTypeID,roomAbandoned ");
			strSql.Append(" from Room ");
			strSql.Append(" where floorNum='" + floorNum + "' and roomID='" + roomID + "' ");
			Maticsoft.Model.Room model = new Maticsoft.Model.Room();
			DataSet ds = DbHelperSQL.Query(strSql.ToString());
			if (ds.Tables[0].Rows.Count > 0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Room DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Room model = new Maticsoft.Model.Room();
			if (row != null)
			{
				if (row["floorNum"] != null)
				{
					model.floorNum = row["floorNum"].ToString();
				}
				if (row["roomID"] != null)
				{
					model.roomID = row["roomID"].ToString();
				}
				if (row["liveState"] != null && row["liveState"].ToString() != "")
				{
					model.liveState = int.Parse(row["liveState"].ToString());
				}
				if (row["cleanState"] != null && row["cleanState"].ToString() != "")
				{
					model.cleanState = int.Parse(row["cleanState"].ToString());
				}
				if (row["damageState"] != null && row["damageState"].ToString() != "")
				{
					model.damageState = int.Parse(row["damageState"].ToString());
				}
				if (row["roomTypeID"] != null)
				{
					model.roomTypeID = row["roomTypeID"].ToString();
				}
				if (row["roomAbandoned"] != null && row["roomAbandoned"].ToString() != "")
				{
					model.roomAbandoned = int.Parse(row["roomAbandoned"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select floorNum,roomID,liveState,cleanState,damageState,roomTypeID,roomAbandoned ");
			strSql.Append(" FROM Room ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#region 自定义 

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetListRoomInfo(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append(" select floorNum  楼层号,roomID  房间号,(case livestate when 0 then '未住' else '已住' end)入住状态,(case cleanstate when 0 then '未打扫' else '已打扫' end)打扫状态,(case damagestate when 0 then '有损坏' else '未损坏' end)物品损坏状态,roomTypeID  房间类型,(case roomAbandoned when 0 then '已禁用' else '未禁用' end)禁用状态 ");
			strSql.Append(" FROM Room ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
		#endregion

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top, string strWhere, string filedOrder)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select ");
			if (Top > 0)
			{
				strSql.Append(" top " + Top.ToString());
			}
			strSql.Append(" floorNum,roomID,liveState,cleanState,damageState,roomTypeID,roomAbandoned ");
			strSql.Append(" FROM Room ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) FROM Room ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby);
			}
			else
			{
				strSql.Append("order by T.roomID desc");
			}
			strSql.Append(")AS Row, T.*  from Room T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Room";
			parameters[1].Value = "roomID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

