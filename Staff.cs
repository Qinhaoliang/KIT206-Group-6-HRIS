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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        enum OPERATIONTYPE
        {
            Add,
            Update,
            Save,
            Cancel,
            None
        }
        OPERATIONTYPE operationType = OPERATIONTYPE.None;

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();

        private void Staff_Load(object sender, EventArgs e)
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
                string sqlstr = string.Format("select * from staff");
                DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "staff");
                dataGridView1.DataSource = dataTable.DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void EnableButtons(OPERATIONTYPE type)
        {
            switch (type)
            {
                case OPERATIONTYPE.Add:
                    addButton.Enabled = false;
                    modifyButton.Enabled = false;
                    saveButton.Enabled = true;
                    cancelButton.Enabled = true;
                    picSelectButton.Enabled = true;
                    picDeleteButton.Enabled = true;

                    break;
                case OPERATIONTYPE.Update:
                    addButton.Enabled = false;
                    modifyButton.Enabled = false;
                    saveButton.Enabled = true;
                    cancelButton.Enabled = true;
                    picSelectButton.Enabled = true;
                    picDeleteButton.Enabled = true;

                    idTextBox.Enabled = false;
                    given_nameTextBox.Enabled = false;
                    familyTextBox.Enabled = false;
                    campusTextBox.Enabled = false;
                    phoneTextBox.Enabled = false;
                    roomTextBox.Enabled = false;
                    emailTextBox.Enabled = false;
                    categoryTextBox.Enabled = false;
                    break;
                case OPERATIONTYPE.Save:
                case OPERATIONTYPE.Cancel:
                case OPERATIONTYPE.None:
                default:
                    addButton.Enabled = true;
                    modifyButton.Enabled = true;
                    saveButton.Enabled = false;
                    cancelButton.Enabled = false;
                    picSelectButton.Enabled = false;
                    picDeleteButton.Enabled = false;

                    idTextBox.Enabled = true;
                    given_nameTextBox.Enabled = true;
                    familyTextBox.Enabled = true;
                    campusTextBox.Enabled = true;
                    phoneTextBox.Enabled = true;
                    roomTextBox.Enabled = true;
                    emailTextBox.Enabled = true;
                    categoryTextBox.Enabled = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                string strFileName;
                dialog.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
                DialogResult result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    strFileName = dialog.FileName;
                    photoPictureBox.Image = Image.FromFile(strFileName);
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] pic;
            string sqlstr = string.Format("select * from staff");
            DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "staff");
            if (dataGridView1.RowCount > 1)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                idTextBox.Text = dataGridView1[0, row].Value.ToString();
                given_nameTextBox.Text = dataGridView1[1, row].Value.ToString();
                familyTextBox.Text = dataGridView1[2, row].Value.ToString();
                titleTextBox.Text = dataGridView1[3, row].Value.ToString();
                campusTextBox.Text = dataGridView1[4, row].Value.ToString();
                phoneTextBox.Text = dataGridView1[5, row].Value.ToString();
                roomTextBox.Text = dataGridView1[6, row].Value.ToString();
                emailTextBox.Text = dataGridView1[7, row].Value.ToString();
                categoryTextBox.Text = dataGridView1[9, row].Value.ToString();

                try
                {
                    if (!(dataTable.Rows[row][8] is DBNull))
                    {
                        pic = (byte[])dataTable.Rows[row][8];
                        MemoryStream ms = new MemoryStream(pic);
                        photoPictureBox.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        photoPictureBox.Image = null;
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Incomplete information");
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void picDeleteButton_Click(object sender, EventArgs e)
        {
            photoPictureBox.Image = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.Add;
            EnableButtons(operationType);
            ClearTextBoxes();
            photoPictureBox.Image = null;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.Update;
            EnableButtons(operationType);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (operationType == OPERATIONTYPE.Add)
            {
                ConstructAddingString();
                
            }
            else
            {
                ConstructUpdatingString();
            }
            byte[] bytes = Modules.Image2Bytes(photoPictureBox.Image);
            mysqlDbHelper.Initialize("localhost", "test", "root", "123456");
            mysqlDbHelper.OpenConnection();
            GetSQLcommand(strSQLCommand, strSQLParam, bytes);
            UpdateDataSet();
            mysqlDbHelper.CloseConnection();

            operationType = OPERATIONTYPE.None;
            EnableButtons(OPERATIONTYPE.Save);
        }


        public void GetSQLcommand(string strCmd, string strParam, byte[] bytes)
        {
            try
            {
                //MessageBox.Show(bytes.Length.ToString());
                MySqlCommand mySqlCommand = mysqlDbHelper.CreateCmd(strCmd);
                mySqlCommand.Parameters.Add(strParam, MySqlDbType.Binary).Value = bytes;
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw;
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.None;
            EnableButtons(operationType);

            ClearTextBoxes();
        }

        string strSQLCommand;
        string strSQLParam = "@photo";
        private void ConstructAddingString()
        {

            string strColumns = "id,given_name,family_name,title,campus,phone,room,email,category,photo";
            strSQLCommand = "insert into staff("
                + strColumns + ") values ('"
                + idTextBox.Text.Trim() + "','"
                + given_nameTextBox.Text.Trim() + "','"
                + familyTextBox.Text.Trim() + "','"
                + titleTextBox.Text.Trim() + "','"
                + campusTextBox.Text.Trim() + "','"
                + phoneTextBox.Text.Trim() + "',"
                + roomTextBox.Text.Trim() + "',"
                + emailTextBox.Text.Trim() + "',"
                + categoryTextBox.Text.Trim() + "',"
                + strSQLParam + ")";
        }

        private void ConstructUpdatingString()
        {
            strSQLCommand = "update staff set title='"
                + titleTextBox.Text.Trim() + "',Photo="
                + strSQLParam + " where id ='"
                + idTextBox.Text.Trim() + "'";
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (f_nameTextBox.Text.Trim() == "" && g_nameTextBox.Text.Trim() == "")
            {
                UpdateDataSet();
            }
            else if(f_nameTextBox.Text.Trim() == "" && g_nameTextBox.Text.Trim() != "")
            {
                string sqlstr = "select * from staff where given_name = '"
                                + g_nameTextBox.Text.Trim() + "'";
                DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "staff");
                dataGridView1.DataSource = dataTable.DefaultView;
            }
            else if (f_nameTextBox.Text.Trim() != "" && g_nameTextBox.Text.Trim() == "")
            {
                string sqlstr = "select * from staff where family_name = '"
                                + f_nameTextBox.Text.Trim() + "'";
                DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "staff");
                dataGridView1.DataSource = dataTable.DefaultView;
            }
            else
            {
                string sqlstr = "select * from staff where family_name = '"
                                + f_nameTextBox.Text.Trim() + "' and given_name = '"
                                + g_nameTextBox.Text.Trim() + "'";
                DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "staff");
                dataGridView1.DataSource = dataTable.DefaultView;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
