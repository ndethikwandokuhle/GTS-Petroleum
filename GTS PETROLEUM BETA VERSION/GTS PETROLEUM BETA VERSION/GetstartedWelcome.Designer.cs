
namespace GTS_PETROLEUM_BETA_VERSION
{
    partial class GetstartedWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetstartedWelcome));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.next_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 200);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.next_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 43);
            this.panel2.TabIndex = 6;
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
            // GetstartedWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetstartedWelcome";
            this.Size = new System.Drawing.Size(466, 284);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button next_btn;
    }
}
