
namespace HRIS
{
    partial class Unit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.coordinatorComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.add1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitTemplateButton
            // 
            this.exitTemplateButton.Location = new System.Drawing.Point(409, 442);
            this.exitTemplateButton.Click += new System.EventHandler(this.exitTemplateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(471, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.codeTextBox);
            this.panel1.Controls.Add(this.coordinatorComboBox);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.add1Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(38, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 195);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.codeTextBox.Location = new System.Drawing.Point(147, 35);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(203, 30);
            this.codeTextBox.TabIndex = 37;
            // 
            // coordinatorComboBox
            // 
            this.coordinatorComboBox.Font = new System.Drawing.Font("宋体", 12F);
            this.coordinatorComboBox.FormattingEnabled = true;
            this.coordinatorComboBox.Location = new System.Drawing.Point(147, 141);
            this.coordinatorComboBox.Name = "coordinatorComboBox";
            this.coordinatorComboBox.Size = new System.Drawing.Size(203, 28);
            this.coordinatorComboBox.TabIndex = 36;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(618, 201);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // add1Button
            // 
            this.add1Button.Location = new System.Drawing.Point(367, 59);
            this.add1Button.Margin = new System.Windows.Forms.Padding(4);
            this.add1Button.Name = "add1Button";
            this.add1Button.Size = new System.Drawing.Size(100, 29);
            this.add1Button.TabIndex = 29;
            this.add1Button.Text = "Add";
            this.add1Button.UseVisualStyleBackColor = true;
            this.add1Button.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Coordinator:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.titleTextBox.Location = new System.Drawing.Point(147, 87);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(203, 30);
            this.titleTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(15, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(15, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Code:";
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Unit";
            this.Text = "unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            this.Resize += new System.EventHandler(this.Unit_Resize);
            this.Controls.SetChildIndex(this.exitTemplateButton, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox coordinatorComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button add1Button;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}