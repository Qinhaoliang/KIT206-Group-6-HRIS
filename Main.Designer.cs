
namespace HRIS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassToolStripMenuItem,
            this.ConsToolStripMenuItem,
            this.StaffToolStripMenuItem1,
            this.unitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ClassToolStripMenuItem
            // 
            this.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem";
            this.ClassToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.ClassToolStripMenuItem.Text = "Class";
            this.ClassToolStripMenuItem.Click += new System.EventHandler(this.ClassToolStripMenuItem_Click);
            // 
            // ConsToolStripMenuItem
            // 
            this.ConsToolStripMenuItem.Name = "ConsToolStripMenuItem";
            this.ConsToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.ConsToolStripMenuItem.Text = "Consultation";
            this.ConsToolStripMenuItem.Click += new System.EventHandler(this.ConsToolStripMenuItem_Click);
            // 
            // StaffToolStripMenuItem1
            // 
            this.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1";
            this.StaffToolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.StaffToolStripMenuItem1.Text = "Staff";
            this.StaffToolStripMenuItem1.Click += new System.EventHandler(this.StaffToolStripMenuItem1_Click);
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.unitToolStripMenuItem.Text = "Unit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 224);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}