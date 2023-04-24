namespace Solvish
{
    partial class detailed_view
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
            this.components = new System.ComponentModel.Container();
            this.result_lb = new System.Windows.Forms.ListBox();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result_lb
            // 
            this.result_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.result_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lb.ForeColor = System.Drawing.SystemColors.Info;
            this.result_lb.FormattingEnabled = true;
            this.result_lb.ItemHeight = 31;
            this.result_lb.Location = new System.Drawing.Point(12, 74);
            this.result_lb.Name = "result_lb";
            this.result_lb.Size = new System.Drawing.Size(1299, 655);
            this.result_lb.TabIndex = 5;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 17);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(321, 51);
            this.dashboard_btn.TabIndex = 12;
            this.dashboard_btn.Text = "Back to Dashboard";
            this.toolTip1.SetToolTip(this.dashboard_btn, "To go back to dashboard");
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Click";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(969, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "See Partiicullar Exam Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailed_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1323, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dashboard_btn);
            this.Controls.Add(this.result_lb);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "detailed_view";
            this.Text = "detailed_view";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox result_lb;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}