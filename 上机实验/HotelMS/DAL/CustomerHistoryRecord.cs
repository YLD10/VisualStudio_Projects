using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:CustomerHistoryRecord
	/// </summary>
	public partial class CustomerHistoryRecord
	{
		public CustomerHistoryRecord()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string cusID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerHistoryRecord");
			strSql.Append(" where cusID='"+cusID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.CustomerHistoryRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.cusID != null)
			{
				strSql1.Append("cusID,");
				strSql2.Append("'"+model.cusID+"',");
			}
			if (model.historyTimes > 0)
			{
				strSql1.Append("historyTimes,");
				strSql2.Append(""+model.historyTimes+",");
			}
			if (model.discountRate >= 0 && model.discountRate < 1)
			{
				strSql1.Append("discountRate,");
				strSql2.Append(""+model.discountRate+",");
			}
			strSql.Append("insert into CustomerHistoryRecord(");
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
		public bool Update(Maticsoft.Model.CustomerHistoryRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerHistoryRecord set ");
			if (model.historyTimes > 0)
			{
				strSql.Append("historyTimes="+model.historyTimes+",");
			}
			if (model.discountRate >= 0 && model.discountRate < 1)
			{
				strSql.Append("discountRate="+model.discountRate+",");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where cusID='"+ model.cusID+"' ");
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
		public bool Delete(string cusID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerHistoryRecord ");
			strSql.Append(" where cusID='"+cusID+"' " );
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
		public bool DeleteList(string cusIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerHistoryRecord ");
			strSql.Append(" where cusID in ("+cusIDlist + ")  ");
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
		public Maticsoft.Model.CustomerHistoryRecord GetModel(string cusID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" cusID,historyTimes,discountRate ");
			strSql.Append(" from CustomerHistoryRecord ");
			strSql.Append(" where cusID='"+cusID+"' " );
			Maticsoft.Model.CustomerHistoryRecord model=new Maticsoft.Model.CustomerHistoryRecord();
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
		public Maticsoft.Model.CustomerHistoryRecord DataRowToModel(DataRow row)
		{
			Maticsoft.Model.CustomerHistoryRecord model=new Maticsoft.Model.CustomerHistoryRecord();
			if (row != null)
			{
				if(row["cusID"]!=null)
				{
					model.cusID=row["cusID"].ToString();
				}
				if(row["historyTimes"]!=null && row["historyTimes"].ToString()!="")
				{
					model.historyTimes=int.Parse(row["historyTimes"].ToString());
				}
				if(row["discountRate"]!=null && row["discountRate"].ToString()!="")
				{
					model.discountRate=decimal.Parse(row["discountRate"].ToString());
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
			strSql.Append("select cusID,historyTimes,discountRate ");
			strSql.Append(" FROM CustomerHistoryRecord ");
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
		public DataSet GetListCusHisRec(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select cusID 身份证号,historyTimes 历史次数,discountRate 优惠比率 ");
			strSql.Append(" FROM CustomerHistoryRecord ");
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
			strSql.Append(" cusID,historyTimes,discountRate ");
			strSql.Append(" FROM CustomerHistoryRecord ");
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
			strSql.Append("select count(1) FROM CustomerHistoryRecord ");
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
				strSql.Append("order by T.cusID desc");
			}
			strSql.Append(")AS Row, T.*  from CustomerHistoryRecord T ");
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

