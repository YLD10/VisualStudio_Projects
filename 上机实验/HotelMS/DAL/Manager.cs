using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Manager
	/// </summary>
	public partial class Manager
	{
		public Manager()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string manID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Manager");
            strSql.Append(" where manID='" + manID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.Manager model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.manID != null)
            {
                strSql1.Append("manID,");
                strSql2.Append("'" + model.manID + "',");
            }
            if (model.manName != null)
            {
                strSql1.Append("manName,");
                strSql2.Append("'" + model.manName + "',");
            }
            if (model.manSex != null)
            {
                strSql1.Append("manSex,");
                strSql2.Append("'" + model.manSex + "',");
            }
            if (18 <= model.manAge && model.manAge <= 60)
            {
                strSql1.Append("manAge,");
                strSql2.Append("" + model.manAge + ",");
            }
            if (model.passwd != null)
            {
                strSql1.Append("passwd,");
                strSql2.Append("'" + model.passwd + "',");
            }
            if (model.manPhoto != null)
            {
                strSql1.Append("manPhoto,");
                strSql2.Append("'" + model.manPhoto + "',");
            }
            strSql.Append("insert into Manager(");
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
        public bool Update(Maticsoft.Model.Manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Manager set ");
            if (model.manName != "")
            {
                strSql.Append("manName='" + model.manName + "',");
            }
            if (model.manSex != "")
            {
                strSql.Append("manSex='" + model.manSex + "',");
            }
            if (18 <= model.manAge && model.manAge <= 60)
            {
                strSql.Append("manAge=" + model.manAge + ",");
            }
            if (model.passwd != null)
            {
                strSql.Append("passwd='" + model.passwd + "',");
            }
            if (model.manPhoto != null && model.manPhoto.Length > 0)
            {
                strSql.Append("manPhoto='" + model.manPhoto + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where manID='" + model.manID + "' ");
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
        public bool Delete(string manID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Manager ");
            strSql.Append(" where manID='" + manID + "' ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string manIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Manager ");
			strSql.Append(" where manID in ("+manIDlist + ")  ");
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
        public Maticsoft.Model.Manager GetModel(string manID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" manID,manName,manSex,manAge,passwd,manPhoto ");
            strSql.Append(" from Manager ");
            strSql.Append(" where manID='" + manID + "' ");
            Maticsoft.Model.Manager model = new Maticsoft.Model.Manager();
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

        public Maticsoft.Model.Manager GetModel1(string str1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" manID,manName,manSex,manAge,passwd,manPhoto ");
            strSql.Append(" from Manager ");
            strSql.Append(" where " + str1 + " ");
            Maticsoft.Model.Manager model = new Maticsoft.Model.Manager();
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
        public Maticsoft.Model.Manager DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Manager model=new Maticsoft.Model.Manager();
			if (row != null)
			{
				if(row["manID"]!=null)
				{
					model.manID=row["manID"].ToString();
				}
				if(row["manName"]!=null)
				{
					model.manName=row["manName"].ToString();
				}
				if(row["manSex"]!=null)
				{
					model.manSex=row["manSex"].ToString();
				}
				if(row["manAge"]!=null && row["manAge"].ToString()!="")
				{
					model.manAge=int.Parse(row["manAge"].ToString());
				}
				if(row["passwd"]!=null)
				{
					model.passwd=row["passwd"].ToString();
				}
				if(row["manPhoto"]!=null && row["manPhoto"].ToString()!="")
				{
					model.manPhoto=(byte[])row["manPhoto"];
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
			strSql.Append("select manID,manName,manSex,manAge,passwd ");
			strSql.Append(" FROM Manager ");
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
			strSql.Append(" manID,manName,manSex,manAge,passwd,manPhoto ");
			strSql.Append(" FROM Manager ");
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
			strSql.Append("select count(1) FROM Manager ");
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
				strSql.Append("order by T.manID desc");
			}
			strSql.Append(")AS Row, T.*  from Manager T ");
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
			parameters[0].Value = "Manager";
			parameters[1].Value = "manID";
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

