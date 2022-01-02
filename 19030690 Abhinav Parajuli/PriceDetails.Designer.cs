
namespace _19030690_Abhinav_Parajuli
{
    partial class PriceDetails
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
            this.priceGridView = new System.Windows.Forms.DataGridView();
            this.btnReadPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // priceGridView
            // 
            this.priceGridView.BackgroundColor = System.Drawing.Color.White;
            this.priceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceGridView.Location = new System.Drawing.Point(20, 143);
            this.priceGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceGridView.Name = "priceGridView";
            this.priceGridView.RowHeadersWidth = 51;
            this.priceGridView.RowTemplate.Height = 24;
            this.priceGridView.Size = new System.Drawing.Size(1129, 645);
            this.priceGridView.TabIndex = 0;
            // 
            // btnReadPrice
            // 
            this.btnReadPrice.Location = new System.Drawing.Point(973, 815);
            this.btnReadPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadPrice.Name = "btnReadPrice";
            this.btnReadPrice.Size = new System.Drawing.Size(156, 37);
            this.btnReadPrice.TabIndex = 1;
            this.btnReadPrice.Text = "Read";
            this.btnReadPrice.UseVisualStyleBackColor = true;
            this.btnReadPrice.Click += new System.EventHandler(this.btnReadPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(5)))));
            this.label1.Location = new System.Drawing.Point(409, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price Details";
            // 
            // PriceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadPrice);
            this.Controls.Add(this.priceGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PriceDetails";
            this.Size = new System.Drawing.Size(1169, 873);
            ((System.ComponentModel.ISupportInitialize)(this.priceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView priceGridView;
        private System.Windows.Forms.Button btnReadPrice;
        private System.Windows.Forms.Label label1;
    }
}
