﻿
namespace HRIS
{
    partial class Class1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.testDataSet = new HRIS.testDataSet();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new HRIS.testDataSetTableAdapters.classTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staffTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campusTextBox = new System.Windows.Forms.TextBox();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.unit_codeTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.testDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 247);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.staffTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roomTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.campusTextBox);
            this.panel1.Controls.Add(this.startTextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.typeTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.unit_codeTextBox);
            this.panel1.Controls.Add(this.dayTextBox);
            this.panel1.Controls.Add(this.endTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(29, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 217);
            this.panel1.TabIndex = 11;
            // 
            // staffTextBox
            // 
            this.staffTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.staffTextBox.Location = new System.Drawing.Point(859, 89);
            this.staffTextBox.Name = "staffTextBox";
            this.staffTextBox.Size = new System.Drawing.Size(130, 30);
            this.staffTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(764, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "staff:";
            // 
            // roomTextBox
            // 
            this.roomTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.roomTextBox.Location = new System.Drawing.Point(859, 33);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(130, 30);
            this.roomTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(765, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "room:";
            // 
            // campusTextBox
            // 
            this.campusTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.campusTextBox.Location = new System.Drawing.Point(138, 84);
            this.campusTextBox.Name = "campusTextBox";
            this.campusTextBox.Size = new System.Drawing.Size(134, 30);
            this.campusTextBox.TabIndex = 22;
            // 
            // startTextBox
            // 
            this.startTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.startTextBox.Location = new System.Drawing.Point(593, 33);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(150, 30);
            this.startTextBox.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(518, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "start:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.typeTextBox.Location = new System.Drawing.Point(364, 87);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(133, 30);
            this.typeTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(288, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(15, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "campus:";
            // 
            // unit_codeTextBox
            // 
            this.unit_codeTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.unit_codeTextBox.Location = new System.Drawing.Point(138, 29);
            this.unit_codeTextBox.Name = "unit_codeTextBox";
            this.unit_codeTextBox.Size = new System.Drawing.Size(134, 30);
            this.unit_codeTextBox.TabIndex = 18;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.dayTextBox.Location = new System.Drawing.Point(364, 33);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(133, 30);
            this.dayTextBox.TabIndex = 17;
            // 
            // endTextBox
            // 
            this.endTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.endTextBox.Location = new System.Drawing.Point(593, 87);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(150, 30);
            this.endTextBox.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(289, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "day:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(517, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "end:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(15, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "unit_code:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 39;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(469, 162);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 29);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(623, 162);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 38;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(316, 162);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 29);
            this.modifyButton.TabIndex = 36;
            this.modifyButton.Text = "Edit";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(154, 162);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 29);
            this.addButton.TabIndex = 35;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // Class1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Class1";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private testDataSetTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox campusTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unit_codeTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox staffTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;
    }
}

