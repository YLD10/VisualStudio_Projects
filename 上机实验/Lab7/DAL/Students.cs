using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Students
	/// </summary>
	public partial class Students
	{
		public Students()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Students");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Students model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.stuName != null)
			{
				strSql1.Append("stuName,");
				strSql2.Append("'"+model.stuName+"',");
			}
			if (model.stuSex >= 0 && model.stuSex <= 1)
			{
				strSql1.Append("stuSex,");
				strSql2.Append(""+model.stuSex+",");
			}
			if (model.stuCollege != null)
			{
				strSql1.Append("stuCollege,");
				strSql2.Append("'"+model.stuCollege+"',");
			}
			if (model.stuMajor != null)
			{
				strSql1.Append("stuMajor,");
				strSql2.Append("'"+model.stuMajor+"',");
			}
			if (model.stuClass != null)
			{
				strSql1.Append("stuClass,");
				strSql2.Append("'"+model.stuClass+"',");
			}
			if (model.passwd != null)
			{
				strSql1.Append("passwd,");
				strSql2.Append("'"+model.passwd+"',");
			}
			strSql.Append("insert into Students(");
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
		public bool Update(Maticsoft.Model.Students model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Students set ");
			if (model.stuName != null)
			{
				strSql.Append("stuName='"+model.stuName+"',");
			}
			if (model.stuSex >= 0 && model.stuSex <= 1)
			{
				strSql.Append("stuSex="+model.stuSex+",");
			}
			if (model.stuCollege != null)
			{
				strSql.Append("stuCollege='"+model.stuCollege+"',");
			}
			if (model.stuMajor != null)
			{
				strSql.Append("stuMajor='"+model.stuMajor+"',");
			}
			if (model.stuClass != null)
			{
				strSql.Append("stuClass='"+model.stuClass+"',");
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
			strSql.Append("delete from Students ");
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
			strSql.Append("delete from Students ");
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
		public Maticsoft.Model.Students GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" ID,stuName,(case stuSex when 1 then '男' when 0 then '女' else '未知' end)stuSex,stuCollege,stuMajor,stuClass,passwd ");
			strSql.Append(" from Students ");
			strSql.Append(" where ID='"+ID+"' " );
			Maticsoft.Model.Students model=new Maticsoft.Model.Students();
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
		public Maticsoft.Model.Students DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Students model=new Maticsoft.Model.Students();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["stuName"]!=null)
				{
					model.stuName=row["stuName"].ToString();
				}
				if(row["stuSex"]!=null && row["stuSex"].ToString()!="")
				{
					model.stuSex=int.Parse(row["stuSex"].ToString());
				}
				if(row["stuCollege"]!=null)
				{
					model.stuCollege=row["stuCollege"].ToString();
				}
				if(row["stuMajor"]!=null)
				{
					model.stuMajor=row["stuMajor"].ToString();
				}
				if(row["stuClass"]!=null)
				{
					model.stuClass=row["stuClass"].ToString();
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
			strSql.Append("select ID,stuName,(case stuSex when 1 then '男' when 0 then '女' else '未知' end)stuSex,stuCollege,stuMajor,stuClass ");
			strSql.Append(" FROM Students ");
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
			strSql.Append(" ID,stuName,(case stuSex when 1 then '男' when 0 then '女' else '未知' end)stuSex,stuCollege,stuMajor,stuClass,passwd ");
			strSql.Append(" FROM Students ");
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
			strSql.Append("select count(1) FROM Students ");
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
			strSql.Append(")AS Row, T.*  from Students T ");
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

