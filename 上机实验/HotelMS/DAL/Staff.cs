﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:Staff
    /// </summary>
    public partial class Staff
	{
		public Staff()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string staID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Staff");
            strSql.Append(" where staID='" + staID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }


        /// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Staff model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.staID != null)
            {
                strSql1.Append("staID,");
                strSql2.Append("'" + model.staID + "',");
            }
            if (model.staName != null)
            {
                strSql1.Append("staName,");
                strSql2.Append("'" + model.staName + "',");
            }
            if (model.staSex != null)
            {
                strSql1.Append("staSex,");
                strSql2.Append("'" + model.staSex + "',");
            }
            if (model.staAge >= 18 && model.staAge <= 60)
            {
                strSql1.Append("staAge,");
                strSql2.Append("" + model.staAge + ",");
            }
            if (model.staPhoto != null)
            {
                strSql1.Append("staPhoto,");
                strSql2.Append("" + model.staPhoto + ",");
            }
            strSql.Append("insert into Staff(");
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
		public bool Update(Maticsoft.Model.Staff model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Staff set ");
            if (model.staName != "")
            {
                strSql.Append("staName='" + model.staName + "',");
            }
            if (model.staSex != "")
            {
                strSql.Append("staSex='" + model.staSex + "',");
            }
            if (model.staAge >= 18 && model.staAge <= 60)
            {
                strSql.Append("staAge=" + model.staAge + ",");
            }
            if (model.staPhoto != null && model.staPhoto.Length > 0)
            {
                strSql.Append("staPhoto='" + model.staPhoto + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where staID='" + model.staID + "' ");
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
		public bool Delete(string staID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Staff ");
            strSql.Append(" where staID='" + staID + "' ");
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
		public bool DeleteList(string staIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Staff ");
            strSql.Append(" where staID in (" + staIDlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Staff GetModel(string staID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" staID,staName,staSex,staAge,staPhoto ");
            strSql.Append(" from Staff ");
            strSql.Append(" where staID='" + staID + "' ");
            Maticsoft.Model.Staff model = new Maticsoft.Model.Staff();
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

        public Maticsoft.Model.Staff GetModel1(string str1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" staID,staName,staSex,staAge,staPhoto ");
            strSql.Append(" from Staff ");
            strSql.Append(" where " + str1 + " ");
            Maticsoft.Model.Staff model = new Maticsoft.Model.Staff();
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
        public Maticsoft.Model.Staff DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Staff model=new Maticsoft.Model.Staff();
			if (row != null)
			{
				if(row["staID"]!=null)
				{
					model.staID=row["staID"].ToString();
				}
				if(row["staName"]!=null)
				{
					model.staName=row["staName"].ToString();
				}
				if(row["staSex"]!=null)
				{
					model.staSex=row["staSex"].ToString();
				}
				if(row["staAge"]!=null && row["staAge"].ToString()!="")
				{
					model.staAge=int.Parse(row["staAge"].ToString());
				}
				if(row["staPhoto"]!=null && row["staPhoto"].ToString()!="")
				{
					model.staPhoto=(byte[])row["staPhoto"];
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
			strSql.Append("select staID,staName,staSex,staAge ");
			strSql.Append(" FROM Staff ");
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
			strSql.Append(" staID,staName,staSex,staAge,staPhoto ");
			strSql.Append(" FROM Staff ");
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
			strSql.Append("select count(1) FROM Staff ");
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
				strSql.Append("order by T.staID desc");
			}
			strSql.Append(")AS Row, T.*  from Staff T ");
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
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "Staff";
			parameters[1].Value = "staID";
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

