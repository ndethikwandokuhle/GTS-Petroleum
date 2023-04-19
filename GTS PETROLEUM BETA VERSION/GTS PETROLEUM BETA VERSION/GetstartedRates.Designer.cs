
namespace GTS_PETROLEUM_BETA_VERSION
{
    partial class GetstartedRates
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.next_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.diesel = new System.Windows.Forms.NumericUpDown();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.petrol = new System.Windows.Forms.NumericUpDown();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diesel)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petrol)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.next_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 43);
            this.panel2.TabIndex = 7;
            // 
            // next_btn
            // 
            this.next_btn.Image = global::GTS_PETROLEUM_BETA_VERSION.Properties.Resources.fast_forward_20px;
            this.next_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.next_btn.Location = new System.Drawing.Point(334, 9);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(123, 25);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(98, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 107);
            this.panel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.panel21);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 33);
            this.panel6.TabIndex = 12;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel21.Controls.Add(this.diesel);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(111, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(154, 33);
            this.panel21.TabIndex = 14;
            // 
            // diesel
            // 
            this.diesel.BackColor = System.Drawing.Color.White;
            this.diesel.DecimalPlaces = 2;
            this.diesel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diesel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.diesel.Location = new System.Drawing.Point(0, 1);
            this.diesel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.diesel.Name = "diesel";
            this.diesel.Size = new System.Drawing.Size(154, 31);
            this.diesel.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(111, 33);
            this.panel13.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(67, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "USD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diesel";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.panel19);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 33);
            this.panel4.TabIndex = 10;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel19.Controls.Add(this.petrol);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(111, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(154, 33);
            this.panel19.TabIndex = 13;
            // 
            // petrol
            // 
            this.petrol.BackColor = System.Drawing.Color.White;
            this.petrol.DecimalPlaces = 2;
            this.petrol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrol.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.petrol.Location = new System.Drawing.Point(0, 1);
            this.petrol.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.petrol.Name = "petrol";
            this.petrol.Size = new System.Drawing.Size(154, 31);
            this.petrol.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(111, 33);
            this.panel11.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(67, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Petrol";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 33);
            this.panel3.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(111, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(154, 33);
            this.panel9.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pump Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(111, 33);
            this.panel7.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tank Name";
            // 
            // GetstartedRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetstartedRates";
            this.Size = new System.Drawing.Size(466, 284);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diesel)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petrol)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.NumericUpDown diesel;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.NumericUpDown petrol;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}
