
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
            this.dateDailyReport = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSortVisitor = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.dailyReportGrid = new System.Windows.Forms.DataGridView();
            this.WeeklyReport = new System.Windows.Forms.TabPage();
            this.btnWeeklyClear = new System.Windows.Forms.Button();
            this.btnWeeklySortVisitor = new System.Windows.Forms.Button();
            this.btnWeeklySortEarning = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 827);
            this.tabControl1.TabIndex = 0;
            // 
            // DailyReport
            // 
            this.DailyReport.BackColor = System.Drawing.Color.MintCream;
            this.DailyReport.Controls.Add(this.dateDailyReport);
            this.DailyReport.Controls.Add(this.btnClear);
            this.DailyReport.Controls.Add(this.btnSortVisitor);
            this.DailyReport.Controls.Add(this.btnDailyReport);
            this.DailyReport.Controls.Add(this.dailyReportGrid);
            this.DailyReport.Location = new System.Drawing.Point(4, 25);
            this.DailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DailyReport.Name = "DailyReport";
            this.DailyReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DailyReport.Size = new System.Drawing.Size(1156, 798);
            this.DailyReport.TabIndex = 0;
            this.DailyReport.Text = "Daily Report";
            // 
            // dateDailyReport
            // 
            this.dateDailyReport.Location = new System.Drawing.Point(886, 650);
            this.dateDailyReport.Name = "dateDailyReport";
            this.dateDailyReport.Size = new System.Drawing.Size(244, 22);
            this.dateDailyReport.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(673, 693);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(217, 47);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSortVisitor
            // 
            this.btnSortVisitor.Location = new System.Drawing.Point(17, 693);
            this.btnSortVisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortVisitor.Name = "btnSortVisitor";
            this.btnSortVisitor.Size = new System.Drawing.Size(217, 47);
            this.btnSortVisitor.TabIndex = 3;
            this.btnSortVisitor.Text = "Sort by visitors";
            this.btnSortVisitor.UseVisualStyleBackColor = true;
            this.btnSortVisitor.Click += new System.EventHandler(this.btnSortVisitor_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(913, 693);
            this.btnDailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(217, 47);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "Generate Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // dailyReportGrid
            // 
            this.dailyReportGrid.BackgroundColor = System.Drawing.Color.White;
            this.dailyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportGrid.Location = new System.Drawing.Point(17, 21);
            this.dailyReportGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dailyReportGrid.Name = "dailyReportGrid";
            this.dailyReportGrid.RowHeadersWidth = 51;
            this.dailyReportGrid.RowTemplate.Height = 24;
            this.dailyReportGrid.Size = new System.Drawing.Size(1113, 624);
            this.dailyReportGrid.TabIndex = 0;
            // 
            // WeeklyReport
            // 
            this.WeeklyReport.BackColor = System.Drawing.Color.MintCream;
            this.WeeklyReport.Controls.Add(this.btnWeeklyClear);
            this.WeeklyReport.Controls.Add(this.btnWeeklySortVisitor);
            this.WeeklyReport.Controls.Add(this.btnWeeklySortEarning);
            this.WeeklyReport.Controls.Add(this.btnWeeklyReport);
            this.WeeklyReport.Controls.Add(this.weeklyReportGrid);
            this.WeeklyReport.Location = new System.Drawing.Point(4, 25);
            this.WeeklyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeeklyReport.Size = new System.Drawing.Size(1156, 798);
            this.WeeklyReport.TabIndex = 1;
            this.WeeklyReport.Text = "Weekly Report";
            // 
            // btnWeeklyClear
            // 
            this.btnWeeklyClear.Location = new System.Drawing.Point(671, 693);
            this.btnWeeklyClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklyClear.Name = "btnWeeklyClear";
            this.btnWeeklyClear.Size = new System.Drawing.Size(217, 47);
            this.btnWeeklyClear.TabIndex = 6;
            this.btnWeeklyClear.Text = "Clear";
            this.btnWeeklyClear.UseVisualStyleBackColor = true;
            this.btnWeeklyClear.Click += new System.EventHandler(this.btnWeeklyClear_Click);
            // 
            // btnWeeklySortVisitor
            // 
            this.btnWeeklySortVisitor.Location = new System.Drawing.Point(264, 693);
            this.btnWeeklySortVisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklySortVisitor.Name = "btnWeeklySortVisitor";
            this.btnWeeklySortVisitor.Size = new System.Drawing.Size(217, 47);
            this.btnWeeklySortVisitor.TabIndex = 5;
            this.btnWeeklySortVisitor.Text = "Sort by visitors";
            this.btnWeeklySortVisitor.UseVisualStyleBackColor = true;
            this.btnWeeklySortVisitor.Click += new System.EventHandler(this.btnWeeklySortVisitor_Click);
            // 
            // btnWeeklySortEarning
            // 
            this.btnWeeklySortEarning.Location = new System.Drawing.Point(17, 693);
            this.btnWeeklySortEarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklySortEarning.Name = "btnWeeklySortEarning";
            this.btnWeeklySortEarning.Size = new System.Drawing.Size(217, 47);
            this.btnWeeklySortEarning.TabIndex = 4;
            this.btnWeeklySortEarning.Text = "Sort by earning";
            this.btnWeeklySortEarning.UseVisualStyleBackColor = true;
            this.btnWeeklySortEarning.Click += new System.EventHandler(this.btnWeeklySortEarning_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(913, 693);
            this.btnWeeklyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(217, 47);
            this.btnWeeklyReport.TabIndex = 1;
            this.btnWeeklyReport.Text = "Generate Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // weeklyReportGrid
            // 
            this.weeklyReportGrid.BackgroundColor = System.Drawing.Color.White;
            this.weeklyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportGrid.Location = new System.Drawing.Point(17, 21);
            this.weeklyReportGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weeklyReportGrid.Name = "weeklyReportGrid";
            this.weeklyReportGrid.RowHeadersWidth = 51;
            this.weeklyReportGrid.RowTemplate.Height = 24;
            this.weeklyReportGrid.Size = new System.Drawing.Size(1113, 624);
            this.weeklyReportGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(436, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1169, 873);
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
        private System.Windows.Forms.Button btnSortVisitor;
        private System.Windows.Forms.Button btnWeeklySortVisitor;
        private System.Windows.Forms.Button btnWeeklySortEarning;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWeeklyClear;
        private System.Windows.Forms.DateTimePicker dateDailyReport;
    }
}
