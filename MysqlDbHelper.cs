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
        /// MySqlConnection Connection object
        /// </summary>
        private MySqlConnection connection;
        /// <summary>
        /// Server address
        /// </summary>
        private string server;
        /// <summary>
        /// Database instance name
        /// </summary>
        private string database;
        /// <summary>
        /// The user name
        /// </summary>  
        private string uid;
        /// <summary>
        /// password
        /// </summary>
        private string password;
        /// <summary>
        /// The port number
        /// </summary>
        private string port;

        public MySqlConnection GetInstance()
        {
            return connection;
        }

        /// <summary>
        /// Initialize the mysql connection
        /// </summary>
        /// <param name="server">Server address</param>
        /// <param name="database">Database instance name</param>
        /// <param name="uid">The user name</param>
        /// <param name="password">password</param>
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
        /// turn on database connection
        /// </summary>
        /// <returns>success or not</returns>
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
        /// turn off database connection
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
        /// Build the SQL handle
        /// </summary>
        /// <param name="SQL">The SQL statement</param>
        /// <returns></returns>
        public MySqlCommand CreateCmd(string SQL)
        {
            MySqlCommand Cmd = new MySqlCommand(SQL, connection);
            return Cmd;
        }

        /// <summary>
        ///  Return from running MySql statement (MySqlDataReader)
        /// </summary>
        /// <param name="The query"></param>
        /// <returns>MySqlDataReader object </returns>
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
        /// Obtain the DataTable table from SQL
        /// </summary>
        /// <param name="SQL">The query</param>
        /// <param name="Table_name">Returns the table name of the table</param>
        /// <returns></returns>
        public DataTable GetDataTable(string SQL, string Table_name)
        {
            MySqlDataAdapter Da = new MySqlDataAdapter(SQL, connection);
            DataTable dt = new DataTable(Table_name);
            Da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Run the MySql statement to return the DataSet object
        /// </summary>
        /// <param name="SQL">The query</param>
        /// <param name="Ds">The DataSet object to be filled</param>
        /// <param name="tablename">The name of the table</param>
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
        /// Run MySql statement, return DataSet object, the data is paged
        /// </summary>
        /// <param name="SQL">The query</param>
        /// <param name="Ds">The DataSet object to be filled</param>
        /// <param name="StartIndex">Began to study</param>
        /// <param name="PageSize">Number of data items per page</param>
        /// <param name="tablename">The name of the table</param>
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
        /// add data
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
        /// edit data
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
        /// delete data
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
