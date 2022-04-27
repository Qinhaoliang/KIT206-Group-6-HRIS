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
    }
}
