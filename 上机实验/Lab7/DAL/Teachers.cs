using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Teachers
	/// </summary>
	public partial class Teachers
	{
		public Teachers()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Teachers");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Teachers model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.teaName != null)
			{
				strSql1.Append("teaName,");
				strSql2.Append("'"+model.teaName+"',");
			}
			if (model.teaSex >= 0 && model.teaSex <= 1)
			{
				strSql1.Append("teaSex,");
				strSql2.Append(""+model.teaSex+",");
			}
			if (model.teaTitle != null)
			{
				strSql1.Append("teaTitle,");
				strSql2.Append("'"+model.teaTitle+"',");
			}
			if (model.passwd != null)
			{
				strSql1.Append("passwd,");
				strSql2.Append("'"+model.passwd+"',");
			}
			strSql.Append("insert into Teachers(");
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
		public bool Update(Maticsoft.Model.Teachers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Teachers set ");
			if (model.teaName != null)
			{
				strSql.Append("teaName='"+model.teaName+"',");
			}
			if (model.teaSex >= 0 && model.teaSex <= 1)
			{
				strSql.Append("teaSex="+model.teaSex+",");
			}
			if (model.teaTitle != null)
			{
				strSql.Append("teaTitle='"+model.teaTitle+"',");
			}
			if (model.passwd != null)
			{
				strSql.Append("passwd='"+model.passwd+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' ");
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
		public bool Delete(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Teachers ");
			strSql.Append(" where ID='"+ID+"' " );
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Teachers ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Maticsoft.Model.Teachers GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" ID,teaName,(case teaSex when 1 then '男' when 0 then '女' else '未知' end)teaSex,teaTitle,passwd ");
			strSql.Append(" from Teachers ");
			strSql.Append(" where ID='"+ID+"' " );
			Maticsoft.Model.Teachers model=new Maticsoft.Model.Teachers();
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
		public Maticsoft.Model.Teachers DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Teachers model=new Maticsoft.Model.Teachers();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["teaName"]!=null)
				{
					model.teaName=row["teaName"].ToString();
				}
				if(row["teaSex"]!=null && row["teaSex"].ToString()!="")
				{
					model.teaSex=int.Parse(row["teaSex"].ToString());
				}
				if(row["teaTitle"]!=null)
				{
					model.teaTitle=row["teaTitle"].ToString();
				}
				if(row["passwd"]!=null)
				{
					model.passwd=row["passwd"].ToString();
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
			strSql.Append("select ID,teaName,(case teaSex when 1 then '男' when 0 then '女' else '未知' end)teaSex,teaTitle ");
			strSql.Append(" FROM Teachers ");
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
			strSql.Append(" ID,teaName,(case teaSex when 1 then '男' when 0 then '女' else '未知' end)teaSex,teaTitle,passwd ");
			strSql.Append(" FROM Teachers ");
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
			strSql.Append("select count(1) FROM Teachers ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Teachers T ");
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

