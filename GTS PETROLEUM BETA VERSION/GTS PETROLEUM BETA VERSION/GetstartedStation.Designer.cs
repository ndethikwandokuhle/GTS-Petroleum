
namespace GTS_PETROLEUM_BETA_VERSION
{
    partial class GetstartedStation
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
            this.label1 = new System.Windows.Forms.Label();
            this.station_cbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Configure the system to your station.";
            // 
            // station_cbx
            // 
            this.station_cbx.BackColor = System.Drawing.Color.White;
            this.station_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station_cbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.station_cbx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_cbx.ForeColor = System.Drawing.Color.Black;
            this.station_cbx.FormattingEnabled = true;
            this.station_cbx.Items.AddRange(new object[] {
            "",
            "GTS Zvishavane",
            "GTS Kwekwe",
            "GTS Mberengwa Consolidated"});
            this.station_cbx.Location = new System.Drawing.Point(95, 139);
            this.station_cbx.Name = "station_cbx";
            this.station_cbx.Size = new System.Drawing.Size(269, 28);
            this.station_cbx.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(95, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "--Select Station--";
            // 
            // GetstartedStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.station_cbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetstartedStation";
            this.Size = new System.Drawing.Size(466, 284);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox station_cbx;
        private System.Windows.Forms.Label label2;
    }
}
