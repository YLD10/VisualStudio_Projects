using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:VbigRoomGoods
	/// </summary>
	public partial class VbigRoomGoods
	{
		public VbigRoomGoods()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string goodsID,string roomTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from VbigRoomGoods");
			strSql.Append(" where goodsID='"+goodsID+"' and roomTypeID='"+roomTypeID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.VbigRoomGoods model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.goodsID != null)
			{
				strSql1.Append("goodsID,");
				strSql2.Append("'"+model.goodsID+"',");
			}
			if (model.goodsName != null)
			{
				strSql1.Append("goodsName,");
				strSql2.Append("'"+model.goodsName+"',");
			}
			if (model.goodsPrice > 0)
			{
				strSql1.Append("goodsPrice,");
				strSql2.Append(""+model.goodsPrice+",");
			}
			if (model.roomTypeID != null)
			{
				strSql1.Append("roomTypeID,");
				strSql2.Append("'"+model.roomTypeID+"',");
			}
			strSql.Append("insert into VbigRoomGoods(");
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
		public bool Update(Maticsoft.Model.VbigRoomGoods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update VbigRoomGoods set ");
			if (model.goodsName != null)
			{
				strSql.Append("goodsName='"+model.goodsName+"',");
			}
			if (model.goodsPrice > 0)
			{
				strSql.Append("goodsPrice="+model.goodsPrice+",");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where goodsID='"+ model.goodsID+"' and roomTypeID='"+ model.roomTypeID+"' ");
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
		public bool Delete(string goodsID,string roomTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from VbigRoomGoods ");
			strSql.Append(" where goodsID='"+goodsID+"' and roomTypeID='"+roomTypeID+"' " );
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
		public Maticsoft.Model.VbigRoomGoods GetModel(string goodsID,string roomTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" goodsID,goodsName,goodsPrice,roomTypeID ");
			strSql.Append(" from VbigRoomGoods ");
			strSql.Append(" where goodsID='"+goodsID+"' and roomTypeID='"+roomTypeID+"' " );
			Maticsoft.Model.VbigRoomGoods model=new Maticsoft.Model.VbigRoomGoods();
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
		public Maticsoft.Model.VbigRoomGoods DataRowToModel(DataRow row)
		{
			Maticsoft.Model.VbigRoomGoods model=new Maticsoft.Model.VbigRoomGoods();
			if (row != null)
			{
				if(row["goodsID"]!=null)
				{
					model.goodsID=row["goodsID"].ToString();
				}
				if(row["goodsName"]!=null)
				{
					model.goodsName=row["goodsName"].ToString();
				}
				if(row["goodsPrice"]!=null && row["goodsPrice"].ToString()!="")
				{
					model.goodsPrice=decimal.Parse(row["goodsPrice"].ToString());
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
			strSql.Append("select goodsID,goodsName,goodsPrice,roomTypeID ");
			strSql.Append(" FROM VbigRoomGoods ");
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
			strSql.Append(" goodsID,goodsName,goodsPrice,roomTypeID ");
			strSql.Append(" FROM VbigRoomGoods ");
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
			strSql.Append("select count(1) FROM VbigRoomGoods ");
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
			strSql.Append(")AS Row, T.*  from VbigRoomGoods T ");
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

