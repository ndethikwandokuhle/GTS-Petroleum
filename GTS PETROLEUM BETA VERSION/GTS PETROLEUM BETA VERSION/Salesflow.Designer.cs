
namespace GTS_PETROLEUM_BETA_VERSION
{
    partial class Salesflow
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
            this.label1 = new System.Windows.Forms.Label();
            this.cashvalue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.prepaidvalue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.postpaidvalue = new System.Windows.Forms.NumericUpDown();
            this.sales_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cashvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaidvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postpaidvalue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Clients:";
            // 
            // cashvalue
            // 
            this.cashvalue.DecimalPlaces = 2;
            this.cashvalue.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cashvalue.Location = new System.Drawing.Point(90, 50);
            this.cashvalue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cashvalue.Name = "cashvalue";
            this.cashvalue.Size = new System.Drawing.Size(128, 23);
            this.cashvalue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prepaid Accounts:";
            // 
            // prepaidvalue
            // 
            this.prepaidvalue.DecimalPlaces = 2;
            this.prepaidvalue.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.prepaidvalue.Location = new System.Drawing.Point(90, 104);
            this.prepaidvalue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.prepaidvalue.Name = "prepaidvalue";
            this.prepaidvalue.Size = new System.Drawing.Size(128, 23);
            this.prepaidvalue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Postpaid Accounts:";
            // 
            // postpaidvalue
            // 
            this.postpaidvalue.DecimalPlaces = 2;
            this.postpaidvalue.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.postpaidvalue.Location = new System.Drawing.Point(90, 157);
            this.postpaidvalue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.postpaidvalue.Name = "postpaidvalue";
            this.postpaidvalue.Size = new System.Drawing.Size(128, 23);
            this.postpaidvalue.TabIndex = 1;
            // 
            // sales_btn
            // 
            this.sales_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.sales_btn.Image = global::GTS_PETROLEUM_BETA_VERSION.Properties.Resources.validation_20px;
            this.sales_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales_btn.Location = new System.Drawing.Point(29, 250);
            this.sales_btn.Name = "sales_btn";
            this.sales_btn.Size = new System.Drawing.Size(216, 38);
            this.sales_btn.TabIndex = 3;
            this.sales_btn.Text = "Record";
            this.sales_btn.UseVisualStyleBackColor = true;
            this.sales_btn.Click += new System.EventHandler(this.sales_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "5000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.postpaidvalue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prepaidvalue);
            this.groupBox1.Controls.Add(this.cashvalue);
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Breakdown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(55, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "litres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(55, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "litres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(55, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "litres";
            // 
            // Salesflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sales_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Salesflow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesflow";
            this.Load += new System.EventHandler(this.Salesflow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaidvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postpaidvalue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cashvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prepaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown postpaid;
        private System.Windows.Forms.Button sales_btn;
        private System.Windows.Forms.NumericUpDown prepaidvalue;
        private System.Windows.Forms.NumericUpDown postpaidvalue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}