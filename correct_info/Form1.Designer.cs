namespace correct_info
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.correct_info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // correct_info
            // 
            this.correct_info.Location = new System.Drawing.Point(29, 62);
            this.correct_info.Name = "correct_info";
            this.correct_info.Size = new System.Drawing.Size(109, 23);
            this.correct_info.TabIndex = 0;
            this.correct_info.Text = "correct info";
            this.correct_info.UseVisualStyleBackColor = true;
            this.correct_info.Click += new System.EventHandler(this.correct_info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Close ACT\r\n2.Press button\r\n3.support_info.zip is output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 97);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correct_info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "correct info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button correct_info;
        private Label label1;
    }
}