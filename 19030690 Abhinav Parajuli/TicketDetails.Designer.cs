
namespace _19030690_Abhinav_Parajuli
{
    partial class TicketDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbTicketCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ticketGridView = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCheckoutID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(121, 166);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(155, 22);
            this.txtAge.TabIndex = 4;
            // 
            // cmbTicketCategory
            // 
            this.cmbTicketCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketCategory.FormattingEnabled = true;
            this.cmbTicketCategory.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.cmbTicketCategory.Location = new System.Drawing.Point(412, 57);
            this.cmbTicketCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTicketCategory.Name = "cmbTicketCategory";
            this.cmbTicketCategory.Size = new System.Drawing.Size(177, 24);
            this.cmbTicketCategory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(425, 276);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 33);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ticketGridView
            // 
            this.ticketGridView.BackgroundColor = System.Drawing.Color.White;
            this.ticketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGridView.Location = new System.Drawing.Point(16, 383);
            this.ticketGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketGridView.Name = "ticketGridView";
            this.ticketGridView.RowHeadersWidth = 51;
            this.ticketGridView.RowTemplate.Height = 24;
            this.ticketGridView.Size = new System.Drawing.Size(1133, 430);
            this.ticketGridView.TabIndex = 12;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(1017, 817);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(123, 33);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(868, 17);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(207, 274);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(123, 33);
            this.btnCheckout.TabIndex = 15;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 22);
            this.txtID.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            // 
            // txtCheckoutID
            // 
            this.txtCheckoutID.Location = new System.Drawing.Point(207, 113);
            this.txtCheckoutID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckoutID.Name = "txtCheckoutID";
            this.txtCheckoutID.Size = new System.Drawing.Size(157, 22);
            this.txtCheckoutID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTicketCategory);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(640, 332);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check In";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheckout);
            this.groupBox2.Controls.Add(this.txtCheckoutID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(661, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(488, 331);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Out";
            // 
            // TicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ticketGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketDetails";
            this.Size = new System.Drawing.Size(1169, 873);
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbTicketCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView ticketGridView;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCheckoutID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
