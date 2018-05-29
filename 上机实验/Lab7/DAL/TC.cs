using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:TC
	/// </summary>
	public partial class TC
	{
		public TC()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string teaID,string couID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TC");
			strSql.Append(" where teaID=@teaID and couID=@couID ");
			SqlParameter[] parameters = {
					new SqlParameter("@teaID", SqlDbType.VarChar,15),
					new SqlParameter("@couID", SqlDbType.VarChar,15)			};
			parameters[0].Value = teaID;
			parameters[1].Value = couID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.TC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TC(");
			strSql.Append("teaID,couID)");
			strSql.Append(" values (");
			strSql.Append("@teaID,@couID)");
			SqlParameter[] parameters = {
					new SqlParameter("@teaID", SqlDbType.VarChar,15),
					new SqlParameter("@couID", SqlDbType.VarChar,15)};
			parameters[0].Value = model.teaID;
			parameters[1].Value = model.couID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.TC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TC set ");
			strSql.Append("teaID=@teaID,");
			strSql.Append("couID=@couID");
			strSql.Append(" where couID=@couID ");
			SqlParameter[] parameters = {
					new SqlParameter("@teaID", SqlDbType.VarChar,15),
					new SqlParameter("@couID", SqlDbType.VarChar,15)};
			parameters[0].Value = model.teaID;
			parameters[1].Value = model.couID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string teaID,string couID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TC ");
			strSql.Append(" where teaID=@teaID and couID=@couID ");
			SqlParameter[] parameters = {
					new SqlParameter("@teaID", SqlDbType.VarChar,15),
					new SqlParameter("@couID", SqlDbType.VarChar,15)			};
			parameters[0].Value = teaID;
			parameters[1].Value = couID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public Maticsoft.Model.TC GetModel(string teaID,string couID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 teaID,couID from TC ");
			strSql.Append(" where teaID=@teaID and couID=@couID ");
			SqlParameter[] parameters = {
					new SqlParameter("@teaID", SqlDbType.VarChar,15),
					new SqlParameter("@couID", SqlDbType.VarChar,15)			};
			parameters[0].Value = teaID;
			parameters[1].Value = couID;

			Maticsoft.Model.TC model=new Maticsoft.Model.TC();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public Maticsoft.Model.TC DataRowToModel(DataRow row)
		{
			Maticsoft.Model.TC model=new Maticsoft.Model.TC();
			if (row != null)
			{
				if(row["teaID"]!=null)
				{
					model.teaID=row["teaID"].ToString();
				}
				if(row["couID"]!=null)
				{
					model.couID=row["couID"].ToString();
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
			strSql.Append("select couID,couName,couTime,couPoint,teaID,teaName,teaTitle,(case teaSex when 1 then '男' when 0 then '女' else '未知' end)teaSex ");
			strSql.Append(" FROM TC,Teachers,Courses ");
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
			strSql.Append(" teaID,couID ");
			strSql.Append(" FROM TC ");
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
			strSql.Append("select count(1) FROM TC ");
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
				strSql.Append("order by T.couID desc");
			}
			strSql.Append(")AS Row, T.*  from TC T ");
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
			parameters[0].Value = "TC";
			parameters[1].Value = "couID";
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

