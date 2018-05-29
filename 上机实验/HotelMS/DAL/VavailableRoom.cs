﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:VavailableRoom
	/// </summary>
	public partial class VavailableRoom
	{
		public VavailableRoom()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string floorNum,string roomID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from VavailableRoom");
			strSql.Append(" where floorNum='"+floorNum+"' and roomID='"+roomID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.VavailableRoom model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.floorNum != null)
			{
				strSql1.Append("floorNum,");
				strSql2.Append("'"+model.floorNum+"',");
			}
			if (model.roomID != null)
			{
				strSql1.Append("roomID,");
				strSql2.Append("'"+model.roomID+"',");
			}
			if (model.liveState == 0 || model.liveState == 1)
			{
				strSql1.Append("liveState,");
				strSql2.Append(""+model.liveState+",");
			}
			if (model.roomTypeID != null)
			{
				strSql1.Append("roomTypeID,");
				strSql2.Append("'"+model.roomTypeID+"',");
			}
			strSql.Append("insert into VavailableRoom(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public bool Update(Maticsoft.Model.VavailableRoom model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update VavailableRoom set ");
			if (model.liveState == 0 || model.liveState == 1)
			{
				strSql.Append("liveState="+model.liveState+",");
			}
			if (model.roomTypeID != null)
			{
				strSql.Append("roomTypeID='"+model.roomTypeID+"',");
			}
			else
			{
				strSql.Append("roomTypeID= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where floorNum='"+ model.floorNum+"' and roomID='"+ model.roomID+"' ");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public bool Delete(string floorNum,string roomID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from VavailableRoom ");
			strSql.Append(" where floorNum='"+floorNum+"' and roomID='"+roomID+"' " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.VavailableRoom GetModel(string floorNum,string roomID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" floorNum,roomID,liveState,roomTypeID ");
			strSql.Append(" from VavailableRoom ");
			strSql.Append(" where floorNum='"+floorNum+"' and roomID='"+roomID+"' " );
			Maticsoft.Model.VavailableRoom model=new Maticsoft.Model.VavailableRoom();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
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
		public Maticsoft.Model.VavailableRoom DataRowToModel(DataRow row)
		{
			Maticsoft.Model.VavailableRoom model=new Maticsoft.Model.VavailableRoom();
			if (row != null)
			{
				if(row["floorNum"]!=null)
				{
					model.floorNum=row["floorNum"].ToString();
				}
				if(row["roomID"]!=null)
				{
					model.roomID=row["roomID"].ToString();
				}
				if(row["liveState"]!=null && row["liveState"].ToString()!="")
				{
					model.liveState=int.Parse(row["liveState"].ToString());
				}
				if(row["roomTypeID"]!=null)
				{
					model.roomTypeID=row["roomTypeID"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select floorNum,roomID,liveState,roomTypeID ");
			strSql.Append(" FROM VavailableRoom ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" floorNum,roomID,liveState,roomTypeID ");
			strSql.Append(" FROM VavailableRoom ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM VavailableRoom ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.roomID desc");
			}
			strSql.Append(")AS Row, T.*  from VavailableRoom T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

