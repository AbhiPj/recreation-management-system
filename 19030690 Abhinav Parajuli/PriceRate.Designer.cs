
namespace _19030690_Abhinav_Parajuli
{
    partial class PriceRate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTicketCategory = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtRate1 = new System.Windows.Forms.TextBox();
            this.txtRate2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtRate3 = new System.Windows.Forms.TextBox();
            this.txtRate4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWholeDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTicketCategory
            // 
            this.lblTicketCategory.AutoSize = true;
            this.lblTicketCategory.Location = new System.Drawing.Point(83, 71);
            this.lblTicketCategory.Name = "lblTicketCategory";
            this.lblTicketCategory.Size = new System.Drawing.Size(65, 17);
            this.lblTicketCategory.TabIndex = 1;
            this.lblTicketCategory.Text = "Category";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(83, 128);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(90, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Rate for 1 Hr";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(83, 191);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Rate for 2Hrs";
            // 
            // txtRate1
            // 
            this.txtRate1.Location = new System.Drawing.Point(210, 128);
            this.txtRate1.Name = "txtRate1";
            this.txtRate1.Size = new System.Drawing.Size(109, 22);
            this.txtRate1.TabIndex = 7;
            // 
            // txtRate2
            // 
            this.txtRate2.Location = new System.Drawing.Point(210, 186);
            this.txtRate2.Name = "txtRate2";
            this.txtRate2.Size = new System.Drawing.Size(109, 22);
            this.txtRate2.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(162, 386);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(285, 386);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rate for 3Hrs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rate for 4Hrs";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.cmbCategory.Location = new System.Drawing.Point(210, 68);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(109, 24);
            this.cmbCategory.TabIndex = 15;
            // 
            // txtRate3
            // 
            this.txtRate3.Location = new System.Drawing.Point(210, 238);
            this.txtRate3.Name = "txtRate3";
            this.txtRate3.Size = new System.Drawing.Size(109, 22);
            this.txtRate3.TabIndex = 16;
            // 
            // txtRate4
            // 
            this.txtRate4.Location = new System.Drawing.Point(210, 290);
            this.txtRate4.Name = "txtRate4";
            this.txtRate4.Size = new System.Drawing.Size(109, 22);
            this.txtRate4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Whole Day";
            // 
            // txtWholeDay
            // 
            this.txtWholeDay.Location = new System.Drawing.Point(210, 342);
            this.txtWholeDay.Name = "txtWholeDay";
            this.txtWholeDay.Size = new System.Drawing.Size(109, 22);
            this.txtWholeDay.TabIndex = 19;
            // 
            // PriceRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtWholeDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRate4);
            this.Controls.Add(this.txtRate3);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRate2);
            this.Controls.Add(this.txtRate1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblTicketCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PriceRate";
            this.Size = new System.Drawing.Size(969, 435);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTicketCategory;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRate1;
        private System.Windows.Forms.TextBox txtRate2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtRate3;
        private System.Windows.Forms.TextBox txtRate4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWholeDay;
    }
}
