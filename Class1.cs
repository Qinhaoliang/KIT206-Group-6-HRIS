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
            this.StartPosition = FormStartPosition.CenterScreen;  //The form is in the center of the screen
            x = this.Width;
            y = this.Height;
            setTag(this);
        }
        enum OPERATIONTYPE    //Enable the button
        {
            Add,
            Update,
            Save,
            Cancel,
            None
        }
        OPERATIONTYPE operationType = OPERATIONTYPE.None;

        string edit_unit_code, edit_campus, edit_day, edit_start;

        MysqlDbHelper mysqlDbHelper = new MysqlDbHelper();
        
        private const string db = "hris";
        private const string user = "kit206g20a";
        private const string pass = "group20a";
        private const string server = "alacritas.cis.utas.edu.au";

        private void Form1_Load(object sender, EventArgs e)
        {
            
            mysqlDbHelper.Initialize(server, db, user, pass);
            mysqlDbHelper.OpenConnection();
            UpdateDataSet();

            dayComboBox.Items.Add("Monday");
            dayComboBox.Items.Add("Tuesday");
            dayComboBox.Items.Add("Wednesday");
            dayComboBox.Items.Add("Thursday");
            dayComboBox.Items.Add("Friday");
            dayComboBox.Items.Add("Saturday");
            dayComboBox.Items.Add("Sunday");
            dayComboBox.SelectedIndex = 0;

            campusComboBox.Items.Add("Hobart");
            campusComboBox.Items.Add("Launceston");
            campusComboBox.SelectedIndex = 0;


            typeComboBox.Items.Add("Lecture");
            typeComboBox.Items.Add("Tutorial");
            typeComboBox.Items.Add("Practical");
            typeComboBox.Items.Add("Workshop");
            typeComboBox.SelectedIndex = 0;

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
            staffComboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                staffComboBox.Items.Add(list[i]);
            }
            staffComboBox.SelectedIndex = 0;

            reader.Close();
            list.Clear();

            sqlstr = string.Format("select code from unit");   //Get all code values from the unit table (foreign key)
            mySqlCommand = mysqlDbHelper.CreateCmd(sqlstr);
            reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader[i].ToString());
                }
            }
            unit_codeComboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                unit_codeComboBox.Items.Add(list[i]);
            }
            unit_codeComboBox.SelectedIndex = 0;

            mysqlDbHelper.CloseConnection();

        }

        private void UpdateDataSet()
        {
            string sqlstr = string.Format("select * from class");
            DataTable dataTable = mysqlDbHelper.GetDataTable(sqlstr, "class");
            dataGridView1.DataSource = dataTable.DefaultView;
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
                    break;
                case OPERATIONTYPE.Update:
                    addButton.Enabled = false;
                    modifyButton.Enabled = false;
                    saveButton.Enabled = true;
                    cancelButton.Enabled = true;
                    break;
                case OPERATIONTYPE.Save:
                case OPERATIONTYPE.Cancel:
                case OPERATIONTYPE.None:
                default:
                    addButton.Enabled = true;
                    modifyButton.Enabled = true;
                    saveButton.Enabled = false;
                    cancelButton.Enabled = false;
                    break;
            }
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
                    MessageBox.Show("Empty line currently selected!");
                }
                else
                {
                    unit_codeComboBox.Text = dataGridView1[0, row].Value.ToString();
                    campusComboBox.Text = dataGridView1[1, row].Value.ToString();
                    dayComboBox.Text = dataGridView1[2, row].Value.ToString();
                    startTextBox.Text = dataGridView1[3, row].Value.ToString();
                    endTextBox.Text = dataGridView1[4, row].Value.ToString();
                    typeComboBox.Text = dataGridView1[5, row].Value.ToString();
                    roomTextBox.Text = dataGridView1[6, row].Value.ToString();
                    staffComboBox.Text = dataGridView1[7, row].Value.ToString();

                    edit_unit_code = unit_codeComboBox.Text;
                    edit_campus = campusComboBox.Text;
                    edit_day = dayComboBox.Text;
                    edit_start = startTextBox.Text;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.Add;
            EnableButtons(operationType);
            ClearTextBoxes();
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
                ConstructUpdatingString( edit_unit_code, edit_campus, edit_day, edit_start);
                unit_codeComboBox.Text = strSQLCommand;
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
                MessageBox.Show("FAIL!");
            }
            mysqlDbHelper.CloseConnection();
            operationType = OPERATIONTYPE.None;
            EnableButtons(OPERATIONTYPE.Save);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            operationType = OPERATIONTYPE.None;
            EnableButtons(operationType);
            ClearTextBoxes();
        }

        private void Class1_Resize(object sender, EventArgs e)
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

        string strSQLCommand;
        private void ConstructAddingString()
        {
            string strColumns = "";
            if (typeComboBox.Text.Trim() == "" && staffComboBox.Text.Trim() == "")
            {
                strColumns = "unit_code,campus,day,start,end,room";    //Constructing SQL statements
                strSQLCommand = "insert into class("
                    + strColumns + ") values ('"
                    + unit_codeComboBox.Text.Trim() + "','"
                    + campusComboBox.Text.Trim() + "','"
                    + dayComboBox.Text.Trim() + "','"
                    + startTextBox.Text.Trim() + "','"
                    + endTextBox.Text.Trim() + "','"
                    + roomTextBox.Text.Trim() + "')";
            }
            else if (typeComboBox.Text.Trim() != "" && staffComboBox.Text.Trim() == "")
            {
                strColumns = "unit_code,campus,day,start,end,type,room";
                strSQLCommand = "insert into class("
                    + strColumns + ") values ('"
                    + unit_codeComboBox.Text.Trim() + "','"
                    + campusComboBox.Text.Trim() + "','"
                    + dayComboBox.Text.Trim() + "','"
                    + startTextBox.Text.Trim() + "','"
                    + endTextBox.Text.Trim() + "','"
                    + typeComboBox.Text.Trim() + "','"
                    + roomTextBox.Text.Trim() + "')";
            }
            else if (typeComboBox.Text.Trim() == "" && staffComboBox.Text.Trim() != "")
            {
                strColumns = "unit_code,campus,day,start,end,room,staff";
                strSQLCommand = "insert into class("
                    + strColumns + ") values ('"
                    + unit_codeComboBox.Text.Trim() + "','"
                    + campusComboBox.Text.Trim() + "','"
                    + dayComboBox.Text.Trim() + "','"
                    + startTextBox.Text.Trim() + "','"
                    + endTextBox.Text.Trim() + "','"
                    + roomTextBox.Text.Trim() + "','"
                    + staffComboBox.Text.Trim() + "')";
            }
            else
            {
                strColumns = "unit_code,campus,day,start,end,type,room,staff";
                strSQLCommand = "insert into class("
                    + strColumns + ") values ('"
                    + unit_codeComboBox.Text.Trim() + "','"
                    + campusComboBox.Text.Trim() + "','"
                    + dayComboBox.Text.Trim() + "','"
                    + startTextBox.Text.Trim() + "','"
                    + endTextBox.Text.Trim() + "','"
                    + typeComboBox.Text.Trim() + "','"
                    + roomTextBox.Text.Trim() + "','"
                    + staffComboBox.Text.Trim() + "')";
            }
        }

        private void ConstructUpdatingString(string edit_unit_code, string edit_campus, string edit_day, string edit_start)
        {
            strSQLCommand = "update class set unit_code='"
                + unit_codeComboBox.Text.Trim() + "',campus='"
                + campusComboBox.Text.Trim() + "',day='"
                + dayComboBox.Text.Trim() + "',start='"
                + startTextBox.Text.Trim() + "',end='"
                + endTextBox.Text.Trim() + "',type='"
                + typeComboBox.Text.Trim() + "',room='"
                + roomTextBox.Text.Trim() + "',staff='"
                + staffComboBox.Text.Trim() + "'"
                + " where unit_code ='"
                + edit_unit_code + "' and campus='"
                + edit_campus + "' and day='"
                + edit_day + "' and start='"
                + edit_start + "'";
        }
    }
    
}
