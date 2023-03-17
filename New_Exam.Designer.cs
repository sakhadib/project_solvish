namespace Solvish
{
    partial class New_Exam
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
            this.tb_hour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_minute = new System.Windows.Forms.TextBox();
            this.StartExambutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_hour
            // 
            this.tb_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.tb_hour.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hour.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_hour.Location = new System.Drawing.Point(197, 20);
            this.tb_hour.Name = "tb_hour";
            this.tb_hour.Size = new System.Drawing.Size(63, 40);
            this.tb_hour.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(118, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hour :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(287, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minute :";
            // 
            // tb_minute
            // 
            this.tb_minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.tb_minute.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_minute.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_minute.Location = new System.Drawing.Point(390, 20);
            this.tb_minute.Name = "tb_minute";
            this.tb_minute.Size = new System.Drawing.Size(63, 40);
            this.tb_minute.TabIndex = 13;
            // 
            // StartExambutton
            // 
            this.StartExambutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(13)))));
            this.StartExambutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.StartExambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.StartExambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(5)))));
            this.StartExambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartExambutton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartExambutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StartExambutton.Location = new System.Drawing.Point(155, 98);
            this.StartExambutton.Name = "StartExambutton";
            this.StartExambutton.Size = new System.Drawing.Size(261, 51);
            this.StartExambutton.TabIndex = 14;
            this.StartExambutton.Text = "Start Exam";
            this.StartExambutton.UseVisualStyleBackColor = false;
            this.StartExambutton.Click += new System.EventHandler(this.StartExambutton_Click);
            // 
            // New_Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(756, 324);
            this.Controls.Add(this.StartExambutton);
            this.Controls.Add(this.tb_minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_hour);
            this.Controls.Add(this.label4);
            this.Name = "New_Exam";
            this.Text = "New_Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_minute;
        private System.Windows.Forms.Button StartExambutton;
    }
}