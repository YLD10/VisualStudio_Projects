using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:RoomType
	/// </summary>
	public partial class RoomType
	{
		public RoomType()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string roomTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RoomType");
			strSql.Append(" where roomTypeID='"+roomTypeID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.RoomType model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.roomTypeID != null)
			{
				strSql1.Append("roomTypeID,");
				strSql2.Append("'"+model.roomTypeID+"',");
			}
			if (model.roomTypePrice > 0)
			{
				strSql1.Append("roomTypePrice,");
				strSql2.Append(""+model.roomTypePrice+",");
			}
			strSql.Append("insert into RoomType(");
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
		public bool Update(Maticsoft.Model.RoomType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RoomType set ");
			if (model.roomTypePrice > 0)
			{
				strSql.Append("roomTypePrice="+model.roomTypePrice+",");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where roomTypeID='"+ model.roomTypeID+"' ");
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
		public bool Delete(string roomTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RoomType ");
			strSql.Append(" where roomTypeID='"+roomTypeID+"' " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string roomTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RoomType ");
			strSql.Append(" where roomTypeID in ("+roomTypeIDlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.RoomType GetModel(string roomTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" roomTypeID,roomTypePrice ");
			strSql.Append(" from RoomType ");
			strSql.Append(" where roomTypeID='"+roomTypeID+"' " );
			Maticsoft.Model.RoomType model=new Maticsoft.Model.RoomType();
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
		public Maticsoft.Model.RoomType DataRowToModel(DataRow row)
		{
			Maticsoft.Model.RoomType model=new Maticsoft.Model.RoomType();
			if (row != null)
			{
				if(row["roomTypeID"]!=null)
				{
					model.roomTypeID=row["roomTypeID"].ToString();
				}
				if(row["roomTypePrice"]!=null && row["roomTypePrice"].ToString()!="")
				{
					model.roomTypePrice=decimal.Parse(row["roomTypePrice"].ToString());
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
			strSql.Append("select roomTypeID,roomTypePrice ");
			strSql.Append(" FROM RoomType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


		#region 自定义
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetListRoomType(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append(" select roomTypeID 房间类型,Convert(varchar,roomTypePrice)+'元' 价格 ");
			strSql.Append(" FROM RoomType ");
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" roomTypeID,roomTypePrice ");
			strSql.Append(" FROM RoomType ");
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
			strSql.Append("select count(1) FROM RoomType ");
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
				strSql.Append("order by T.roomTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from RoomType T ");
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

