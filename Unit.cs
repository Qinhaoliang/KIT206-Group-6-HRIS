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
    public partial class Unit : Template
    {
        public Unit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            x = this.Width;
            y = this.Height;
            setTag(this);
        }

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const string db = "hris";
        private const string user = "kit206g20a";
        private const string pass = "group20a";
        private const string server = "alacritas.cis.utas.edu.au";

        private void Unit_Load(object sender, EventArgs e)
        {
            mysqlDbHelper.Initialize(server, db, user, pass);
            mysqlDbHelper.OpenConnection();
            UpdateDataSet();
            List<string> list = new List<string>();
            string sqlstr = string.Format("select id from staff");
            MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(sqlstr);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader[i].ToString());
                }
            }
            coordinatorComboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                coordinatorComboBox.Items.Add(list[i]);
            }
            coordinatorComboBox.SelectedIndex = 0;//The default value is 0


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

        string strSQLCommand;
        private void ConstructAddingString()
        {
            string strColumns = "code,title,coordinator";
            strSQLCommand = "insert into unit("
                + strColumns + ") values ('"
                + codeTextBox.Text.Trim() + "','"
                + titleTextBox.Text.Trim() + "','"
                + coordinatorComboBox.Text.Trim() + "'"
                 + ")";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1[0, row].Value.ToString() == "")
                {
                    MessageBox.Show("Empty line currently selected!");
                }
                else
                {
                    codeTextBox.Text = dataGridView1[0, row].Value.ToString();
                    titleTextBox.Text = dataGridView1[1, row].Value.ToString();
                    coordinatorComboBox.Text = dataGridView1[2, row].Value.ToString();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            mysqlDbHelper.OpenConnection();
            ConstructAddingString();
            MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(strSQLCommand);
            //codeTextBox.Text = strSQLCommand;
            if (mysqlDbHelper.GetInsert(mySqlCommand))
            {
                MessageBox.Show("Successful!");
                UpdateDataSet();
            }
            else
            {
                MessageBox.Show("FAIL!");
            }
            mysqlDbHelper.CloseConnection();

        }

        private void exitTemplateButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.ShowDialog();
        }

        private void Unit_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }
        private float x;
        private float y;
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }
    }
}
