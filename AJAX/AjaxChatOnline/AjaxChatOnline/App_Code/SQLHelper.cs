
using System;
using System.Collections.Generic;

using System.Text;
using System.Data;

using System.Data.OleDb;


    class SQLHelper
    {
        private OleDbConnection conn = null;
        private OleDbCommand cmd = null;
        private OleDbDataReader sdr = null;

        public SQLHelper()
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            conn = new OleDbConnection(connStr);
        }

        private OleDbConnection GetConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //private SqlConnection CreateConn()
        //{
        //    SqlConnection conn = new SqlConnection("server=.;database=newssystem;user id=sa;pwd=12566717");
        //    return conn;
        //}


        /// <summary>
        /// 执行不带参数的增删改SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程</param>
        /// <returns>增删改影响的行数</returns>
        public int ExecuteNonQuery(string cmdText, CommandType ct)
        {
            int res;
            try
            {
                cmd = new OleDbCommand(cmdText, GetConn());
                cmd.CommandType = ct;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// 执行带参数的增删改SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程</param>
        /// <returns>增删改影响的行数</returns>
        public int ExecuteNonQuery(string sql, OleDbParameter[] paras, CommandType ct)
        {
            int res;
            try
            {
                using (cmd = new OleDbCommand(sql, GetConn()))
                {
                    cmd.Parameters.AddRange(paras);
                    cmd.CommandType = ct;
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }

        /// <summary>
        /// 该方法执行传入不带参数的SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程名称</param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteQuery(string cmdText, CommandType ct)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }

        /// <summary>
        /// 该方法执行传入带参数的SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程名称</param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteQuery(string cmdText, OleDbParameter[] paras, CommandType ct)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(cmdText, GetConn());
            cmd.Parameters.AddRange(paras);
            cmd.CommandType = ct;
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }

        /// <summary>
        /// 该方法执行传入带参数的SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程名称</param>
        /// <returns>SqlDataReader</returns>
        public OleDbDataReader ExecuteDataReader(string cmdText, OleDbParameter[] paras, CommandType ct)
        {
            cmd = new OleDbCommand(cmdText, GetConn());
            cmd.Parameters.AddRange(paras);
            cmd.CommandType = ct;
            return cmd.ExecuteReader();
            //using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            //{
            //    return sdr;
            //}
        }

        /// <summary>
        /// 该方法执行传入不带参数的SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程名称</param>
        /// <returns>SqlDataReader</returns>
        public OleDbDataReader ExecuteDataReader(string cmdText, CommandType ct)
        {
            cmd = new OleDbCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// 返回结果首行首列
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="paras"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public object ExecuteScalar(string cmdText, OleDbParameter[] paras, CommandType ct)
        {
            cmd = new OleDbCommand(cmdText, GetConn());
            cmd.Parameters.AddRange(paras);
            cmd.CommandType = ct;
            return cmd.ExecuteScalar();
        }


        /// <summary>
        /// 返回结果首行首列
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="paras"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public object ExecuteScalar(string cmdText, CommandType ct)
        {
            try
            {
                cmd = new OleDbCommand(cmdText, GetConn());
                cmd.CommandType = ct;
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
