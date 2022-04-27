
namespace HRIS
{
    partial class Template
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
            this.exitTemplateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitTemplateButton
            // 
            this.exitTemplateButton.Location = new System.Drawing.Point(13, 13);
            this.exitTemplateButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitTemplateButton.Name = "exitTemplateButton";
            this.exitTemplateButton.Size = new System.Drawing.Size(100, 29);
            this.exitTemplateButton.TabIndex = 36;
            this.exitTemplateButton.Text = "Exit";
            this.exitTemplateButton.UseVisualStyleBackColor = true;
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 165);
            this.Controls.Add(this.exitTemplateButton);
            this.Name = "Template";
            this.Text = "Template";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button exitTemplateButton;
    }
}