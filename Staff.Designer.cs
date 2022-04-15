
namespace HRIS
{
    partial class Staff
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.given_nameTextBox = new System.Windows.Forms.TextBox();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.campusTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picDeleteButton = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.picSelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.roomTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.given_nameTextBox);
            this.panel1.Controls.Add(this.familyTextBox);
            this.panel1.Controls.Add(this.campusTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(37, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 260);
            this.panel1.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(502, 201);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 29);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(684, 201);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(346, 201);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 29);
            this.delButton.TabIndex = 31;
            this.delButton.Text = "删除";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(199, 201);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 29);
            this.modifyButton.TabIndex = 30;
            this.modifyButton.Text = "修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(57, 201);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 29);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // roomTextBox
            // 
            this.roomTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.roomTextBox.Location = new System.Drawing.Point(90, 141);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(134, 30);
            this.roomTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "room:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.categoryTextBox.Location = new System.Drawing.Point(705, 141);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(150, 30);
            this.categoryTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(570, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "category:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(364, 141);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 30);
            this.emailTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(239, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "email:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.titleTextBox.Location = new System.Drawing.Point(90, 87);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(134, 30);
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
            this.label7.Text = "title:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(705, 90);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(150, 30);
            this.phoneTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(570, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "phone:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.idTextBox.Location = new System.Drawing.Point(90, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(134, 30);
            this.idTextBox.TabIndex = 18;
            // 
            // given_nameTextBox
            // 
            this.given_nameTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.given_nameTextBox.Location = new System.Drawing.Point(364, 36);
            this.given_nameTextBox.Name = "given_nameTextBox";
            this.given_nameTextBox.Size = new System.Drawing.Size(200, 30);
            this.given_nameTextBox.TabIndex = 17;
            // 
            // familyTextBox
            // 
            this.familyTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.familyTextBox.Location = new System.Drawing.Point(705, 39);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(150, 30);
            this.familyTextBox.TabIndex = 16;
            // 
            // campusTextBox
            // 
            this.campusTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.campusTextBox.Location = new System.Drawing.Point(364, 87);
            this.campusTextBox.Name = "campusTextBox";
            this.campusTextBox.Size = new System.Drawing.Size(200, 30);
            this.campusTextBox.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(239, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "given_name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(239, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "campus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(570, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "family_name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(15, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "id:";
            // 
            // picDeleteButton
            // 
            this.picDeleteButton.Enabled = false;
            this.picDeleteButton.Location = new System.Drawing.Point(932, 664);
            this.picDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.picDeleteButton.Name = "picDeleteButton";
            this.picDeleteButton.Size = new System.Drawing.Size(173, 29);
            this.picDeleteButton.TabIndex = 25;
            this.picDeleteButton.Text = "删除图片";
            this.picDeleteButton.UseVisualStyleBackColor = true;
            this.picDeleteButton.Click += new System.EventHandler(this.picDeleteButton_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.photoPictureBox.Location = new System.Drawing.Point(932, 382);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(173, 209);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 23;
            this.photoPictureBox.TabStop = false;
            // 
            // picSelectButton
            // 
            this.picSelectButton.Enabled = false;
            this.picSelectButton.Location = new System.Drawing.Point(932, 614);
            this.picSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.picSelectButton.Name = "picSelectButton";
            this.picSelectButton.Size = new System.Drawing.Size(173, 29);
            this.picSelectButton.TabIndex = 24;
            this.picSelectButton.Text = "选择图片";
            this.picSelectButton.UseVisualStyleBackColor = true;
            this.picSelectButton.Click += new System.EventHandler(this.picSelectButton_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 755);
            this.Controls.Add(this.picDeleteButton);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.picSelectButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox given_nameTextBox;
        private System.Windows.Forms.TextBox campusTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button picDeleteButton;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button picSelectButton;
    }
}