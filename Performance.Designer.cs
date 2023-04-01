namespace Solvish
{
    partial class Performance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.exam_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.right_wrong_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.back_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exam_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_wrong_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // exam_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.exam_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.exam_chart.Legends.Add(legend1);
            this.exam_chart.Location = new System.Drawing.Point(0, 1);
            this.exam_chart.Name = "exam_chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Exam";
            this.exam_chart.Series.Add(series1);
            this.exam_chart.Size = new System.Drawing.Size(799, 303);
            this.exam_chart.TabIndex = 0;
            this.exam_chart.Text = "exam_chart";
            this.toolTip1.SetToolTip(this.exam_chart, "Individual Exam and obtained marks");
            // 
            // right_wrong_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.right_wrong_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.right_wrong_chart.Legends.Add(legend2);
            this.right_wrong_chart.Location = new System.Drawing.Point(93, 330);
            this.right_wrong_chart.Name = "right_wrong_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Right_Wrong";
            this.right_wrong_chart.Series.Add(series2);
            this.right_wrong_chart.Size = new System.Drawing.Size(580, 316);
            this.right_wrong_chart.TabIndex = 1;
            this.right_wrong_chart.Text = "right_wrong_chart";
            this.toolTip2.SetToolTip(this.right_wrong_chart, "Your lifetime Progress");
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(690, 654);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(109, 39);
            this.back_button.TabIndex = 12;
            this.back_button.Text = "Back";
            this.toolTip3.SetToolTip(this.back_button, "To go back to Dashboard");
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Click";
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.right_wrong_chart);
            this.Controls.Add(this.exam_chart);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Performance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance";
            ((System.ComponentModel.ISupportInitialize)(this.exam_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_wrong_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart exam_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart right_wrong_chart;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}