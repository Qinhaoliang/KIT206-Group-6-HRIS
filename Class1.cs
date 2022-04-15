using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRIS
{
    public partial class Class1 : Form
    {
        public Class1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“testDataSet._class”中。您可以根据需要移动或删除它。
            //this.classTableAdapter.Fill(this.testDataSet._class);
            mysqlDbHelper.Initialize("localhost", "test", "root", "123456");
            mysqlDbHelper.OpenConnection();
            UpdateDataSet();
            mysqlDbHelper.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlDbHelper.Initialize("localhost", "test", "root", "123456");
            mysqlDbHelper.OpenConnection();


            string sqlstr = string.Format("INSERT INTO class (`unit_code`, `campus`, `day`, `start`, `end`, `type`, `room`, `staff`) VALUES ('KIT401', 'Hobart', 'Tuesday', '12:00:00', '12:00:00', 'Lecture', 'C0', '123461');");

            MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(sqlstr);
            if (mysqlDbHelper.GetInsert(mySqlCommand))
            {
                mysqlDbHelper.CloseConnection();
                MessageBox.Show("Successful!");
                UpdateDataSet();
            }
            else
            {
                mysqlDbHelper.CloseConnection();
                MessageBox.Show("Faild!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mysqlDbHelper.Initialize("localhost", "test", "root", "123456");
            mysqlDbHelper.OpenConnection();


            string sqlstr = string.Format("DELETE FROM class WHERE `unit_code`='KIT401' and`day`='Tuesday' and`start`='12:00:00' and`campus`='Hobart';");

            MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(sqlstr);
            if (mysqlDbHelper.GetDelete(mySqlCommand))
            {
                mysqlDbHelper.CloseConnection();
                MessageBox.Show("Successful!");
                UpdateDataSet();
            }
            else
            {
                mysqlDbHelper.CloseConnection();
                MessageBox.Show("Faild!");
            }
        }

        private void UpdateDataSet()
        {
            string sqlstr = string.Format("select * from class");
            DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "class");
            dataGridView1.DataSource = dataTable.DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1[0, row].Value.ToString() == "")
                {
                    MessageBox.Show("当前选中为空行!");
                }
                else
                {
                    unit_codeTextBox.Text = dataGridView1[0, row].Value.ToString();
                    campusTextBox.Text = dataGridView1[1, row].Value.ToString();
                    dayTextBox.Text = dataGridView1[2, row].Value.ToString();
                    startTextBox.Text = dataGridView1[3, row].Value.ToString();
                    endTextBox.Text = dataGridView1[4, row].Value.ToString();
                    typeTextBox.Text = dataGridView1[5, row].Value.ToString();
                    roomTextBox.Text = dataGridView1[6, row].Value.ToString();
                    staffTextBox.Text = dataGridView1[7, row].Value.ToString();
                }
            }
        }
    }
    
}
