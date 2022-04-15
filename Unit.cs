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
using System.IO;

namespace HRIS
{
    public partial class Unit : Form
    {
        public Unit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            mysqlDbHelper.Initialize("localhost", "test", "root", "123456");
            mysqlDbHelper.OpenConnection();
            UpdateDataSet();
            mysqlDbHelper.CloseConnection();
        }
        private void UpdateDataSet()
        {
            try
            {
                string sqlstr = string.Format("select * from unit");
                DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "unit");
                dataGridView1.DataSource = dataTable.DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
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
                    codeTextBox.Text = dataGridView1[0, row].Value.ToString();
                    titleTextBox.Text = dataGridView1[1, row].Value.ToString();
                    coordinatorTextBox.Text = dataGridView1[2, row].Value.ToString();
                }
            }
        }
    }
}
