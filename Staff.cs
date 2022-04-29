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
            x = this.Width;
            y = this.Height;
            setTag(this);
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

        private const string db = "hris";
        private const string user = "kit206g20a";
        private const string pass = "group20a";
        private const string server = "alacritas.cis.utas.edu.au";

        private void Staff_Load(object sender, EventArgs e)
        {
            mysqlDbHelper.Initialize(server, db, user, pass);
            mysqlDbHelper.OpenConnection();
            UpdateDataSet();
            mysqlDbHelper.CloseConnection();

            campusComboBox.Items.Add("Hobart");
            campusComboBox.Items.Add("Launceston");
            campusComboBox.SelectedIndex = 0;

            categoryComboBox.Items.Add("Academic");
            categoryComboBox.Items.Add("Technical");
            categoryComboBox.Items.Add("Admin");
            categoryComboBox.Items.Add("Casual");
            categoryComboBox.SelectedIndex = 0;

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

                    IDTextBox.Enabled = false;
                    given_nameTextBox.Enabled = false;
                    familyTextBox.Enabled = false;
                    campusComboBox.Enabled = false;
                    phoneTextBox.Enabled = false;
                    roomTextBox.Enabled = false;
                    emailTextBox.Enabled = false;
                    categoryComboBox.Enabled = false;
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

                    titleTextBox.Enabled = true;
                    IDTextBox.Enabled = true;
                    given_nameTextBox.Enabled = true;
                    familyTextBox.Enabled = true;
                    campusComboBox.Enabled = true;
                    phoneTextBox.Enabled = true;
                    roomTextBox.Enabled = true;
                    emailTextBox.Enabled = true;
                    categoryComboBox.Enabled = true;
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
                IDTextBox.Text = dataGridView1[0, row].Value.ToString();
                given_nameTextBox.Text = dataGridView1[1, row].Value.ToString();
                familyTextBox.Text = dataGridView1[2, row].Value.ToString();
                titleTextBox.Text = dataGridView1[3, row].Value.ToString();
                campusComboBox.Text = dataGridView1[4, row].Value.ToString();
                phoneTextBox.Text = dataGridView1[5, row].Value.ToString();
                roomTextBox.Text = dataGridView1[6, row].Value.ToString();
                emailTextBox.Text = dataGridView1[7, row].Value.ToString();
                categoryComboBox.Text = dataGridView1[9, row].Value.ToString();

                if (operationType == OPERATIONTYPE.Add)
                {
                    foreach (var control in panel1.Controls)
                    {
                        if (control is TextBox)
                        {
                            ((TextBox)control).Enabled = true;
                        }
                        if (control is ComboBox)
                        {
                            ((ComboBox)control).Enabled = true;
                        }
                    }
                    categoryComboBox.Enabled = true;
                    foreach (var control in panel1.Controls)
                    {
                        if (control is TextBox && !((TextBox)control).Text.Equals(""))
                        {
                            ((TextBox)control).Enabled = false;
                        }
                        if (control is ComboBox && !((ComboBox)control).Text.Equals(""))
                        {
                            ((ComboBox)control).Enabled = false;
                        }
                    }
                    if (!categoryComboBox.Text.Equals(""))
                    {
                        categoryComboBox.Enabled = false;
                    }
                }
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
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.None;
            EnableButtons(operationType);
            ClearTextBoxes();
        }

        string strSQLCommand;
        string strSQLParam = "@Param";
        private void ConstructAddingString()
        {
            string strColumns = "";
            strSQLCommand = "update staff set title='"
                + titleTextBox.Text.Trim() + "',campus='"
                + campusComboBox.Text.Trim() + "',phone='"
                + phoneTextBox.Text.Trim() + "',room='"
                + roomTextBox.Text.Trim() + "',email='"
                + emailTextBox.Text.Trim() + "',category='"
                + categoryComboBox.Text.Trim() + "',Photo="
                + strSQLParam + " where id ='"
                + IDTextBox.Text.Trim() + "'";
        }

        private void ConstructUpdatingString()
        {
            strSQLCommand = "update staff set title='"
                + titleTextBox.Text.Trim() + "',Photo="
                + strSQLParam + " where id ='"
                + IDTextBox.Text.Trim() + "'";
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
            else if (f_nameTextBox.Text.Trim() == "" && g_nameTextBox.Text.Trim() != "")
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


        private float x;//Defines the width of the current form
        private float y;//Defines the height of the current form
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
            //Iterate over the control in the form, resetting the value of the control
            foreach (Control con in cons.Controls)
            {
                //Gets the value of the Tag property of the control and stores an array of strings after splitting
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //Determines the value of the control based on the scale of the form
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//width 
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//height 
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//The left margin
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//The top margin
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//font size 
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();
            consultation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.ShowDialog();
        }

        private void Staff_Resize_1(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

