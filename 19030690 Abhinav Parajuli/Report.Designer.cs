
namespace _19030690_Abhinav_Parajuli
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DailyReport = new System.Windows.Forms.TabPage();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.dailyReportGrid = new System.Windows.Forms.DataGridView();
            this.WeeklyReport = new System.Windows.Forms.TabPage();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.weeklyReportGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DailyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).BeginInit();
            this.WeeklyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DailyReport);
            this.tabControl1.Controls.Add(this.WeeklyReport);
            this.tabControl1.Location = new System.Drawing.Point(2, 35);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // DailyReport
            // 
            this.DailyReport.BackColor = System.Drawing.Color.MintCream;
            this.DailyReport.Controls.Add(this.btnDailyReport);
            this.DailyReport.Controls.Add(this.dailyReportGrid);
            this.DailyReport.Location = new System.Drawing.Point(4, 22);
            this.DailyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DailyReport.Name = "DailyReport";
            this.DailyReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DailyReport.Size = new System.Drawing.Size(865, 646);
            this.DailyReport.TabIndex = 0;
            this.DailyReport.Text = "Daily Report";
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(666, 563);
            this.btnDailyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(163, 38);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "Generate Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // dailyReportGrid
            // 
            this.dailyReportGrid.BackgroundColor = System.Drawing.Color.White;
            this.dailyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportGrid.Location = new System.Drawing.Point(13, 17);
            this.dailyReportGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dailyReportGrid.Name = "dailyReportGrid";
            this.dailyReportGrid.RowHeadersWidth = 51;
            this.dailyReportGrid.RowTemplate.Height = 24;
            this.dailyReportGrid.Size = new System.Drawing.Size(835, 507);
            this.dailyReportGrid.TabIndex = 0;
            // 
            // WeeklyReport
            // 
            this.WeeklyReport.BackColor = System.Drawing.Color.MintCream;
            this.WeeklyReport.Controls.Add(this.btnWeeklyReport);
            this.WeeklyReport.Controls.Add(this.weeklyReportGrid);
            this.WeeklyReport.Location = new System.Drawing.Point(4, 22);
            this.WeeklyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeeklyReport.Size = new System.Drawing.Size(865, 646);
            this.WeeklyReport.TabIndex = 1;
            this.WeeklyReport.Text = "Weekly Report";
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(666, 563);
            this.btnWeeklyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(163, 38);
            this.btnWeeklyReport.TabIndex = 1;
            this.btnWeeklyReport.Text = "Generate Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // weeklyReportGrid
            // 
            this.weeklyReportGrid.BackgroundColor = System.Drawing.Color.White;
            this.weeklyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportGrid.Location = new System.Drawing.Point(13, 17);
            this.weeklyReportGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weeklyReportGrid.Name = "weeklyReportGrid";
            this.weeklyReportGrid.RowHeadersWidth = 51;
            this.weeklyReportGrid.RowTemplate.Height = 24;
            this.weeklyReportGrid.Size = new System.Drawing.Size(835, 507);
            this.weeklyReportGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(877, 709);
            this.tabControl1.ResumeLayout(false);
            this.DailyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).EndInit();
            this.WeeklyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DailyReport;
        private System.Windows.Forms.TabPage WeeklyReport;
        private System.Windows.Forms.DataGridView dailyReportGrid;
        private System.Windows.Forms.DataGridView weeklyReportGrid;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Label label1;
    }
}
