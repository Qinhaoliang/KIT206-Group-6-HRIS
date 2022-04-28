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
    public partial class Main : Template
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            x = this.Width;
            y = this.Height;
            setTag(this);
        }

        private void ConsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();
            consultation.ShowDialog();
        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit unit = new Unit();
            unit.ShowDialog();
        }

        private void exitTemplateButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
<<<<<<< HEAD

        private void Main_Resize(object sender, EventArgs e)
        {
            x = this.Width;
            y = this.Height;
            setTag(this);
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
=======
>>>>>>> bace0bed41be952fa459be1bcb2ed33de4afee53
    }
}
