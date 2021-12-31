
namespace _19030690_Abhinav_Parajuli
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPriceDetails = new System.Windows.Forms.Button();
            this.btmTicket = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRegisterEmployee = new System.Windows.Forms.Button();
            this.ticketDetails1 = new _19030690_Abhinav_Parajuli.TicketDetails();
            this.report1 = new _19030690_Abhinav_Parajuli.Report();
            this.priceRate1 = new _19030690_Abhinav_Parajuli.PriceRate();
            this.priceDetails1 = new _19030690_Abhinav_Parajuli.PriceDetails();
            this.chart1 = new _19030690_Abhinav_Parajuli.Chart();
            this.admin1 = new _19030690_Abhinav_Parajuli.Admin();
            this.registerEmployee1 = new _19030690_Abhinav_Parajuli.RegisterEmployee();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btnRegisterEmployee);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPriceDetails);
            this.panel1.Controls.Add(this.btmTicket);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnChart);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 713);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(73, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPriceDetails
            // 
            this.btnPriceDetails.BackColor = System.Drawing.Color.White;
            this.btnPriceDetails.Location = new System.Drawing.Point(-2, 199);
            this.btnPriceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnPriceDetails.Name = "btnPriceDetails";
            this.btnPriceDetails.Size = new System.Drawing.Size(230, 45);
            this.btnPriceDetails.TabIndex = 6;
            this.btnPriceDetails.Text = "Price Details";
            this.btnPriceDetails.UseVisualStyleBackColor = false;
            this.btnPriceDetails.Click += new System.EventHandler(this.btnPriceDetails_Click);
            // 
            // btmTicket
            // 
            this.btmTicket.BackColor = System.Drawing.Color.White;
            this.btmTicket.Location = new System.Drawing.Point(0, 150);
            this.btmTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btmTicket.Name = "btmTicket";
            this.btmTicket.Size = new System.Drawing.Size(228, 45);
            this.btmTicket.TabIndex = 5;
            this.btmTicket.Text = "Ticket";
            this.btmTicket.UseVisualStyleBackColor = false;
            this.btmTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(-2, 100);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(232, 45);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.White;
            this.btnChart.Location = new System.Drawing.Point(-2, 50);
            this.btnChart.Margin = new System.Windows.Forms.Padding(2);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(230, 45);
            this.btnChart.TabIndex = 2;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 0);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(228, 45);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRegisterEmployee
            // 
            this.btnRegisterEmployee.BackColor = System.Drawing.Color.White;
            this.btnRegisterEmployee.Location = new System.Drawing.Point(-2, 248);
            this.btnRegisterEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterEmployee.Name = "btnRegisterEmployee";
            this.btnRegisterEmployee.Size = new System.Drawing.Size(230, 45);
            this.btnRegisterEmployee.TabIndex = 8;
            this.btnRegisterEmployee.Text = "Register Employee";
            this.btnRegisterEmployee.UseVisualStyleBackColor = false;
            this.btnRegisterEmployee.Click += new System.EventHandler(this.btnRegisterEmployee_Click);
            // 
            // ticketDetails1
            // 
            this.ticketDetails1.BackColor = System.Drawing.Color.MintCream;
            this.ticketDetails1.Location = new System.Drawing.Point(234, 3);
            this.ticketDetails1.Margin = new System.Windows.Forms.Padding(2);
            this.ticketDetails1.Name = "ticketDetails1";
            this.ticketDetails1.Size = new System.Drawing.Size(877, 709);
            this.ticketDetails1.TabIndex = 7;
            // 
            // report1
            // 
            this.report1.BackColor = System.Drawing.Color.MintCream;
            this.report1.Location = new System.Drawing.Point(234, 1);
            this.report1.Margin = new System.Windows.Forms.Padding(2);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(877, 709);
            this.report1.TabIndex = 6;
            // 
            // priceRate1
            // 
            this.priceRate1.BackColor = System.Drawing.Color.MintCream;
            this.priceRate1.Location = new System.Drawing.Point(234, 1);
            this.priceRate1.Margin = new System.Windows.Forms.Padding(2);
            this.priceRate1.Name = "priceRate1";
            this.priceRate1.Size = new System.Drawing.Size(877, 709);
            this.priceRate1.TabIndex = 5;
            // 
            // priceDetails1
            // 
            this.priceDetails1.BackColor = System.Drawing.Color.MintCream;
            this.priceDetails1.Location = new System.Drawing.Point(234, 1);
            this.priceDetails1.Margin = new System.Windows.Forms.Padding(2);
            this.priceDetails1.Name = "priceDetails1";
            this.priceDetails1.Size = new System.Drawing.Size(877, 709);
            this.priceDetails1.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MintCream;
            this.chart1.Location = new System.Drawing.Point(234, 1);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(877, 709);
            this.chart1.TabIndex = 3;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.Color.MintCream;
            this.admin1.Location = new System.Drawing.Point(234, -1);
            this.admin1.Margin = new System.Windows.Forms.Padding(2);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(877, 709);
            this.admin1.TabIndex = 2;
            // 
            // registerEmployee1
            // 
            this.registerEmployee1.BackColor = System.Drawing.Color.MintCream;
            this.registerEmployee1.Location = new System.Drawing.Point(233, 0);
            this.registerEmployee1.Name = "registerEmployee1";
            this.registerEmployee1.Size = new System.Drawing.Size(877, 709);
            this.registerEmployee1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1109, 705);
            this.Controls.Add(this.registerEmployee1);
            this.Controls.Add(this.ticketDetails1);
            this.Controls.Add(this.report1);
            this.Controls.Add(this.priceRate1);
            this.Controls.Add(this.priceDetails1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btmTicket;
        private System.Windows.Forms.Button btnPriceDetails;
        private Admin admin1;
        private Chart chart1;
        private PriceDetails priceDetails1;
        private PriceRate priceRate1;
        private Report report1;
        private TicketDetails ticketDetails1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRegisterEmployee;
        private RegisterEmployee registerEmployee1;
    }
}

