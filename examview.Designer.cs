namespace Solvish
{
    partial class examview
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.Button();
            this.ques_listbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(974, 31);
            this.comboBox1.TabIndex = 0;
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(1085, 43);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(125, 37);
            this.show.TabIndex = 1;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // ques_listbox
            // 
            this.ques_listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ques_listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ques_listbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques_listbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ques_listbox.FormattingEnabled = true;
            this.ques_listbox.ItemHeight = 24;
            this.ques_listbox.Location = new System.Drawing.Point(86, 106);
            this.ques_listbox.Name = "ques_listbox";
            this.ques_listbox.Size = new System.Drawing.Size(1124, 576);
            this.ques_listbox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1085, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // examview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1281, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ques_listbox);
            this.Controls.Add(this.show);
            this.Controls.Add(this.comboBox1);
            this.Name = "examview";
            this.Text = "examview";
            this.Load += new System.EventHandler(this.examview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.ListBox ques_listbox;
        private System.Windows.Forms.Button button1;
    }
}