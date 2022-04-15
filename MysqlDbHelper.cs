using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HRIS
{
    class MysqlDbHelper
    {
        /// <summary>
        /// MySqlConnection连接对象
        /// </summary>
        private MySqlConnection connection;
        /// <summary>
        /// 服务器地址
        /// </summary>
        private string server;
        /// <summary>
        /// 数据库实例名称
        /// </summary>
        private string database;
        /// <summary>
        /// 用户名
        /// </summary>  
        private string uid;
        /// <summary>
        /// 密码
        /// </summary>
        private string password;
        /// <summary>
        /// 端口号
        /// </summary>
        private string port;

        public MySqlConnection GetInstance()
        {
            return connection;
        }

        /// <summary>
        /// 初始化mysql连接
        /// </summary>
        /// <param name="server">服务器地址</param>
        /// <param name="database">数据库实例</param>
        /// <param name="uid">用户名称</param>
        /// <param name="password">密码</param>
        public void Initialize(string server, string database, string uid, string password)
        {
            this.server = server;
            this.uid = uid;
            this.password = password;
            this.database = database;
            string connectionString = "server=" + server + ";user id=" + uid + ";password=" + password + ";database=" + database;
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <returns>是否成功</returns>
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.Write("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.Write("Invalid username/password, please try again");
                        break;
                }
                return false;

            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <returns></returns>
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }


        public MySqlDataAdapter GetAdapter(string SQL)
        {
            MySqlDataAdapter Da = new MySqlDataAdapter(SQL, connection);
            return Da;
        }

        /// <summary>
        /// 构建SQL句柄
        /// </summary>
        /// <param name="SQL">SQL语句</param>
        /// <returns></returns>
        public MySqlCommand CreateCmd(string SQL)
        {
            MySqlCommand Cmd = new MySqlCommand(SQL, connection);
            return Cmd;
        }

        /// <summary>
        ///  运行MySql语句返回 MySqlDataReader对象
        /// </summary>
        /// <param name="查询语句"></param>
        /// <returns>MySqlDataReader对象</returns>
        public MySqlDataReader GetReader(string SQL)
        {
            MySqlCommand Cmd = new MySqlCommand(SQL, connection);
            MySqlDataReader Dr;
            try
            {
                Dr = Cmd.ExecuteReader(CommandBehavior.Default);
            }
            catch
            {
                throw new Exception(SQL);
            }
            return Dr;
        }


        /// <summary>
        /// 根据SQL获取DataTable数据表
        /// </summary>
        /// <param name="SQL">查询语句</param>
        /// <param name="Table_name">返回表的表名</param>
        /// <returns></returns>
        public DataTable GetDataTable(string SQL, string Table_name)
        {
            MySqlDataAdapter Da = new MySqlDataAdapter(SQL, connection);
            DataTable dt = new DataTable(Table_name);
            Da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 运行MySql语句,返回DataSet对象
        /// </summary>
        /// <param name="SQL">查询语句</param>
        /// <param name="Ds">待填充的DataSet对象</param>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        public DataSet Get_DataSet(string SQL, DataSet Ds, string tablename)
        {
            MySqlDataAdapter Da = new MySqlDataAdapter(SQL, connection);
            try
            {
                Da.Fill(Ds, tablename);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Ds;
        }
        /// <summary>
        /// 运行MySql语句,返回DataSet对象，将数据进行了分页
        /// </summary>
        /// <param name="SQL">查询语句</param>
        /// <param name="Ds">待填充的DataSet对象</param>
        /// <param name="StartIndex">开始项</param>
        /// <param name="PageSize">每页数据条数</param>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        public DataSet GetDataSet(string SQL, DataSet Ds, int StartIndex, int PageSize, string tablename)
        {
            MySqlDataAdapter Da = new MySqlDataAdapter(SQL, connection);
            try
            {
                Da.Fill(Ds, StartIndex, PageSize, tablename);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Ds;
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="mySqlCommand"></param>
        public bool GetInsert(MySqlCommand mySqlCommand)
        {
            try
            {
                if (mySqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }

        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="mySqlCommand"></param>
        public bool GetUpdate(MySqlCommand mySqlCommand)
        {
            try
            {
                if (mySqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="mySqlCommand"></param>
        public bool GetDelete(MySqlCommand mySqlCommand)
        {
            try
            {
                if (mySqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }
    }
}
