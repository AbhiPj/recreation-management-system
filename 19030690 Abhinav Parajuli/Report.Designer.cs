
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
            this.dailyReportGrid = new System.Windows.Forms.DataGridView();
            this.WeeklyReport = new System.Windows.Forms.TabPage();
            this.weeklyReportGrid = new System.Windows.Forms.DataGridView();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // DailyReport
            // 
            this.DailyReport.Controls.Add(this.btnDailyReport);
            this.DailyReport.Controls.Add(this.dailyReportGrid);
            this.DailyReport.Location = new System.Drawing.Point(4, 25);
            this.DailyReport.Name = "DailyReport";
            this.DailyReport.Padding = new System.Windows.Forms.Padding(3);
            this.DailyReport.Size = new System.Drawing.Size(792, 594);
            this.DailyReport.TabIndex = 0;
            this.DailyReport.Text = "Daily Report";
            this.DailyReport.UseVisualStyleBackColor = true;
            // 
            // dailyReportGrid
            // 
            this.dailyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportGrid.Location = new System.Drawing.Point(21, 16);
            this.dailyReportGrid.Name = "dailyReportGrid";
            this.dailyReportGrid.RowHeadersWidth = 51;
            this.dailyReportGrid.RowTemplate.Height = 24;
            this.dailyReportGrid.Size = new System.Drawing.Size(747, 376);
            this.dailyReportGrid.TabIndex = 0;
            // 
            // WeeklyReport
            // 
            this.WeeklyReport.Controls.Add(this.btnWeeklyReport);
            this.WeeklyReport.Controls.Add(this.weeklyReportGrid);
            this.WeeklyReport.Location = new System.Drawing.Point(4, 25);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Padding = new System.Windows.Forms.Padding(3);
            this.WeeklyReport.Size = new System.Drawing.Size(792, 594);
            this.WeeklyReport.TabIndex = 1;
            this.WeeklyReport.Text = "Weekly Report";
            this.WeeklyReport.UseVisualStyleBackColor = true;
            // 
            // weeklyReportGrid
            // 
            this.weeklyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportGrid.Location = new System.Drawing.Point(17, 21);
            this.weeklyReportGrid.Name = "weeklyReportGrid";
            this.weeklyReportGrid.RowHeadersWidth = 51;
            this.weeklyReportGrid.RowTemplate.Height = 24;
            this.weeklyReportGrid.Size = new System.Drawing.Size(758, 394);
            this.weeklyReportGrid.TabIndex = 0;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(322, 472);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(123, 47);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "Generate Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(319, 486);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(126, 49);
            this.btnWeeklyReport.TabIndex = 1;
            this.btnWeeklyReport.Text = "Generate Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(830, 659);
            this.tabControl1.ResumeLayout(false);
            this.DailyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).EndInit();
            this.WeeklyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DailyReport;
        private System.Windows.Forms.TabPage WeeklyReport;
        private System.Windows.Forms.DataGridView dailyReportGrid;
        private System.Windows.Forms.DataGridView weeklyReportGrid;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnWeeklyReport;
    }
}
