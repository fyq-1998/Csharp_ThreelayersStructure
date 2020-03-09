using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBbase
    {
        //读取配置文件 连接数据库语句  

        public static string strCon = "server=127.0.0.1;database=db_PWMS;uid=sa;pwd=123456";  

        //实例化连接对象 con  
        SqlConnection con = new SqlConnection(strCon);

        //检测连接是否打开  
        public void checkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        //执行语句，返回该语句查询的数据行的总行数  
        public int returnRowCount(string strSQL)
        {
            checkConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
        }
        //执行SQL语句，返回受影响的行数
        public int ExecuteNoneQuery(string strSQL)
        {
            checkConnection();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            try
            {

                return cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//关闭数据库连接
            }
        }
    }
}