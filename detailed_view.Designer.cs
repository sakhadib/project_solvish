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
            this.result_lb = new System.Windows.Forms.ListBox();
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
            // detailed_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1323, 741);
            this.Controls.Add(this.result_lb);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "detailed_view";
            this.Text = "detailed_view";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox result_lb;
    }
}