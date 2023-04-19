
namespace GTS_PETROLEUM_BETA_VERSION
{
    partial class GetstartedFinish
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 43);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click Finish To Complete Configuration Process";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(114, 145);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(237, 38);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Get Started";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(161, 110);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "First View My Data";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GetstartedFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetstartedFinish";
            this.Size = new System.Drawing.Size(466, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
