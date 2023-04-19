
namespace GTS_PETROLEUM_BETA_VERSION
{
    partial class Deliveryallocation2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deliveries_gdv = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deliveries_gdv)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveries_gdv
            // 
            this.deliveries_gdv.AllowUserToAddRows = false;
            this.deliveries_gdv.AllowUserToDeleteRows = false;
            this.deliveries_gdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deliveries_gdv.BackgroundColor = System.Drawing.Color.White;
            this.deliveries_gdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveries_gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveries_gdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn2,
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column9});
            this.deliveries_gdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveries_gdv.Location = new System.Drawing.Point(0, 0);
            this.deliveries_gdv.Name = "deliveries_gdv";
            this.deliveries_gdv.ReadOnly = true;
            this.deliveries_gdv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.deliveries_gdv.Size = new System.Drawing.Size(1082, 258);
            this.deliveries_gdv.TabIndex = 17;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "Record ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "deliverydate";
            this.dataGridViewTextBoxColumn2.FillWeight = 144.1624F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Delivery Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "invoiceno";
            this.Column6.HeaderText = "Invoice No.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dnoteno";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "D-Note No.";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "t1beforeqty";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Tank1 Before";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "t1afterqty";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Tank1 After";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "t1movement";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Tank1 Movement";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "t2beforeqty";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(9)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Tank2 Before";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "t2afterqty";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(9)))));
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "Tank2 After";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "t2movement";
            this.Column9.HeaderText = "Tank2 Movement";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Deliveryallocation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 258);
            this.Controls.Add(this.deliveries_gdv);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deliveryallocation2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Allocation";
            this.Load += new System.EventHandler(this.Deliveryallocation2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveries_gdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView deliveries_gdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}