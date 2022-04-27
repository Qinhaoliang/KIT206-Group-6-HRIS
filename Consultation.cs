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
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        enum OPERATIONTYPE
        {
            Add,
            Update,
            Del,
            Save,
            Cancel,
            None
        }
        OPERATIONTYPE operationType = OPERATIONTYPE.None;

        string edit_day, edit_start;

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const string db = "hris";
        private const string user = "kit206g20a";
        private const string pass = "group20a";
        private const string server = "alacritas.cis.utas.edu.au";

        private void Consultation_Load(object sender, EventArgs e)
        {
            mysqlDbHelper.Initialize(server, db, user, pass);
            mysqlDbHelper.OpenConnection();
            UpdateDataSet();

            dayComboBox.Items.Add("Monday");
            dayComboBox.Items.Add("Tuesday");
            dayComboBox.Items.Add("Wednesday");
            dayComboBox.Items.Add("Thursday");
            dayComboBox.Items.Add("Thursday");
            dayComboBox.Items.Add("Saturday");
            dayComboBox.Items.Add("Sunday");
            dayComboBox.SelectedIndex = 0;

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
            staff_idComboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                staff_idComboBox.Items.Add(list[i]);
            }
            staff_idComboBox.SelectedIndex = 0;

            mysqlDbHelper.CloseConnection();
        }

        private void EnableButtons(OPERATIONTYPE type)
        {
            switch (type)
            {
                case OPERATIONTYPE.Add:
                    addButton.Enabled = false;
                    editButton.Enabled = false;
                    saveButton.Enabled = true;
                    calButton.Enabled = true;
                    staff_idComboBox.Enabled = true;
                    break;
                case OPERATIONTYPE.Update:
                    addButton.Enabled = false;
                    editButton.Enabled = false;
                    saveButton.Enabled = true;
                    calButton.Enabled = true;
                    staff_idComboBox.Enabled = false;
                    break;
                case OPERATIONTYPE.Save:
                case OPERATIONTYPE.Cancel:
                case OPERATIONTYPE.None:
                default:
                    addButton.Enabled = true;
                    editButton.Enabled = true;
                    saveButton.Enabled = false;
                    calButton.Enabled = false;
                    staff_idComboBox.Enabled = true;
                    break;
            }
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
                    staff_idComboBox.Text = dataGridView1[0, row].Value.ToString();
                    dayComboBox.Text = dataGridView1[1, row].Value.ToString();
                    edit_day = dayComboBox.Text;
                    startTextBox.Text = dataGridView1[2, row].Value.ToString();
                    edit_start = startTextBox.Text;
                    endTextBox.Text = dataGridView1[3, row].Value.ToString();
                }
            }
        }
        private void ClearTextBoxes()
        {
            foreach (var control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.Add;
            EnableButtons(operationType);
            ClearTextBoxes();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.None;
            EnableButtons(operationType);
            ClearTextBoxes();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.Update;
            EnableButtons(operationType);
        }

        string strSQLCommand;
        private void ConstructAddingString()
        {
            string strColumns = "staff_id,day,start,end";
            strSQLCommand = "insert into consultation("
                + strColumns + ") values ('"
                + staff_idComboBox.Text.Trim() + "','"
                + dayComboBox.Text.Trim() + "','"
                + startTextBox.Text.Trim() + "','"
                + endTextBox.Text.Trim() + "'"
                 + ")";
        }

        private void ConstructUpdatingString(String start, String day)
        {
            strSQLCommand = "update consultation set day='"
                + dayComboBox.Text.Trim() + "',start='"
                + startTextBox.Text.Trim() + "',end='"
                + endTextBox.Text.Trim() + "'"
                + " where staff_id ='"
                + staff_idComboBox.Text.Trim() + "' and start='"
                + start + "' and day='"
                + day + "'";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (operationType == OPERATIONTYPE.Add)
            {
                ConstructAddingString();
            }
            else
            {
                ConstructUpdatingString(edit_start,edit_day);
            }
            mysqlDbHelper.OpenConnection();
            MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(strSQLCommand);
            if (mysqlDbHelper.GetInsert(mySqlCommand))
            {
                MessageBox.Show("Successful!");
                UpdateDataSet();
            }
            else
            {
                MessageBox.Show("Faild!");
            }
            mysqlDbHelper.CloseConnection();
            operationType = OPERATIONTYPE.None;
            EnableButtons(OPERATIONTYPE.Save);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            strSQLCommand = "delete from consultation where staff_id ='"
                + staff_idComboBox.Text.Trim() + "' and day='"
                + dayComboBox.Text.Trim() + "' and start='"
                + startTextBox.Text.Trim() + "'";
            mysqlDbHelper.OpenConnection();
            MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(strSQLCommand);
            if (mysqlDbHelper.GetInsert(mySqlCommand))
            {
                MessageBox.Show("Successful!");
                UpdateDataSet();
            }
            else
            {
                MessageBox.Show("Faild!");
            }
            mysqlDbHelper.CloseConnection();
        }
    }
}
