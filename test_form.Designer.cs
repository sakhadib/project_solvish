namespace Solvish
{
    partial class test_form
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.main_ques_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(292, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(947, 212);
            this.listBox1.TabIndex = 0;
            // 
            // main_ques_btn
            // 
            this.main_ques_btn.Location = new System.Drawing.Point(12, 12);
            this.main_ques_btn.Name = "main_ques_btn";
            this.main_ques_btn.Size = new System.Drawing.Size(209, 31);
            this.main_ques_btn.TabIndex = 1;
            this.main_ques_btn.Text = "Load main question";
            this.main_ques_btn.UseVisualStyleBackColor = true;
            this.main_ques_btn.Click += new System.EventHandler(this.main_ques_btn_Click);
            // 
            // test_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 754);
            this.Controls.Add(this.main_ques_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "test_form";
            this.Text = "test_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button main_ques_btn;
    }
}