namespace Manage
{
    partial class frmsign
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
            this.btnlog = new System.Windows.Forms.Button();
            this.btnsign = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(30, 170);
            this.btnlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(150, 37);
            this.btnlog.TabIndex = 0;
            this.btnlog.Text = "LOG IN";
            this.btnlog.UseVisualStyleBackColor = true;
            // 
            // btnsign
            // 
            this.btnsign.Location = new System.Drawing.Point(30, 108);
            this.btnsign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(150, 37);
            this.btnsign.TabIndex = 1;
            this.btnsign.Text = "SIGNUP";
            this.btnsign.UseVisualStyleBackColor = true;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(231, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 340);
            this.panel2.TabIndex = 2;
            // 
            // frmsign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.btnlog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmsign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.sign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Panel panel2;
    }
}