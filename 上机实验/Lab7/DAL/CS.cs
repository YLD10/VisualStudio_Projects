using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:CS
	/// </summary>
	public partial class CS
	{
		public CS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string couID,string stuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CS");
			strSql.Append(" where couID=@couID and stuID=@stuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@couID", SqlDbType.VarChar,15),
					new SqlParameter("@stuID", SqlDbType.VarChar,15)};
			parameters[0].Value = couID;
			parameters[1].Value = stuID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.CS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CS(");
			strSql.Append("couID,stuID,teaID,score)");
			strSql.Append(" values (");
			strSql.Append("@couID,@stuID,@teaID,@score)");
			SqlParameter[] parameters = {
					new SqlParameter("@couID", SqlDbType.VarChar,15),
					new SqlParameter("@stuID", SqlDbType.VarChar,15),
					new SqlParameter("@teaID", SqlDbType.VarChar,15),
					new SqlParameter("@score", SqlDbType.Float,8)};
			parameters[0].Value = model.couID;
			parameters[1].Value = model.stuID;
			parameters[2].Value = model.teaID;
			parameters[3].Value = model.score;

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
		public bool Update(Maticsoft.Model.CS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CS set ");
			strSql.Append("score=@score");
			strSql.Append(" where couID=@couID and stuID=@stuID and teaID = @teaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@score", SqlDbType.Float,8),
					new SqlParameter("@couID", SqlDbType.VarChar,15),
					new SqlParameter("@stuID", SqlDbType.VarChar,15),
					new SqlParameter("@teaID", SqlDbType.VarChar,15)};
			parameters[0].Value = model.score;
			parameters[1].Value = model.couID;
			parameters[2].Value = model.stuID;
			parameters[3].Value = model.teaID;

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
		public bool Delete(Maticsoft.Model.CS model)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CS ");
			strSql.Append(" where couID=@couID and stuID=@stuID and teaID = @teaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@couID", SqlDbType.VarChar,15),
					new SqlParameter("@stuID", SqlDbType.VarChar,15),
					new SqlParameter("@teaID", SqlDbType.VarChar,15)			};
			parameters[0].Value = model.couID;
			parameters[1].Value = model.stuID;
			parameters[2].Value = model.teaID;

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
		/// 删除多条数据
		/// </summary>
		public bool Delete(string teaID, string couID)
		{

			StringBuilder strSql = new StringBuilder();
			strSql.Append("delete from CS ");
			strSql.Append(" where couID=@couID and teaID = @teaID ");
			SqlParameter[] parameters = {
					new SqlParameter("@couID", SqlDbType.VarChar,15),
					new SqlParameter("@teaID", SqlDbType.VarChar,15)			};
			parameters[0].Value = couID;
			parameters[1].Value = teaID;

			int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public Maticsoft.Model.CS GetModel(string couID,string stuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 couID,stuID,score from CS ");
			strSql.Append(" where couID=@couID and stuID=@stuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@couID", SqlDbType.VarChar,15),
					new SqlParameter("@stuID", SqlDbType.VarChar,15)			};
			parameters[0].Value = couID;
			parameters[1].Value = stuID;

			Maticsoft.Model.CS model=new Maticsoft.Model.CS();
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
		public Maticsoft.Model.CS DataRowToModel(DataRow row)
		{
			Maticsoft.Model.CS model=new Maticsoft.Model.CS();
			if (row != null)
			{
				if(row["couID"]!=null)
				{
					model.couID=row["couID"].ToString();
				}
				if(row["stuID"]!=null)
				{
					model.stuID=row["stuID"].ToString();
				}
				if(row["score"]!=null && row["score"].ToString()!="")
				{
					model.score=decimal.Parse(row["score"].ToString());
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
			strSql.Append("select CS.couID,couName,couTime,couPoint,CS.teaID,teaName,score ");
			strSql.Append(" FROM CS,Courses,Teachers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetListTeaStu(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select CS.stuID,stuName,stuCollege,stuMajor,stuClass,score ");
			strSql.Append(" FROM CS,Students ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
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
			strSql.Append(" couID,stuID,score ");
			strSql.Append(" FROM CS ");
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
			strSql.Append("select count(1) FROM CS ");
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
				strSql.Append("order by T.stuID desc");
			}
			strSql.Append(")AS Row, T.*  from CS T ");
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
			parameters[0].Value = "CS";
			parameters[1].Value = "stuID";
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

