using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS
{
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultation_Load(object sender, EventArgs e)
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
                string sqlstr = string.Format("select * from consultation");
                DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "consultation");
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
                    idTextBox.Text = dataGridView1[0, row].Value.ToString();
                    dayTextBox.Text = dataGridView1[1, row].Value.ToString();
                    startTextBox.Text = dataGridView1[2, row].Value.ToString();
                    endTextBox.Text = dataGridView1[3, row].Value.ToString();
                }
            }
        }
    }
}
